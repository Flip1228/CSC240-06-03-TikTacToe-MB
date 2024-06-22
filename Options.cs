namespace TicTacToe
{
    public partial class Options : Form
    {

        public string? difficulty { get; private set; }
        public char Player_Marker { get; private set; }

        public Options(string passingDiff, char passingMarker)
        {
            InitializeComponent();
            InitializeOptions(passingDiff, passingMarker);
        }

        private void InitializeOptions(string diff, char Marker)
        {

            if (diff is not null)
            {
                if (diff == "Easy")
                    easyRadio.Checked = true;
                if (diff == "Normal")
                    normalRadio.Checked = true;
                if (diff == "Hard")
                    hardRadio.Checked = true;
            }
            if (Marker == 'X')
                xMarkerRadio.Checked = true;
            if (Marker == 'O')
                oMarkerRadio.Checked = true;
        }


        private void Difficulty_CheckedChanged(object sender, EventArgs e)
        {
            if (easyRadio.Checked is true)
                difficulty = "Easy";
            if (normalRadio.Checked is true)
                difficulty = "Normal";
            if (hardRadio.Checked is true)
                difficulty = "Hard";
        }

        private void Marker_CheckedChanged(object sender, EventArgs e)
        {
            if (xMarkerRadio.Checked is true)
                Player_Marker = 'X';
            if (oMarkerRadio.Checked is true)
                Player_Marker = 'O';
        }

        private static bool Force_Options(GroupBox grpbox)
        {
            foreach (Control control in grpbox.Controls)
            {
                if (control is RadioButton radiobutton && radiobutton.Checked)
                    return true;
            }
            return false;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (Force_Options(markerGroup) is true && Force_Options(difficultyGroup) is true)
                this.Close();
            else
                MessageBox.Show("Please select both group of options");
        }


    }
}
