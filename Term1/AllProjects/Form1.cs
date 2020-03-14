using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllProjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes Program
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            dashPanel.Visible = true;
            calcPanel.Visible = false;
            tmpPanel.Visible = false;
            dashPanel.BringToFront();
            dashPanel.Enabled = true;
            calcPanel.Enabled = false;
            tmpPanel.Enabled = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            dashPanel.Visible = false;
            calcPanel.Visible = true;
            tmpPanel.Visible = false;
            calcPanel.BringToFront();
            dashPanel.Enabled = false;
            calcPanel.Enabled = true;
            tmpPanel.Enabled = false;
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            dashPanel.Visible = false;
            calcPanel.Visible = false;
            tmpPanel.Visible = true;
            tmpPanel.BringToFront();
            dashPanel.Enabled = false;
            calcPanel.Enabled = true;
            tmpPanel.Enabled = true;
        }

        private void btnCalcAdd_Click(object sender, EventArgs e)
        {
            (float one, float two) AssignedValues = ValuePasser.ParseAssignValues(txtCalcNum1.Text, txtCalcNum2.Text);

            float Answer = Calculator.Addition(AssignedValues.one, AssignedValues.two);

            lbxCalcAnswer.Items.Add($@"{AssignedValues.one} + { AssignedValues.two} = {Answer}");
        }

        private void btnCalcMinus_Click(object sender, EventArgs e)
        {
            (float one, float two) AssignedValues = ValuePasser.ParseAssignValues(txtCalcNum1.Text, txtCalcNum2.Text);

            float Answer = Calculator.Minus(AssignedValues.one, AssignedValues.two);

            lbxCalcAnswer.Items.Add($@"{AssignedValues.one} - { AssignedValues.two} = {Answer}");
        }

        private void btnCalcMultiply_Click(object sender, EventArgs e)
        {
            (float one, float two) AssignedValues = ValuePasser.ParseAssignValues(txtCalcNum1.Text, txtCalcNum2.Text);

            float Answer = Calculator.Multiply(AssignedValues.one, AssignedValues.two);

            lbxCalcAnswer.Items.Add($@"{AssignedValues.one} * {AssignedValues.two} = {Answer}");
        }

        private void btnCalcDivide_Click(object sender, EventArgs e)
        {
            (float one, float two) AssignedValues = ValuePasser.ParseAssignValues(txtCalcNum1.Text, txtCalcNum2.Text);

            float Answer = Calculator.Divide(AssignedValues.one, AssignedValues.two);

            lbxCalcAnswer.Items.Add($@"{AssignedValues.one} / { AssignedValues.two} = {Answer}");
        }
    }
}
