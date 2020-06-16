using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpyAgency2019.Business;
using SpyAgency2019.Data;

namespace SpyAgency2019
{
    public partial class Form1 : Form
    {
        Spy DefaultSpy = new Spy();


        public Form1()
        {
            InitializeComponent();
            LoadSpy();

            cbspylevel.SelectedIndex = 0; //Set the first option in the combobox
        }
        private void BtnSpyDetails_Click(object sender, EventArgs e)
        {
            LoadSpy();
            //lets you save your spy after you made it by making visible the button
            btnSaveSpy.Visible = true;
        }

        private void LoadSpy()
        {

            lbxSpy.Items.Clear();
            //add the code name and others from the form
            txtCodeName.Text = DefaultSpy.codeName;
            txtAgencyCountry.Text = DefaultSpy.Agency.Country;
            txtAgencyName.Text = DefaultSpy.Agency.AgencyName;
            //DefaultSpy.codeName = txtCodeName.Text;
            //DefaultSpy.Agency.Country = txtAgencyCountry.Text;
            //DefaultSpy.Agency.AgencyName = txtAgencyName.Text;


            // if the string is null then put a 0 otherwise put the number
            DefaultSpy.Agency.NumberOfAgents = string.IsNullOrEmpty(txtNumberOfAgents.Text) ? 0 : Convert.ToInt32(txtNumberOfAgents.Text);

            FillListBox();

            //work out the age
            lbxSpy.Items.Add("Spy is " + DefaultSpy.YearsOld(dtpDOB.Value) + " years old");

            //work out how long since seen
            lbxSpy.Items.Add(DefaultSpy.DaysSinceLastSeen(dtpLastSeen.Value) + " days last seen");
            //How many agents in the spy group
            lbxSpy.Items.Add("There are " + DefaultSpy.Agency.NumberOfAgents + " spies");

        }

        private void FillListBox()
        {
            lbxSpy.Items.Clear();
            lbxSpy.Items.Add("Code name: " + DefaultSpy.codeName);
            lbxSpy.Items.Add("Agent can use a " + DefaultSpy.killAbility);
            lbxSpy.Items.Add("Agent weapon is a " + DefaultSpy.weapon);
            lbxSpy.Items.Add("Home: " + DefaultSpy.Home());
            lbxSpy.Items.Add("Lives in " + DefaultSpy.Agency.Country);
        }

        private void DtpDOB_ValueChanged(object sender, EventArgs e)
        {
            LoadSpy();
        }

        private void Cbspylevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseSpyLevel();

        }

        public void ChooseSpyLevel()
        {
            //select a level of spy and instantiate it
            var MyChosenSpy = Factory.GetASpy(cbspylevel.SelectedIndex);
            //pass across the values to the default spy
            DefaultSpy = MyChosenSpy;

            //empty the Listbox
            lbxSpy.Items.Clear();
            //see it on the listbox with default settings
            FillListBox();
            //
        }

        //save your spy details
        private void btnSaveSpy_Click(object sender, EventArgs e)
        {

            //create and fill a list of data
            List<string> FileData = new List<string>();

            foreach (string line in lbxSpy.Items)
            {
                FileData.Add(line);
            }


            //print out if there is a codename as it will be used as the filename
            if (DefaultSpy.codeName != null)
            {
                //  DefaultSpy.CodeName = txtCodeName.Text;
                string filename = DefaultSpy.codeName;
                Data.FileOperations.SaveFile(filename, FileData);
                btnSaveSpy.Visible = false;
                MessageBox.Show("File named " + filename + ".txt" + " has been saved");
            }
            else
            {
                MessageBox.Show("Cannot save until you have a Code Name");
            }
        }



        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            lbxSpy.Items.Clear();
            lbxSpy.Items.AddRange(FileOperations.ListAllFiles().ToArray());
        }
        //load file based on selected file name
        private void lbspy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {//get the name you click on
                string ChosenFileName = Convert.ToString(lbxSpy.SelectedItem);
                lbxSpy.Items.Clear();
                //load the file with that name
                lbxSpy.Items.AddRange(FileOperations.ReturnFileData(ChosenFileName).ToArray());
            }
            catch (Exception exception)
            {
                lbxSpy.Items.Add("Error Occured");
                MessageBox.Show(exception.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
