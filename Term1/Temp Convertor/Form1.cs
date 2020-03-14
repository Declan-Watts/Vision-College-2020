using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp_Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            // Parse Text into Floats
            float temp = ValueParsser.ParseFloat(txtTemp.Text);
            // Send Floats to Convertor Method
            float Answer = Temperature.ConvertToCelsius(temp);
            // Display Result in LbxOutput
            lbxOutput.Items.Add($"{Answer} Degrees Celsius");
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            // Parse Text into Floats
            float temp = ValueParsser.ParseFloat(txtTemp.Text);
            // Send Floats to Convertor Method
            float Answer = Temperature.ConvertToFahrenheit(temp);
            // Display Result in LbxOutput
            lbxOutput.Items.Add($"{Answer} Degrees Fahrenheit");
        }
    }
}
