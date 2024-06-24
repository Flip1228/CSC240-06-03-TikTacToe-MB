using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms.VisualStyles;

namespace TicTacToe
{
    public partial class TikTacToe : Form
    {

        private char[] board;
        private Random random = new Random();
        private string? difficulty;
        private char Player_Marker;
        private char Computer_Marker;
        private char currentPlayer;
        // Computer wins, Player Wins
        private int[] scoreKeeper = { 0, 0 };

        public TikTacToe()
        {
            InitializeComponent();
            OptionsWindow();
            board = new char[9];
            InitializeGame();
        }
        private void Menu_Options_Click(object sender, EventArgs e)
        {
            OptionsWindow();
        }
        private void OptionsWindow()
        {
            Options optionsWindow = new Options(passingDiff: difficulty, passingMarker: Player_Marker);

            optionsWindow.ShowDialog();  //open option window
            string? diffSelection = optionsWindow.difficulty;
            char markerSelection = optionsWindow.Player_Marker;
            if (diffSelection != null)
            {
                difficulty = diffSelection;
                Player_Marker = markerSelection;
            }
        }

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "Exit Tik Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
                Application.Exit();
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = ' ';
                Controls["button" + i].Text = "";
                Controls["button" + i].Enabled = true;
            }
            if (Player_Marker == 'X')
                Computer_Marker = 'O';
            else if (Player_Marker == 'O')
                    Computer_Marker = 'X';
            currentPlayer = Player_Marker;
            turnLabel.Text = $"Player {currentPlayer}'s turn";
            turnLabel.Visible = true;
        }

        //private void startButton_Click(object sender, EventArgs e)
        //{
        //    if (difficulty != null && Player_Marker != ' ')
        //        InitializeGame();
        //    else
        //        MessageBox.Show("Please go to file and options to select options.");
        //}

        private void BoardButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(6));
            if (board[index] == ' ')
            {
                board[index] = Player_Marker;
                button.Text = Player_Marker.ToString();
                button.Enabled = false;
                if (CheckWin())
                {
                    turnLabel.Text = $"Player {currentPlayer} wins!";
                    EndGame();
                }
                else if (board.All(x => x != ' '))
                {
                    turnLabel.Text = "It's a draw!";
                    EndGame();
                }
                else
                {
                    currentPlayer = Computer_Marker;
                    turnLabel.Text = $"Player {currentPlayer}'s turn!";
                    ComputerMove();
                }
            }
        }


        private void ComputerMove()
        {
            int move;

            if (difficulty == "Easy")
            {
                move = RandomMove();
            }
            else if (difficulty == "Normal")
            {
                move = NormalMove();
            }
            else
            {
                move = HardMove();
            }

            board[move] = Computer_Marker;

            Button button = (Button)Controls["button" + move];
            button.Text = Computer_Marker.ToString();
            button.Enabled = false;
            if (CheckWin())
            {
                turnLabel.Text = $"Player {currentPlayer} wins!";
                EndGame();
            }
            else if (board.All(x => x != ' '))
            {
                turnLabel.Text = "It's a draw!";
                EndGame();
            }
            else
            {
                currentPlayer = Player_Marker;
                turnLabel.Text = $"Player {currentPlayer}'s turn!";
            }
        }


        private int RandomMove() // only some times takes its turn
        {
            int move;

            do
            {
                move = random.Next(0, 9);
            }
            while (board[move] != ' ');

            return move;
        }

        private int NormalMove() //isnt saying the computer won if it wins and allows you to keep selecting
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == ' ')
                {
                    board[i] = Computer_Marker;
                    if (CheckWin())
                    {
                        board[i] = Computer_Marker;
                        return i;
                    }
                    board[i] = ' ';
                }
            }

            for (int i = 0; i < 9; i++)
            {
                if (board[i] == ' ')
                {
                    board[i] = Player_Marker;
                    if (CheckWin())
                    {
                        board[i] = Computer_Marker;
                        return i;
                    }
                    board[i] = ' ';
                }
            }
            return RandomMove();
        }

        private int HardMove()
        {
            return Minimax(board, Computer_Marker).Item1;
        }

        private (int, int) Minimax(char[] boardState, char player) //borrowed some of this method 
        {
            char opponent = player == Computer_Marker ? Player_Marker : Computer_Marker;

            if (CheckWinFor(boardState, Computer_Marker))
                return (0, 10);
            if (CheckWinFor(boardState, Player_Marker))
                return (-1, -10);
            if (boardState.All(x => x != ' '))
                return (-1, 0);

            var bestMove = (-1, player == Computer_Marker ? int.MinValue : int.MaxValue);

            for (int i = 0; i < 9; i++)
            {
                if (boardState[i] == ' ')
                {
                    boardState[i] = player;
                    var score = Minimax(boardState, opponent).Item2;
                    boardState[i] = ' ';

                    if (player == currentPlayer)
                    {
                        if (score > bestMove.Item2)
                            bestMove = (i, score);
                    }
                    else
                    {
                        if (score < bestMove.Item2)
                            bestMove = (i, score);
                    }
                }
            }
            return bestMove;
        }

        private bool CheckWin()
        {
            return CheckWinFor(board, currentPlayer);
        }

        private bool CheckWinFor(char[] boardState, char player)
        {
            int[,] winPositions = new int[,]
            {
                {0, 1, 2},
                {3, 4, 5},
                {6, 7, 8},
                {0, 3, 6},
                {1, 4, 7},
                {2, 5, 8},
                {0, 4, 8},
                {2, 4, 6}
            };

            for (int i = 0; i < winPositions.GetLength(0); i++)
            {
                if (boardState[winPositions[i, 0]] == player &&
                    boardState[winPositions[i, 1]] == player &&
                    boardState[winPositions[i, 2]] == player)
                {
                    return true;
                }
            }
            return false;
        }

        private void EndGame()
        {
            for (int i = 0; i < 9; i++)
            {
                Controls["button" + i].Enabled = false;
            }
        }

    }
}
