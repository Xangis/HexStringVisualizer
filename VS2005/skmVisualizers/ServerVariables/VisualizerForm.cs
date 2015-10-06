using System;
using System.IO;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HexStringVisualizer
{
    public partial class VisualizerForm : Form
    {
        public VisualizerForm()
        {
            InitializeComponent();
        }

        public void Visualize(String str)
        {
            String output = String.Empty;
            String rawInput = String.Empty;
            foreach (Char ch in str)
            {
                output += String.Format("{0:x2} ", (byte)ch);
                if (ch != 0)
                {
                    rawInput += ch;
                }
                else
                {
                    rawInput += " ";
                }
            }

            NamesAndValues.Text = output;
            txtOriginalString.Text = rawInput;
            this.Text = "Hexadecimal String (Length " + str.Length + ")";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}