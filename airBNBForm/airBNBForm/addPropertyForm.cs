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
    public partial class addPropertyForm : Form
    {
        addPropertyForm currentForm;
        int districtIndex = 0;
        int neighborhoodIndex = 0;
        public addPropertyForm()
        {
            InitializeComponent();
            currentForm = this;
            errorLabel.Text = "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            currentForm.Close();
            DistrictForm.initialForm.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {


            Property newProperty;
            Boolean propertyCreated = false;
            try
            {
                newProperty = new Property(propertyIDBox.Text, propertyNameBox.Text, hostIDBox.Text, hostNameBox.Text, roomTypeBox.Text, double.Parse(latitudeBox.Text), double.Parse(longitudeBox.Text), double.Parse(priceBox.Text), int.Parse(numOfPropertiesBox.Text), int.Parse(minNumNightsBox.Text), int.Parse(availiabilityBox.Text));
                propertyCreated = true;
            }
            catch (Exception)
            {
                errorLabel.Text = "Property not created, please try again. ";
                newProperty = new Property("345", "345", "345", "345", "345", 345, 345, 345, 345, 345, 345);
            }
            
            if (searchDistrict(districtNameBox.Text) == true && propertyCreated == true)
            {
                if (searchNeighborhood(nHoodNameBox.Text))
                {
                    Neighborhood[] tempNhoods;
                    tempNhoods = DistrictForm.initialForm.database[districtIndex].getDistrictNHoods();
                    tempNhoods[neighborhoodIndex].addProperty(newProperty);
                    DistrictForm.initialForm.database[districtIndex].setDistrictNHoods(tempNhoods);
                    currentForm.Close();
                    DistrictForm.initialForm.Show();
                }
                else
                {
                    errorLabel.Text = "Neighborhood not found";
                }
            }
            else if (propertyCreated == true)
            {
                errorLabel.Text = "District not found";
            }
        }
        private Boolean searchDistrict(string inputDistrict)
        {
            Boolean districtFound = false;
            int searchIndex = 0;
            while (districtFound == false && searchIndex < DistrictForm.initialForm.database.Length)
            {

                if (DistrictForm.initialForm.database[searchIndex].getDistrictName() == inputDistrict)
                {
                    districtIndex = searchIndex;
                    return true;
                }
                searchIndex++;

            }
            return false;
        }
        private Boolean searchNeighborhood(string inputNeighborhood)
        {
            Boolean nHoodFound = false;
            int searchIndex = 0;
            Neighborhood[] districtNeighborhoods;
            districtNeighborhoods = DistrictForm.initialForm.database[districtIndex].getDistrictNHoods();
            while (nHoodFound == false && searchIndex < districtNeighborhoods.Length)
            {
                if (districtNeighborhoods[searchIndex].getnHoodName() == inputNeighborhood)
                {
                    neighborhoodIndex = searchIndex;
                    return true;
                }
                searchIndex++;

            }
            return false;
        }
    }
}
