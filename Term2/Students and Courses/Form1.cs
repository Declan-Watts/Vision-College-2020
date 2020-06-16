using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Students_and_Courses.Business;

namespace Students_and_Courses
{
    public partial class Form1 : Form
    {

        Programming programmingStudent = new Programming();
        NZBAT nzbatStudent = new NZBAT();


        public Form1()
        {
            InitializeComponent();

            programmingStudent.isCokeDrinker = true;
            nzbatStudent.isTeaDrinker = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
