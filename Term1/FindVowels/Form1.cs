using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindVowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string lol = txtWord.Text.ToLower();
            char[] vowles = { 'a', 'e', 'i', 'o', 'u' };
            this.Text = lol;
            char[] letters = lol.ToCharArray();


            foreach (char letter in letters)
            {
                if (vowles.Contains(letter) )
                {
                    lbxOutput.Items.Add(letter);
                }
            }
        }
    }
}
