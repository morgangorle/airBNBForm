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
    public partial class searchPropertyForm : Form
    {
        searchPropertyForm currentForm;
        District[] currentData;
        int numOfDistricts;
        public searchPropertyForm()
        {
            InitializeComponent();
            currentForm = this;
            currentData = DistrictForm.initialForm.database;
            numOfDistricts = DistrictForm.initialForm.numOfDistricts;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchResultsBox.Items.Clear();
            try
            {
                if(districtCheckBox.Checked != true && NHoodCheckBox.Checked != true)
                {
                    double maxPrice = double.Parse(maxPriceBox.Text);
                    for (int districtIndex = 0; districtIndex < numOfDistricts; districtIndex++)
                    {
                        for (int nHoodIndex = 0; nHoodIndex < currentData[districtIndex].getNumOfnHoods(); nHoodIndex++)
                        {
                            for (int propertyIndex = 0; propertyIndex < currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNumOfProperties(); propertyIndex++)
                            {
                                if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice() < maxPrice)
                                {
                                    searchResultsBox.Items.Add(currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                }
                            }

                        }

                    }

                }
                else if(districtCheckBox.Checked == true && NHoodCheckBox.Checked == true)
                {
                    double maxPrice = double.Parse(maxPriceBox.Text);
                    for (int propertyIndex = 0; propertyIndex < currentData[DistrictForm.initialForm.selectedDistrict].getDistrictNHoods()[DistrictForm.initialForm.selectedNHood].getNumOfProperties(); propertyIndex++)
                    {
                        if (currentData[DistrictForm.initialForm.selectedDistrict].getDistrictNHoods()[DistrictForm.initialForm.selectedNHood].getNHoodProperties()[propertyIndex].getPrice() < maxPrice)
                        {
                            searchResultsBox.Items.Add(currentData[DistrictForm.initialForm.selectedDistrict].getDistrictNHoods()[DistrictForm.initialForm.selectedNHood].getNHoodProperties()[propertyIndex].getSummary());
                        }


                    }
                }


            }
            catch (Exception)
            {

            }


        }

        private void ExitSearchButton_Click(object sender, EventArgs e)
        {
            DistrictForm.initialForm.Show();
            currentForm.Close();
        }


    }
}
