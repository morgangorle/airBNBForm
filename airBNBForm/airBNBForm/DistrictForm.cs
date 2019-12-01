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
        //Neighborhood[] storedNeighborhoods;
        //Property[] storedProperties;
        //int currentDistrict = 0;
        public int numOfDistricts = 2;
        //This is to ensure I can go back to my initial form
        public static DistrictForm initialForm;
        public int selectedDistrict = -1, selectedNHood = -1, selectedProperty = -1;
        //These are for the forms
        addDistrictForm addDistrictFormInstance;
        editDistrictForm editDistrictFormInstance;
        addPropertyForm addPropertyFormInstance;
        addNeighborhoodForm addNeighborhoodFormInstance;
        //These variables will create the sample data
        Property sample1, sample2, sample3, sample4, sample5, sample6, sample7, sample8, sample9, sample10;
        District District1, District2;
        Neighborhood NHood1, NHood2, NHood3;

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            displayDistricts();
            displayNHoods();
            displayProperties();

        }

        private void DistrictOutputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDistrict = districtOutputBox.SelectedIndex;
            selectedNHood = -1;
            selectedProperty = -1;
            displayNHoods();
            displayProperties();
            districtBox.Text = database[selectedDistrict].getDistrictName();

        }

        private void EditDistrictNameButton_Click(object sender, EventArgs e)
        {
            database[selectedDistrict].setDistrictName(districtBox.Text);
            updateData();
            displayDistricts();

        }

        private void DeleteDistrict_Click(object sender, EventArgs e)
        {
            District[] tempDatabase = new District[numOfDistricts-1];
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



        private void NHoodOutputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNHood = nHoodOutputBox.SelectedIndex;
            selectedProperty = -1;
            displayProperties();
            nHoodBox.Text = database[selectedDistrict].getDistrictNHoods()[selectedNHood].getnHoodName();

        }

        private void DeleteNHoodButton_Click(object sender, EventArgs e)
        {
            updateData();
            displayNHoods();

        }

        private void EditNHoodNameButton_Click(object sender, EventArgs e)
        {
            database[selectedDistrict].getDistrictNHoods()[selectedNHood].setnHoodName(nHoodBox.Text);
            updateData();
            displayNHoods();

        }

        private void PropertyOutputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProperty = propertyOutputBox.SelectedIndex;

        }
        public void updateData()
        {
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



        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            StreamReader fileReader;
            fileReader = new StreamReader("maxiAirBnB.txt");
            string districtName,neighborhoodName;
            string propertyID, propertyName,hostID,hostName,roomType;
            int numProperties , minNumOfNights, Availiability;
            double price, latitude,longitude;
            District newDistrict;
            Neighborhood newNeighborhood;
            Property newProperty;
            int numOfNeighborhoods,numOfProperties;
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
                        numProperties = int.Parse( fileReader.ReadLine());
                        latitude = double.Parse(fileReader.ReadLine());
                        longitude = double.Parse(fileReader.ReadLine());
                        roomType = fileReader.ReadLine();
                        price = double.Parse(fileReader.ReadLine());
                        minNumOfNights = int.Parse(fileReader.ReadLine());
                        Availiability = int.Parse(fileReader.ReadLine());
                        newProperty = new Property(propertyID, propertyName, hostID, hostName, roomType, latitude, longitude, price, numProperties, minNumOfNights,Availiability);
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


        public DistrictForm()
        {
            InitializeComponent();
            database = new District[2];
            initialForm = this;

            createSampleData();
            displayDistricts();
            displayNHoods();
            displayProperties();


        }
        private void createSampleData()
        {
            //Sample data
            sample1 = new Property("1", "House1", "A Name", "Name1", "Single", 1, 1, 1, 1, 1, 1);
            sample2 = new Property("2", "House2", "A Name", "Name2", "Single", 2, 2, 2, 2, 2, 2);
            sample3 = new Property("3", "House3", "A Name", "Name3", "Single", 3, 3, 3, 3, 3, 3);
            sample4 = new Property("4", "House4", "A Name", "Name4", "Single", 4, 4, 4, 4, 4, 4);
            sample5 = new Property("5", "House5", "A Name", "Name5", "Single", 5, 5, 5, 5, 5, 5);
            sample6 = new Property("6", "House6", "A Name", "Name6", "Single", 6, 6, 6, 6, 6, 6);
            sample7 = new Property("7", "House7", "A Name", "Name7", "Single", 7, 7, 7, 7, 7, 7);
            sample8 = new Property("8", "House8", "A Name", "Name8", "Single", 8, 8, 8, 8, 8, 8);
            sample9 = new Property("9", "House9", "A Name", "Name9", "Single", 9, 9, 9, 9, 9, 9);
            sample10 = new Property("10", "House10", "A Name", "Name10", "Single", 10, 10, 10, 10, 10, 10);
            NHood1 = new Neighborhood("Ringview");
            NHood2 = new Neighborhood("viewRing");
            NHood3 = new Neighborhood("Verona");
            District1 = new District("Samp1");
            District2 = new District("Samp2");
            NHood1.addProperty(sample1);
            NHood1.addProperty(sample2);
            NHood1.addProperty(sample3);
            NHood1.addProperty(sample4);
            NHood2.addProperty(sample5);
            NHood2.addProperty(sample6);
            NHood2.addProperty(sample7);
            NHood3.addProperty(sample8);
            NHood3.addProperty(sample9);
            NHood3.addProperty(sample10);
            District1.addNHood(NHood1);
            District1.addNHood(NHood2);
            District2.addNHood(NHood3);
            database[0] = District1;
            database[1] = District2;

        }

        private void DistrictForm_Load(object sender, EventArgs e)
        {

        }

        private void displayDistricts()
        {
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
            nHoodOutputBox.Items.Clear();
            if(numOfDistricts != 0 && selectedDistrict != -1)
            {
                for (int nHoodIndex = 0; nHoodIndex < database[selectedDistrict].getNumOfnHoods(); nHoodIndex++)
                {
                    nHoodOutputBox.Items.Add(database[selectedDistrict].getDistrictNHoods()[nHoodIndex].getnHoodName());


                }


            }

        }
        private void displayProperties()
        {
            propertyOutputBox.Items.Clear();
            if(numOfDistricts != 0 && selectedNHood != -1)
            {
                for (int propertyIndex = 0; propertyIndex < database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNumOfProperties(); propertyIndex++)
                {
                    propertyOutputBox.Items.Add(database[selectedDistrict].getDistrictNHoods()[selectedNHood].getNHoodProperties()[propertyIndex].getPropertyName());

                }

            }

        }


        private void AddDistrictButton_Click(object sender, EventArgs e)
        {
            addDistrictFormInstance = new addDistrictForm();
            addDistrictFormInstance.Show();
            initialForm.Hide();

        }

        private void EditDistrictButton_Click(object sender, EventArgs e)
        {
            editDistrictFormInstance = new editDistrictForm();
            editDistrictFormInstance.Show();
            initialForm.Hide();

        }
        private void AddPropertyButton_Click(object sender, EventArgs e)
        {
            addPropertyFormInstance = new addPropertyForm();
            addPropertyFormInstance.Show();
            initialForm.Hide();

        }

        private void AddNHoodButton_Click(object sender, EventArgs e)
        {
            addNeighborhoodFormInstance = new addNeighborhoodForm();
            addNeighborhoodFormInstance.Show();
            initialForm.Hide();

        }
    }
}
