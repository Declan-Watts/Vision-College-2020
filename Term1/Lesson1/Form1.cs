using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        int Age;
        public Form1()
        {
            InitializeComponent();
            Age = 19;
        }

        private void lbxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string Name = "Declan";
            Age++;
            lblOutput1.Text = txtOutput.Text;
            lbxOutput.Items.Add(Name + " " + Age);
            // MessageBox.Show("Hello " + Name + " welcmome to c#");

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
