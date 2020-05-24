using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // strng int float/single doubles bool

            lbxArray.Items.Clear();

            //Array ...
            Random random = new Random();

            int rnd = random.Next(0, 7);

            string[] Name = { "Reuben", "Vaughn", "Jack", "Jeremy", "Femi", "Lyle", "Declan" }; //new string[9];

            for (int i = 0; i < Name.Length; i++)
            {
                lbxArray.Items.Add(Name[i]);
                if (rnd == i)
                {
                    lbxArray.Items.Add($"Winner is {Name[i]}");
                }
            }
            

        }

    }
}
