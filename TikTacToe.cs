namespace TicTacToe
{
    public partial class TikTacToe : Form
    {
        public TikTacToe()
        {
            InitializeComponent();
        }

        public string? difficulty;
        public string? Player_Marker;
        private void Menu_Options_Click(object sender, EventArgs e)
        {
            using (Options optionsWindow = new Options(difficulty, Player_Marker))
            {
                
             DialogResult result =  optionsWindow.ShowDialog();
                if(result == DialogResult.OK)
                {
                    string? diffSelection = optionsWindow.difficulty;
                    string? markerSelection = optionsWindow.Player_Marker;
                    if (diffSelection != null)
                        difficulty = diffSelection;
                    if (markerSelection != null)
                        Player_Marker = markerSelection;
                }
            }
            MessageBox.Show($"Difficulty is {difficulty} and Marker is {Player_Marker}");
        }

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit? Scores will be lost unless you save them.","Exit Tik Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

    }
}
