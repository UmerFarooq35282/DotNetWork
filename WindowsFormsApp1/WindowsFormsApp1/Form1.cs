using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            string value = InputBox.Text;
            int LatterVal = 1;
            if (string.IsNullOrEmpty(value))
            {
                EnteredTextLbl.Text += " ";
                TotalCharsLbl.Text = 0.ToString();
                CharacterLbl.Text = "0";
            }
            else
            {
                EnteredTextLbl.Text = value;
                int length = value.Length;
                TotalCharsLbl.Text = length.ToString();
                

                for(int i = 0; i < value.Length; i++)
                {
                    char c = value[i];
                    if(c == ' ' || c == ',' || c == '.')
                    {
                        LatterVal = LatterVal + 1;
                    }
                }
                CharacterLbl.Text = LatterVal.ToString();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
