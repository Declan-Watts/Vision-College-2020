using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            bool result = PalindroneClass.CheckPalindrone(txtInput.Text);
            
            if (result)
            {
                lbxOutput.Items.Add($"It Is the same First and Backwards: '{txtInput.Text}'");
            }
        }
    }
}
