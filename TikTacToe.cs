namespace TicTacToe
{
    public partial class TikTacToe : Form
    {
        public TikTacToe()
        {
            InitializeComponent();
        }

        public string? difficulty;
        public char Player_Marker;
        private void Menu_Options_Click(object sender, EventArgs e)
        {
            Options optionsWindow = new Options(passingDiff: difficulty, passingMarker: Player_Marker);

            optionsWindow.ShowDialog();  //open option window
            string? diffSelection = optionsWindow.difficulty;
            char markerSelection = optionsWindow.Player_Marker;
            if (diffSelection != null)
                difficulty = diffSelection;
            Player_Marker = markerSelection;
        }

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "Exit Tik Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }
    }
}
