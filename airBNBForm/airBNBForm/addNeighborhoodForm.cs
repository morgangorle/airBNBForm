using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airBNBForm
{
    public partial class addNeighborhoodForm : Form
    {
        addNeighborhoodForm currentForm;
        int districtIndex;
        public addNeighborhoodForm()
        {
            InitializeComponent();
            currentForm = this;
            errorLabel.Text = "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DistrictForm.initialForm.Show();
            currentForm.Close();
        }

        private void AddNHoodButton_Click(object sender, EventArgs e)
        {

            if (searchDistrict(districtBox.Text) == true)
            {
                Neighborhood newNeighborhood = new Neighborhood(NHoodBox.Text);
                DistrictForm.initialForm.database[districtIndex].addNHood(newNeighborhood);
                DistrictForm.initialForm.updateData();
                DistrictForm.initialForm.Show();
                currentForm.Close();
            }
            else
            {
                errorLabel.Text = "District not found";
            }

        }
        private Boolean searchDistrict(string inputDistrict)
        {
            Boolean foundDistrict = false;
            int searchIndex = 0;
            while (foundDistrict == false && searchIndex < DistrictForm.initialForm.numOfDistricts)
            {
                if(inputDistrict == DistrictForm.initialForm.database[searchIndex].getDistrictName())
                {
                    foundDistrict = true;
                    districtIndex = searchIndex;
                    return true;
                }
                searchIndex++;
            }

            return false;

        }
    }
}
