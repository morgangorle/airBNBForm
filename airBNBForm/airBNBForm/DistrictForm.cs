﻿using System;
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
    public partial class DistrictForm : Form
    {
        //These variables will store the data before it is output
        District[] database;
        Neighborhood[] storedNeighborhoods;
        Property[] storedProperties;
        //These variables will create the sample data
        Property sample1, sample2, sample3, sample4, sample5, sample6, sample7, sample8, sample9, sample10;
        Neighborhood NHood1, NHood2, NHood3;
        District District1, District2;
        public DistrictForm()
        {
            InitializeComponent();
            database = new District[2];
            districtNameLabel.Text = "";
            //Sample data
            sample1 = new Property("1", "House", "A Name", "Name1", "Single", 1, 1, 1, 1, 1, 1);
            sample2 = new Property("2", "House", "A Name", "Name2", "Single", 2, 2, 2, 2, 2, 2);
            sample3 = new Property("3", "House", "A Name", "Name3", "Single", 3, 3, 3, 3, 3, 3);
            sample4 = new Property("4", "House", "A Name", "Name4", "Single", 4, 4, 4, 4, 4, 4);
            sample5 = new Property("5", "House", "A Name", "Name5", "Single", 5, 5, 5, 5, 5, 5);
            sample6 = new Property("6", "House", "A Name", "Name6", "Single", 6, 6, 6, 6, 6, 6);
            sample7 = new Property("7", "House", "A Name", "Name7", "Single", 7, 7, 7, 7, 7, 7);
            sample8 = new Property("8", "House", "A Name", "Name8", "Single", 8, 8, 8, 8, 8, 8);
            sample9 = new Property("9", "House", "A Name", "Name9", "Single", 9, 9, 9, 9, 9, 9);
            sample10 = new Property("10", "House", "A Name", "Name10", "Single", 10, 10, 10, 10, 10, 10);
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

        private void displayDistrictButton_Click(object sender, EventArgs e)
        {
            outputBox.Items.Clear();
            storedNeighborhoods = database[0].getDistrictNHoods();
            districtNameLabel.Text = database[0].getDistrictName();
            storedProperties = storedNeighborhoods[0].getNHoodProperties();
            outputBox.Items.Add(String.Format("{0}",storedProperties[0].getPropertyName()));

        }
    }
}