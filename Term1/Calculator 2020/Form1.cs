using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator_2020
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            (float one, float two) AssignedValues = ValuePasser.ParseAssignValues(txtNum1.Text, txtNum2.Text);

            float Answer = Calculator.Multiply(AssignedValues.one, AssignedValues.two);

            lbxAnswer.Items.Add($@"{AssignedValues.one} * {AssignedValues.two} = {Answer}");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            (float one, float two) AssignedValues = ValuePasser.ParseAssignValues(txtNum1.Text, txtNum2.Text);

            float Answer = Calculator.Addition(AssignedValues.one, AssignedValues.two);

            lbxAnswer.Items.Add($@"{AssignedValues.one} + { AssignedValues.two} = {Answer}");


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            (float one, float two) AssignedValues = ValuePasser.ParseAssignValues(txtNum1.Text, txtNum2.Text);

            float Answer = Calculator.Minus(AssignedValues.one, AssignedValues.two);

            lbxAnswer.Items.Add($@"{AssignedValues.one} - { AssignedValues.two} = {Answer}");


        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            (float one, float two) AssignedValues = ValuePasser.ParseAssignValues(txtNum1.Text, txtNum2.Text);

            float Answer = Calculator.Divide(AssignedValues.one, AssignedValues.two);

            lbxAnswer.Items.Add($@"{AssignedValues.one} / { AssignedValues.two} = {Answer}");


        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Creating a Method in a Class


    }
}
