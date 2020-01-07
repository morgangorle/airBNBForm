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
        Property[] searchData;
        int numOfItems = 0;

        public searchPropertyForm()
        {
            InitializeComponent();
            currentForm = this;
            currentData = DistrictForm.initialForm.database;
            numOfDistricts = DistrictForm.initialForm.numOfDistricts;
            selectedDistrict = DistrictForm.initialForm.selectedDistrict;
            selectedNHood = DistrictForm.initialForm.selectedNHood;
            searchData = new Property[0];
            errorLabel.Text = "";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Array.Clear(searchData, 0, numOfItems);
            numOfItems = 0;
            bool usingPrice = true;
            bool usingPropertyName = true;
            searchResultsBox.Items.Clear();
            errorLabel.Text = "";
            if (maxPriceBox.Text == "")
            {
                usingPrice = false;
            }

            if (propertyNameBox.Text == "")
            {
                usingPropertyName = false;
            }

            if (usingPrice == true || usingPropertyName == true)
            {
                try
                {
                    if (districtCheckBox.Checked != true && NHoodCheckBox.Checked != true)
                    {
                        checkAll(usingPrice, usingPropertyName, exactCheckBox.Checked);

                    }
                    else if (districtCheckBox.Checked == true && NHoodCheckBox.Checked == true)
                    {
                        checkCurrentNeighborhood(usingPrice, usingPropertyName, exactCheckBox.Checked);

                    }
                    else if (districtCheckBox.Checked == true && NHoodCheckBox.Checked == false)
                    {
                        checkCurrentDistrict(usingPrice, usingPropertyName, exactCheckBox.Checked);
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

            if (errorLabel.Text == "" && searchResultsBox.Items.Count == 0)
            {
                //Here the user is informed if a successful search occurred with no results.
                errorLabel.Text = "No properties found which fit the specifications.";
            }


        }

        private void checkAll(bool usingPrice, bool usingPropertyName, bool usingExactName)
        {
            //This function handles searches which use all districts and neighborhoods.
            double maxPrice = 0;
            if (usingPrice == true)
            {
                maxPrice = double.Parse(maxPriceBox.Text);
            }

            for (int districtIndex = 0; districtIndex < numOfDistricts; districtIndex++)
            {
                for (int nHoodIndex = 0; nHoodIndex < currentData[districtIndex].getNumOfnHoods(); nHoodIndex++)
                {
                    for (int propertyIndex = 0; propertyIndex < currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNumOfProperties(); propertyIndex++)
                    {
                        if (usingPrice == true && usingPropertyName == false)
                        {
                            if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                            {
                                searchResultsBox.Items.Add(currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                numOfItems++;
                                Array.Resize(ref searchData, numOfItems);
                                searchData[numOfItems - 1] = currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex];
                            }

                        }
                        else if (usingPropertyName == true && usingPrice == false && usingExactName == true)
                        {
                            if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName() == propertyNameBox.Text)
                            {
                                searchResultsBox.Items.Add(currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                numOfItems++;
                                Array.Resize(ref searchData, numOfItems);
                                searchData[numOfItems - 1] = currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex];
                            }
                        }
                        else if (usingPropertyName == true && usingPrice == false && usingExactName == false)
                        {
                            if (propertyNameBox.Text.Length <= currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length)
                            {
                                for (int searchIndex = 0; searchIndex <= currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length - propertyNameBox.Text.Length; searchIndex++)
                                {
                                    if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Substring(searchIndex, propertyNameBox.Text.Length).ToLower() == propertyNameBox.Text.ToLower())
                                    {
                                        searchResultsBox.Items.Add(currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                        numOfItems++;
                                        Array.Resize(ref searchData, numOfItems);
                                        searchData[numOfItems - 1] = currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex];
                                        break;
                                    }
                                }
                            }
                        }
                        else if (usingPropertyName == true && usingPrice == true && usingExactName == true)
                        {
                            if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                            {
                                if (currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName() == propertyNameBox.Text)
                                {
                                    searchResultsBox.Items.Add(currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                    numOfItems++;
                                    Array.Resize(ref searchData, numOfItems);
                                    searchData[numOfItems - 1] = currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex];
                                }

                            }
                        }
                        else if (usingPropertyName == true && usingPrice == true && usingExactName == false)
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
                                            numOfItems++;
                                            Array.Resize(ref searchData, numOfItems);
                                            searchData[numOfItems - 1] = currentData[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex];
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
        private void checkCurrentDistrict(bool usingPrice, bool usingPropertyName, bool usingExactName)
        {
            //This function handles searches which only search within the selected district.
            if (selectedDistrict == -1)
            {
                //Here I check to see if the user has actually selected a district
                errorLabel.Text = "Please select a district in the previous form";
            }
            else
            {
                double maxPrice = 0;
                if (usingPrice == true)
                {
                    maxPrice = double.Parse(maxPriceBox.Text);
                }
                for (int nHoodIndex = 0; nHoodIndex < currentData[selectedDistrict].getNumOfnHoods(); nHoodIndex++)
                {
                    for (int propertyIndex = 0; propertyIndex < currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNumOfProperties(); propertyIndex++)
                    {

                        if (usingPrice == true && usingPropertyName == false)
                        {
                            if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                            {
                                searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                numOfItems++;
                                Array.Resize(ref searchData, numOfItems);
                                searchData[numOfItems - 1] = currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex];
                            }

                        }
                        else if (usingPropertyName == true && usingPrice == false && usingExactName == true)
                        {
                            if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName() == propertyNameBox.Text)
                            {
                                searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                numOfItems++;
                                Array.Resize(ref searchData, numOfItems);
                                searchData[numOfItems - 1] = currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex];
                            }
                        }
                        else if (usingPropertyName == true && usingPrice == false && usingExactName == false)
                        {
                            if (propertyNameBox.Text.Length <= currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length)
                            {
                                for (int searchIndex = 0; searchIndex <= currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Length - propertyNameBox.Text.Length; searchIndex++)
                                {
                                    if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName().Substring(searchIndex, propertyNameBox.Text.Length).ToLower() == propertyNameBox.Text.ToLower())
                                    {
                                        searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                        numOfItems++;
                                        Array.Resize(ref searchData, numOfItems);
                                        searchData[numOfItems - 1] = currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex];
                                        break;
                                    }
                                }
                            }
                        }
                        else if (usingPropertyName == true && usingPrice == true && usingExactName == true)
                        {
                            if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                            {
                                if (currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName() == propertyNameBox.Text)
                                {
                                    searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getSummary());
                                    numOfItems++;
                                    Array.Resize(ref searchData, numOfItems);
                                    searchData[numOfItems - 1] = currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex];
                                }

                            }
                        }
                        else if (usingPropertyName == true && usingPrice == true && usingExactName == false)
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
                                            numOfItems++;
                                            Array.Resize(ref searchData, numOfItems);
                                            searchData[numOfItems - 1] = currentData[selectedDistrict].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex];
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
        private void checkCurrentNeighborhood(bool usingPrice, bool usingPropertyName, bool usingExactName)
            {
            //This function handles searches which search within the selected neighborhood.
                double maxPrice = 0;
                if (selectedDistrict == -1)
                {
                    //Here I check to see if the user has actually selected a district
                    errorLabel.Text = "Please select a district in the previous form";
                }
                else if (selectedNHood == -1)
                {
                    //Here I check to see if the user has actually selected a neighborhood
                    errorLabel.Text = "Please select a neighborhood in the previous form";
                }
                else
                {
                    if (usingPrice == true)
                    {
                        maxPrice = double.Parse(maxPriceBox.Text);

                    }
                    for (int propertyIndex = 0; propertyIndex < currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNumOfProperties(); propertyIndex++)
                    {
                        if (usingPrice == true && usingPropertyName == false)
                        {
                            if (currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPrice() <= maxPrice)
                            {
                                searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getSummary());
                                numOfItems++;
                                Array.Resize(ref searchData, numOfItems);
                                searchData[numOfItems - 1] = currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex];
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
                                            numOfItems++;
                                            Array.Resize(ref searchData, numOfItems);
                                            searchData[numOfItems - 1] = currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex];
                                            break;
                                        }
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
                                    numOfItems++;
                                    Array.Resize(ref searchData, numOfItems);
                                    searchData[numOfItems - 1] = currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex];
                                }

                            }
                        }
                        else if (usingPropertyName == true && usingPrice == false && exactCheckBox.Checked == true)
                        {
                            if (currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPropertyName() == propertyNameBox.Text)
                            {
                                searchResultsBox.Items.Add(currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getSummary());
                                numOfItems++;
                                Array.Resize(ref searchData, numOfItems);
                                searchData[numOfItems - 1] = currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex];
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
                                        numOfItems++;
                                        Array.Resize(ref searchData, numOfItems);
                                        searchData[numOfItems - 1] = currentData[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex];
                                        break;
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

        private void SearchResultsBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                //The data of the property clicked on is displayed to the user.
                try
                {
                    displayPropertyNameBox.Text = searchData[searchResultsBox.SelectedIndex].getPropertyName();
                    propertyIDBox.Text = searchData[searchResultsBox.SelectedIndex].getPropertyID();
                //String.format is used to convert integers and doubles into strings.
                    priceBox.Text = string.Format("{0}", searchData[searchResultsBox.SelectedIndex].getPrice());
                    latitudeBox.Text = string.Format("{0}", searchData[searchResultsBox.SelectedIndex].getLatitude());
                    longitudeBox.Text = string.Format("{0}", searchData[searchResultsBox.SelectedIndex].getLongitude());
                    hostIDBox.Text = searchData[searchResultsBox.SelectedIndex].getHostID();
                    hostNameBox.Text = searchData[searchResultsBox.SelectedIndex].getHostName();
                    numOfPropertiesBox.Text = string.Format("{0}", searchData[searchResultsBox.SelectedIndex].getNumOfProperties());
                    minNumOfNightsBox.Text = string.Format("{0}", searchData[searchResultsBox.SelectedIndex].getMinNumOfNights());
                    roomTypeBox.Text = searchData[searchResultsBox.SelectedIndex].getRoomType();
                    availiabilityBox.Text = string.Format("{0}", searchData[searchResultsBox.SelectedIndex].getAvailiableDays());

                }
                catch (Exception)
                {

                }

            }

        private void SearchPropertyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //This ensures that the main form is opened when the user presses X on this form rather than the program running in the background.
            DistrictForm.initialForm.Show();
        }
    }
    }
