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

            Tuple<float, float> AssignedValues = ParseAssignValues(txtNum1.Text, txtNum2.Text);

            AssignedValues.Deconstruct<float, float>(out float one, out float two); // This is not neccesary but for big prjects will save memory

            float Answer = Calculator.Multiply(one, two);

            lbxAnswer.Items.Add($@"{one} * {two} = {Answer}");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Tuple<float, float> AssignedValues = ParseAssignValues(txtNum1.Text, txtNum2.Text);

            AssignedValues.Deconstruct<float, float>(out float one, out float two);

            float Answer = Calculator.Addition(one, two);

            lbxAnswer.Items.Add($@"{one} + {two} = {Answer}");


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Tuple<float, float> AssignedValues = ParseAssignValues(txtNum1.Text, txtNum2.Text);

            AssignedValues.Deconstruct<float, float>(out float one, out float two);

            float Answer = Calculator.Minus(one, two);

            lbxAnswer.Items.Add($@"{one} - {two} = {Answer}");


        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Tuple<float, float> AssignedValues = ParseAssignValues(txtNum1.Text, txtNum2.Text);

            AssignedValues.Deconstruct<float, float>(out float one, out float two);

            float Answer = Calculator.Divide(one, two);

            lbxAnswer.Items.Add($@"{one} / {two} = {Answer}");


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

        private Tuple<float, float> ParseAssignValues(string txt1, string txt2)
        {
            float.TryParse(txt1, out float a); //This does a Try Catch statement so if it cannot convert it will make it null
            float.TryParse(txt2, out float b);

            return Tuple.Create(a, b);
        }
    }
}
