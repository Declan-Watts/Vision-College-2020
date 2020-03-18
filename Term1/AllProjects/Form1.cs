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
            gtnPanel.Enabled = false;
            gtnPanel.Visible = false;
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
            gtnPanel.Enabled = false;
            gtnPanel.Visible = false;
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            dashPanel.Visible = false;
            calcPanel.Visible = false;
            tmpPanel.Visible = true;
            tmpPanel.BringToFront();
            dashPanel.Enabled = false;
            calcPanel.Enabled = false;
            tmpPanel.Enabled = true;
            gtnPanel.Enabled = false;
            gtnPanel.Visible = false;
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

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            // Parse Text into Floats
            float temp = ValuePasser.ParseFloat(txtTemp.Text);
            // Send Floats to Convertor Method
            float Answer = Temperature.ConvertToCelsius(temp);
            // Display Result in LbxOutput
            lbxTempOutput.Items.Add($"{Answer} Degrees Celsius");
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            // Parse Text into Floats
            float temp = ValuePasser.ParseFloat(txtTemp.Text);
            // Send Floats to Convertor Method
            float Answer = Temperature.ConvertToFahrenheit(temp);
            // Display Result in LbxOutput
            lbxTempOutput.Items.Add($"{Answer} Degrees Fahrenheit");
        }

        private void btnGuessTheNumber_Click(object sender, EventArgs e)
        {
            dashPanel.Visible = false;
            calcPanel.Visible = false;
            tmpPanel.Visible = false;
            gtnPanel.BringToFront();
            dashPanel.Enabled = false;
            calcPanel.Enabled = false;
            tmpPanel.Enabled = false;
            gtnPanel.Enabled = true;
            gtnPanel.Visible = true;
        }

        private void btnHigher_Click(object sender, EventArgs e)
        {

        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {

        }

        private void btnLower_Click(object sender, EventArgs e)
        {

        }

        private void btnGTNStart_Click(object sender, EventArgs e)
        {
            GTN.Start();
        }
    }
}
