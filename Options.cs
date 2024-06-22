using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Options : Form
    {

        public string? difficulty { get; private set; }
        public string? Player_Marker { get; private set; }

        public Options(string passingDiff, string passingMarker)
        {
            InitializeComponent();
            InitializeOptions(passingDiff, passingMarker);
        }

        private void InitializeOptions(string diff, string Marker)
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

            if (Marker is not null)
            {
                if (Marker == "X")
                    xMarkerRadio.Checked = true;
                if (Marker == "O")
                    oMarkerRadio.Checked = true;
            }
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
                Player_Marker = "X";
            if (oMarkerRadio.Checked is true)
                Player_Marker = "O";
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
