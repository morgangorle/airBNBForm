using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace airBNBForm
{
    public partial class DistrictForm : Form
    {
        //These variables will store the data before it is output
        public District[] database;
        public int numOfDistricts = 0;
        //This is to ensure I can go back to my initial form after going to another form.
        public static DistrictForm initialForm;
        public int selectedDistrict = -1, selectedNHood = -1, selectedProperty = -1;
        //These are for the forms
        //addPropertyForm addPropertyFormInstance;
        searchPropertyForm searchPropertyFormInstance;


        public DistrictForm()
        {
            InitializeComponent();
            database = new District[numOfDistricts];
            initialForm = this;
            displayDistricts();
            displayNHoods();
            displayProperties();
            propertyErrorLabel.Text = "";
            nHoodErrorLabel.Text = "";
            districtErrorLabel.Text = "";
            editDistrictNameButton.Enabled = false;
            deleteDistrict.Enabled = false;
            readFile();


        }

        private void DistrictOutputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Here I change the selected district number to the one the user clicks on.
            selectedDistrict = districtOutputBox.SelectedIndex;
            //I also set the selected neighborhood and property values to -1
            // and call the display methods for them to reset them.
            //This is to remove the previous set of neighborhoods and properties
            //And add a new set of neighborhoods.
            selectedNHood = -1;
            selectedProperty = -1;
            displayNHoods();
            displayProperties();
            //I also put the current district name into the text box for easy editing.
            if(selectedDistrict != -1)
            {
                districtBox.Text = database[selectedDistrict].getDistrictName();
                editDistrictNameButton.Enabled = true;
                deleteDistrict.Enabled = true;

            }
            else
            {
                districtBox.Text = "";
                editDistrictNameButton.Enabled = false;
                deleteDistrict.Enabled = false;
            }


        }
        private void NHoodOutputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Here I change the selected Neighborhood number to the one the user clicks on
            selectedNHood = nHoodOutputBox.SelectedIndex;
            //I also set the selected property value to -1
            //then call the display properties function
            selectedProperty = -1;
            displayProperties();
            //I also put the current neighborhood name into the neighborhood name textbox for easy editing.
            if(selectedNHood != -1)
            {
                nHoodBox.Text = database[selectedDistrict].getDistrictNHoods()[selectedNHood].getnHoodName();
                editNHoodNameButton.Enabled = true;
                deleteNHoodButton.Enabled = true;
            }
            else
            {
                nHoodBox.Text = "";
                editNHoodNameButton.Enabled = false;
                deleteNHoodButton.Enabled = false;

            }

        }

        private void PropertyOutputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Here I change the selected property number to the one the user clicks on
            selectedProperty = propertyOutputBox.SelectedIndex;
            if(selectedProperty != -1)
            {
                //I also output all the details of the property to the text boxes for both display and editing.
                propertyIDBox.Text = database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].getPropertyID();
                propertyNameBox.Text = database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].getPropertyName();
                hostIDBox.Text = database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].getHostID();
                hostNameBox.Text = database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].getHostName();
                roomTypeBox.Text = database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].getRoomType();
                //String.format is used to convert integers and doubles into strings.
                latitudeBox.Text = string.Format("{0}", database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].getLatitude());
                longitudeBox.Text = string.Format("{0}", database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].getLongitude());
                priceBox.Text = string.Format("{0}", database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].getPrice());
                numOfPropertiesBox.Text = string.Format("{0}", database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].getNumOfProperties());
                minNumOfNightsBox.Text = string.Format("{0}", database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].getMinNumOfNights());
                availiabilityBox.Text = string.Format("{0}", database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].getAvailiableDays());
            }


        }

        private void EditDistrictNameButton_Click(object sender, EventArgs e)
        {
            if(selectedDistrict != -1)
            {
                database[selectedDistrict].setDistrictName(districtBox.Text);
                updateData();
                displayDistricts();
            }


        }

        private void EditNHoodNameButton_Click(object sender, EventArgs e)
        {
            if (selectedNHood != -1)
            {
                database[selectedDistrict].getDistrictNHoods()[selectedNHood].setnHoodName(nHoodBox.Text);
                updateData();
                displayNHoods();

            }


        }
        private void EditPropertyButton_Click(object sender, EventArgs e)
        {
            propertyErrorLabel.Text = "";
            if (selectedProperty != -1)
            {
                try
                {
                    //All the property values are set to that of the one in the text box
                    database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].setPropertyID(propertyIDBox.Text);
                    database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].setPropertyName(propertyNameBox.Text);
                    database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].setRoomType(roomTypeBox.Text);
                    database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].setHostID(hostIDBox.Text);
                    database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].setHostName(hostNameBox.Text);
                    database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].setLatitude(double.Parse(latitudeBox.Text));
                    database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].setLongitude(double.Parse(longitudeBox.Text));
                    database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].setAvailiableDays(int.Parse(availiabilityBox.Text));
                    database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].setMinNumOfNights(int.Parse(minNumOfNightsBox.Text));
                    database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].setPrice(double.Parse(priceBox.Text));
                    database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[selectedProperty].setNumOfProperties(int.Parse(numOfPropertiesBox.Text));
                    //Then the data in the text file is updated
                    updateData();
                    //And the updated data is displayed.
                    displayProperties();

                }
                catch (Exception)
                {

                    propertyErrorLabel.Text = "An error occurred";
                }


            }
            else
            {
                propertyErrorLabel.Text = "Please select a property";
            }



        }

        private void DeleteDistrict_Click(object sender, EventArgs e)
        {

            if (selectedDistrict != -1)
            {
                District[] tempDatabase = new District[numOfDistricts - 1];
                int newArrayPointer = 0;
                for (int districtIndex = 0; districtIndex < numOfDistricts; districtIndex++)
                {
                    if (districtIndex != selectedDistrict)
                    {
                        tempDatabase[newArrayPointer] = database[districtIndex];
                        newArrayPointer++;
                    }

                }
                numOfDistricts -= 1;
                database = tempDatabase;
                updateData();
                selectedDistrict = -1;
                selectedNHood = -1;
                selectedProperty = -1;
                displayDistricts();
                displayNHoods();
                displayProperties();
                districtBox.Text = "";

            }


        }

        private void DeleteNHoodButton_Click(object sender, EventArgs e)
        {

            if (selectedNHood != -1)
            {
                Neighborhood[] tempNeighborhoods = new Neighborhood[database[selectedDistrict].getNumOfnHoods() - 1];
                int newArrayPointer = 0;
                for (int nHoodIndex = 0; nHoodIndex < database[selectedDistrict].getNumOfnHoods(); nHoodIndex++)
                {
                    if (nHoodIndex != selectedNHood)
                    {
                        tempNeighborhoods[newArrayPointer] = database[selectedDistrict].getDistrictNHoods()[nHoodIndex];
                        newArrayPointer++;
                    }

                }
                database[selectedDistrict].setDistrictNHoods(tempNeighborhoods);
                database[selectedDistrict].setNumOfnHoods(database[selectedDistrict].getNumOfnHoods() - 1);
                selectedNHood = -1;
                selectedProperty = -1;
                displayNHoods();
                displayProperties();
                updateData();
                nHoodBox.Text = "";

            }


        }

        private void DeletePropertyButton_Click(object sender, EventArgs e)
        {
            propertyErrorLabel.Text = "";
            if (selectedProperty != -1)
            {
                Property[] tempProperties = new Property[database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNumOfProperties() - 1];
                int newArrayPointer = 0;
                for (int propertyIndex = 0; propertyIndex < database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNumOfProperties(); propertyIndex++)
                {
                    if(propertyIndex != selectedProperty)
                    {
                        tempProperties[newArrayPointer] = database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex];
                        newArrayPointer++;
                    }

                }
                database[selectedDistrict].getDistrictNHoods()[selectedNHood].setNHoodProperties(tempProperties);
                database[selectedDistrict].getDistrictNHoods()[selectedNHood].setNumOfProperties(database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNumOfProperties() - 1);
                selectedProperty = -1;
                //displayProperties is called to ensure that the changes are shown to the user
                displayProperties();
                //updateData is called to ensure that the changes are in the text file.
                updateData();

            }
            else
            {
                propertyErrorLabel.Text = "Please select a property to delete";
            }

        }



        public void updateData()
        {
            //This method writes any changes to the text file.
            StreamWriter fileWriter;
            fileWriter = new StreamWriter("maxiAirBnB.txt");
            for (int districtIndex = 0; districtIndex < numOfDistricts; districtIndex++)
            {
                fileWriter.WriteLine(database[districtIndex].getDistrictName());
                fileWriter.WriteLine(string.Format("{0}",database[districtIndex].getNumOfnHoods()));
                for (int nHoodIndex = 0; nHoodIndex < database[districtIndex].getNumOfnHoods(); nHoodIndex++)
                {
                    fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getnHoodName());
                    fileWriter.WriteLine(string.Format("{0}", database[districtIndex].getDistrictNHoods()[nHoodIndex].getNumOfProperties()));

                    for (int propertyIndex = 0; propertyIndex < database[districtIndex].getDistrictNHoods()[nHoodIndex].getNumOfProperties(); propertyIndex++)
                    {
                        fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyID());
                        fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPropertyName());
                        fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getHostID());
                        fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getHostName());
                        fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getNumOfProperties());
                        fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getLatitude());
                        fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getLongitude());
                        fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getRoomType());
                        fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getPrice());
                        fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getMinNumOfNights());
                        fileWriter.WriteLine(database[districtIndex].getDistrictNHoods()[nHoodIndex].getNHoodProperties()[propertyIndex].getAvailiableDays());
                    }

                }


            }
            fileWriter.Close();
        }
        private void readFile()
        {
            //This function reads in the file.
            StreamReader fileReader = new StreamReader("maxiAirBnB.txt");
            string districtName, neighborhoodName;
            string propertyID, propertyName, hostID, hostName, roomType;
            int numProperties, minNumOfNights, Availiability;
            double price, latitude, longitude;
            District newDistrict;
            Neighborhood newNeighborhood;
            Property newProperty;
            int numOfNeighborhoods, numOfProperties;
            while (fileReader.EndOfStream == false)
            {
                districtName = fileReader.ReadLine();
                newDistrict = new District(districtName);
                numOfNeighborhoods = int.Parse(fileReader.ReadLine());
                for (int NHoodIndex = 0; NHoodIndex < numOfNeighborhoods; NHoodIndex++)
                {
                    neighborhoodName = fileReader.ReadLine();
                    numOfProperties = int.Parse(fileReader.ReadLine());
                    newNeighborhood = new Neighborhood(neighborhoodName);
                    for (int propertyIndex = 0; propertyIndex < numOfProperties; propertyIndex++)
                    {
                        propertyID = fileReader.ReadLine();
                        propertyName = fileReader.ReadLine();
                        hostID = fileReader.ReadLine();
                        hostName = fileReader.ReadLine();
                        numProperties = int.Parse(fileReader.ReadLine());
                        latitude = double.Parse(fileReader.ReadLine());
                        longitude = double.Parse(fileReader.ReadLine());
                        roomType = fileReader.ReadLine();
                        price = double.Parse(fileReader.ReadLine());
                        minNumOfNights = int.Parse(fileReader.ReadLine());
                        Availiability = int.Parse(fileReader.ReadLine());
                        newProperty = new Property(propertyID, propertyName, hostID, hostName, roomType, latitude, longitude, price, numProperties, minNumOfNights, Availiability);
                        newNeighborhood.addProperty(newProperty);


                    }
                    newDistrict.addNHood(newNeighborhood);

                }
                numOfDistricts++;
                Array.Resize(ref database, numOfDistricts);
                database[numOfDistricts - 1] = newDistrict;

            }
            displayDistricts();
            displayNHoods();
            displayProperties();
            fileReader.Close();

        }


        //private void createSampleData()
        //{
        //    //These variables will store the sample data
        //    Property sample1, sample2, sample3, sample4, sample5, sample6, sample7, sample8, sample9, sample10;
        //    District District1, District2;
        //    Neighborhood NHood1, NHood2, NHood3;
        //    //Sample data
        //    sample1 = new Property("1", "House1", "A Name", "Name1", "Single", 1, 1, 1, 1, 1, 1);
        //    sample2 = new Property("2", "House2", "A Name", "Name2", "Single", 2, 2, 2, 2, 2, 2);
        //    sample3 = new Property("3", "House3", "A Name", "Name3", "Single", 3, 3, 3, 3, 3, 3);
        //    sample4 = new Property("4", "House4", "A Name", "Name4", "Single", 4, 4, 4, 4, 4, 4);
        //    sample5 = new Property("5", "House5", "A Name", "Name5", "Single", 5, 5, 5, 5, 5, 5);
        //    sample6 = new Property("6", "House6", "A Name", "Name6", "Single", 6, 6, 6, 6, 6, 6);
        //    sample7 = new Property("7", "House7", "A Name", "Name7", "Single", 7, 7, 7, 7, 7, 7);
        //    sample8 = new Property("8", "House8", "A Name", "Name8", "Single", 8, 8, 8, 8, 8, 8);
        //    sample9 = new Property("9", "House9", "A Name", "Name9", "Single", 9, 9, 9, 9, 9, 9);
        //    sample10 = new Property("10", "House10", "A Name", "Name10", "Single", 10, 10, 10, 10, 10, 10);
        //    NHood1 = new Neighborhood("Ringview");
        //    NHood2 = new Neighborhood("viewRing");
        //    NHood3 = new Neighborhood("Verona");
        //    District1 = new District("Samp1");
        //    District2 = new District("Samp2");
        //    NHood1.addProperty(sample1);
        //    NHood1.addProperty(sample2);
        //    NHood1.addProperty(sample3);
        //    NHood1.addProperty(sample4);
        //    NHood2.addProperty(sample5);
        //    NHood2.addProperty(sample6);
        //    NHood2.addProperty(sample7);
        //    NHood3.addProperty(sample8);
        //    NHood3.addProperty(sample9);
        //    NHood3.addProperty(sample10);
        //    District1.addNHood(NHood1);
        //    District1.addNHood(NHood2);
        //    District2.addNHood(NHood3);
        //    //Hardcoded for now
        //    database[0] = District1;
        //    database[1] = District2;

        //}


        private void DistrictForm_Load(object sender, EventArgs e)
        {

        }

        private void displayDistricts()
        {
            //This function displays the current Districts
            districtOutputBox.Items.Clear();
            if (numOfDistricts != 0)
            {
                for (int districtIndex = 0; districtIndex < numOfDistricts; districtIndex++)
                {
                    districtOutputBox.Items.Add(database[districtIndex].getDistrictName());
                }
            }
        }
        private void displayNHoods()
        {
            //This function displays the neighborhoods in the current District
            //Nothing is shown if no district is selected
            nHoodOutputBox.Items.Clear();
            if(numOfDistricts != 0 && selectedDistrict != -1)
            {
                for (int nHoodIndex = 0; nHoodIndex < database[selectedDistrict].getNumOfnHoods(); nHoodIndex++)
                {
                    nHoodOutputBox.Items.Add(database[selectedDistrict].getDistrictNHoods()[nHoodIndex].getnHoodName());


                }


            }
            if(selectedNHood == -1)
            {
                nHoodBox.Text = "";
                editNHoodNameButton.Enabled = false;
                deleteNHoodButton.Enabled = false;
            }

        }
        private void displayProperties()
        {
            //This function displays the properties in the current Neighborhood
            //Nothing is shown if no neighborhood is selected
            propertyOutputBox.Items.Clear();
            if(numOfDistricts != 0 && selectedNHood != -1)
            {
                for (int propertyIndex = 0; propertyIndex < database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNumOfProperties(); propertyIndex++)
                {
                    propertyOutputBox.Items.Add(database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getSummary());

                }

            }


        }


        private void AddDistrictButton_Click(object sender, EventArgs e)
        {
            districtErrorLabel.Text = "";
            //If the text box is empty no district is added.
            if (districtBox.Text != "")
            {
                bool identicalFound = false;
                for (int districtIndex = 0; districtIndex < numOfDistricts; districtIndex++)
                {
                    if(database[districtIndex].getDistrictName() == districtBox.Text)
                    {
                        identicalFound = true;
                    }
                }

                if(identicalFound == false)
                {
                    District tempDistrict = new District(districtBox.Text);
                    numOfDistricts++;
                    Array.Resize(ref database, numOfDistricts);
                    database[numOfDistricts - 1] = tempDistrict;
                    districtBox.Text = "";
                    displayDistricts();
                    updateData();

                }
                else
                {
                    //The user is informed that they can't add multiple districts with the same name
                    districtErrorLabel.Text = "Can't add a duplicate district";
                }

            }
            else
            {
                //The user is informed that they need to enter something for a district to be added
                districtErrorLabel.Text = "Can't add a blank district";
            }

            //addDistrictFormInstance = new addDistrictForm();
            //addDistrictFormInstance.Show();
            //initialForm.Hide();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Here I create a new instance of the search form
            searchPropertyFormInstance = new searchPropertyForm();
            //Then show it
            searchPropertyFormInstance.Show();
            //and hide the current form
            initialForm.Hide();
        }


        private void AddNHoodButton_Click(object sender, EventArgs e)
        {
            //Here I have a check to prevent the user from creating blank neighborhoods
            if(nHoodBox.Text != "")
            {
                Neighborhood tempNeighborhood = new Neighborhood(nHoodBox.Text);
                Neighborhood[] tempNeighborhoodArray;
                database[selectedDistrict].setNumOfnHoods(database[selectedDistrict].getNumOfnHoods() + 1);
                tempNeighborhoodArray = database[selectedDistrict].getDistrictNHoods();
                Array.Resize(ref tempNeighborhoodArray, database[selectedDistrict].getNumOfnHoods());
                tempNeighborhoodArray[database[selectedDistrict].getNumOfnHoods() - 1] = tempNeighborhood;
                database[selectedDistrict].setDistrictNHoods(tempNeighborhoodArray);
                nHoodBox.Text = "";
                displayNHoods();
                updateData();

            }
            //addNeighborhoodFormInstance = new addNeighborhoodForm();
            //addNeighborhoodFormInstance.Show();
            //initialForm.Hide();

        }
        private void AddPropertyButton_Click(object sender, EventArgs e)
        {
            //Errorlabel is set to blank
            propertyErrorLabel.Text = "";
            try
            {
                Property tempProperty = new Property(propertyIDBox.Text, propertyNameBox.Text, hostIDBox.Text, hostNameBox.Text, roomTypeBox.Text, double.Parse(latitudeBox.Text), double.Parse(longitudeBox.Text), double.Parse(priceBox.Text), int.Parse(numOfPropertiesBox.Text), int.Parse(minNumOfNightsBox.Text), int.Parse(availiabilityBox.Text));
                database[selectedDistrict].getDistrictNHoods()[selectedNHood].addProperty(tempProperty);
                updateData();
                displayProperties();

            }
            catch (Exception)
            {
                //If an error occurs the user is informed.
                //Currently there is no specific error message.
                propertyErrorLabel.Text = "An error occurred";
            }

            //addPropertyFormInstance = new addPropertyForm();
            //addPropertyFormInstance.Show();
            //initialForm.Hide();

        }


    }
}
