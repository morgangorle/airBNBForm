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
        public addPropertyForm()
        {
            InitializeComponent();
            currentForm = this;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            currentForm.Close();
            DistrictForm.initialForm.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int districtIndex = 0;
            int neighborhoodIndex = 0;

            Property newProperty;
            newProperty = new Property(propertyIDBox.Text, propertyNameBox.Text, hostIDBox.Text, hostNameBox.Text, roomTypeBox.Text, double.Parse(latitudeBox.Text), double.Parse(longitudeBox.Text), double.Parse(priceBox.Text), int.Parse(numOfPropertiesBox.Text), int.Parse(minNumNightsBox.Text),int.Parse(availiabilityBox.Text));
            districtIndex = searchDistrict(districtNameBox.Text);
            neighborhoodIndex = searchNeighborhood(nHoodNameBox.Text);

        }
        public int searchDistrict(string inputDistrict)
        {
            return 0;
        }
        public int searchNeighborhood(string inputNeighborhood)
        {
            return 0;
        }
    }
}
