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
        int selectedDistrict;
        int selectedNHood;

        public searchPropertyForm()
        {
            InitializeComponent();
            currentForm = this;
            currentData = DistrictForm.initialForm.database;
            numOfDistricts = DistrictForm.initialForm.numOfDistricts;
            selectedDistrict = DistrictForm.initialForm.selectedDistrict;
            selectedNHood = DistrictForm.initialForm.selectedNHood;

            errorLabel.Text = "";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            double maxPrice = 0;
            bool usingPrice = true;
            bool usingPropertyName = true;
            searchResultsBox.Items.Clear();
            errorLabel.Text = "";
            if(maxPriceBox.Text == "")
            {
                usingPrice = false;
            }

            if(propertyNameBox.Text == "")
            {
                usingPropertyName = false;
            }

            if(usingPrice == true || usingPropertyName == true)
            {
                try
                {
                    if (districtCheckBox.Checked != true && NHoodCheckBox.Checked != true)
                    {
                        if(usingPrice == true)
                        {
                            maxPrice = double.Parse(maxPriceBox.Text);
                        }

                        for (int districtIndex = 0; districtIndex < numOfDistricts; districtIndex++)
                        {
                            for (int nHoodIndex = 0; nHoodIndex < currentData[districtIndex].getNumOfnHoods(); nHoodIndex++)
                            {
                                for (int propertyIndex = 0; propertyIndex < currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNumOfProperties(); propertyIndex++)
                                {
                                    if(usingPrice == true && usingPropertyName == false)
                                    {
                                        if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                                        {
                                            searchResultsBox.Items.Add(currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                        }

                                    }
                                    else if(usingPropertyName == true && usingPrice == false && exactCheckBox.Checked == true)
                                    {
                                        if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName() == propertyNameBox.Text)
                                        {
                                            searchResultsBox.Items.Add(currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                        }
                                    }
                                    else if(usingPropertyName == true && usingPrice == false && exactCheckBox.Checked == false)
                                    {
                                        if(propertyNameBox.Text.Length <= currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length)
                                        {
                                            for (int searchIndex = 0; searchIndex <= currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length-propertyNameBox.Text.Length; searchIndex++)
                                            {
                                                if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Substring(searchIndex,propertyNameBox.Text.Length).ToLower() == propertyNameBox.Text.ToLower())
                                                {
                                                    searchResultsBox.Items.Add(currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    else if(usingPropertyName == true && usingPrice == true && exactCheckBox.Checked == true)
                                    {
                                        if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                                        {
                                            if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName() == propertyNameBox.Text)
                                            {
                                                searchResultsBox.Items.Add(currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                            }

                                        }
                                    }
                                    else if(usingPropertyName == true && usingPrice == true && exactCheckBox.Checked == false)
                                    {
                                        if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                                        {
                                            if (propertyNameBox.Text.Length <= currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length)
                                            {
                                                for (int searchIndex = 0; searchIndex <= currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length - propertyNameBox.Text.Length; searchIndex++)
                                                {
                                                    if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Substring(searchIndex, propertyNameBox.Text.Length).ToLower() == propertyNameBox.Text.ToLower())
                                                    {
                                                        searchResultsBox.Items.Add(currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                                        break;
                                                    }
                                                }
                                            }

                                        }

                                    }
                                    else
                                    {
                                        errorLabel.Text = "Search option not coded, contact Programmer.";
                                    }

                                }


                            }

                        }

                    }
                    else if (districtCheckBox.Checked == true && NHoodCheckBox.Checked == true)
                    {
                        //Here I check to see if the user has actually selected a district
                        if (selectedDistrict == -1)
                        {
                            errorLabel.Text = "Please select a district in the previous form";
                        }
                        //Here I check to see if the user has actually selected a neighborhood
                        else if (selectedNHood == -1)
                        {
                            errorLabel.Text = "Please select a neighborhood in the previous form";
                        }
                        else
                        {
                            if(usingPrice == true)
                            {
                                maxPrice = double.Parse(maxPriceBox.Text);

                            }

                            for (int propertyIndex = 0; propertyIndex < currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNumOfProperties(); propertyIndex++)
                            {
                                if(usingPrice == true && usingPropertyName == false)
                                {
                                    if (currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                                    {
                                        searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getSummary());
                                    }

                                }
                                else if (usingPropertyName == true && usingPrice == false && exactCheckBox.Checked == true)
                                {
                                    if (currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPropertyName() == propertyNameBox.Text)
                                    {
                                        searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getSummary());
                                    }
                                }
                                else if (usingPropertyName == true && usingPrice == false && exactCheckBox.Checked == false)
                                {
                                    if (propertyNameBox.Text.Length <= currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPropertyName().Length)
                                    {
                                        for (int searchIndex = 0; searchIndex <= currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPropertyName().Length - propertyNameBox.Text.Length; searchIndex++)
                                        {
                                            if (currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPropertyName().Substring(searchIndex, propertyNameBox.Text.Length).ToLower() == propertyNameBox.Text.ToLower())
                                            {
                                                searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getSummary());
                                                break;
                                            }
                                        }
                                    }
                                }
                                else if (usingPropertyName == true && usingPrice == true && exactCheckBox.Checked == true)
                                {
                                    if (currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                                    {
                                        if (currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPropertyName() == propertyNameBox.Text)
                                        {
                                            searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getSummary());
                                        }

                                    }
                                }
                                else if (usingPropertyName == true && usingPrice == true && exactCheckBox.Checked == false)
                                {
                                    if (currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                                    {
                                        if (propertyNameBox.Text.Length <= currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPropertyName().Length)
                                        {
                                            for (int searchIndex = 0; searchIndex <= currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPropertyName().Length - propertyNameBox.Text.Length; searchIndex++)
                                            {
                                                if (currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPropertyName().Substring(searchIndex, propertyNameBox.Text.Length).ToLower() == propertyNameBox.Text.ToLower())
                                                {
                                                    searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getSummary());
                                                    break;
                                                }
                                            }
                                        }

                                    }

                                }
                                else
                                {
                                    errorLabel.Text = "Search option not coded, contact Programmer.";
                                }



                            }

                        }

                    }
                    else if (districtCheckBox.Checked == true && NHoodCheckBox.Checked == false)
                    {
                        if (usingPrice == true)
                        {
                            maxPrice = double.Parse(maxPriceBox.Text);
                        }

                        for (int nHoodIndex = 0; nHoodIndex < currentData[selectedDistrict].getNumOfnHoods(); nHoodIndex++)
                        {
                            for (int propertyIndex = 0; propertyIndex < currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNumOfProperties(); propertyIndex++)
                            {
                                if(usingPrice == true && usingPropertyName == false)
                                {
                                    if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                                    {
                                        searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                    }

                                }
                                else if (usingPropertyName == true && usingPrice == false && exactCheckBox.Checked == true)
                                {
                                    if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName() == propertyNameBox.Text)
                                    {
                                        searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                    }
                                }
                                else if (usingPropertyName == true && usingPrice == false && exactCheckBox.Checked == false)
                                {
                                    if (propertyNameBox.Text.Length <= currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length)
                                    {
                                        for (int searchIndex = 0; searchIndex <= currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length - propertyNameBox.Text.Length; searchIndex++)
                                        {
                                            if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Substring(searchIndex, propertyNameBox.Text.Length).ToLower() == propertyNameBox.Text.ToLower())
                                            {
                                                searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                                break;
                                            }
                                        }
                                    }
                                }
                                else if (usingPropertyName == true && usingPrice == true && exactCheckBox.Checked == true)
                                {
                                    if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                                    {
                                        if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName() == propertyNameBox.Text)
                                        {
                                            searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                        }

                                    }
                                }
                                else if (usingPropertyName == true && usingPrice == true && exactCheckBox.Checked == false)
                                {
                                    if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                                    {
                                        if (propertyNameBox.Text.Length <= currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length)
                                        {
                                            for (int searchIndex = 0; searchIndex <= currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length - propertyNameBox.Text.Length; searchIndex++)
                                            {
                                                if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Substring(searchIndex, propertyNameBox.Text.Length).ToLower() == propertyNameBox.Text.ToLower())
                                                {
                                                    searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                                    break;
                                                }
                                            }
                                        }

                                    }

                                }
                                else
                                {
                                    errorLabel.Text = "Search option not coded, contact Programmer.";
                                }

                            }
                        }
                    }


                }
                catch (Exception)
                {
                    errorLabel.Text = "An error occurred";
                }

            }
            else
            {
                errorLabel.Text = "Please enter search criteria";
            }

            if(errorLabel.Text == "" && searchResultsBox.Items.Count == 0)
            {
                errorLabel.Text = "No properties found which fit the specifications.";
            }


        }

        private void ExitSearchButton_Click(object sender, EventArgs e)
        {
            DistrictForm.initialForm.Show();
            currentForm.Close();
        }

        private void DistrictCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Here I prevent the ambiguous case where a user can uncheck district but check Neighborhood
            if (districtCheckBox.Checked == false && NHoodCheckBox.Checked == true)
            {
                NHoodCheckBox.Checked = false;
                errorLabel.Text = "You can't search a specific neighborhood without ticking the district.";
            }
            else
            {
                errorLabel.Text = "";
            }

        }

        private void NHoodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Here I prevent the ambiguous case where a user can uncheck district but check Neighborhood
            if (districtCheckBox.Checked == false && NHoodCheckBox.Checked == true)
            {
                NHoodCheckBox.Checked = false;
                errorLabel.Text = "You can't search a specific neighborhood without ticking the district.";
            }
            else
            {
                errorLabel.Text = "";
            }
        }


    }
}
