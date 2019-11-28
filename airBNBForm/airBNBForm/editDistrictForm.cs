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
    public partial class editDistrictForm : Form
    {
        editDistrictForm currentForm;
        int currentDistrictIndex;
        bool foundSearchItem;
        public editDistrictForm()
        {
            InitializeComponent();
            currentForm = this;
            currentDistrictIndex = DistrictForm.initialForm.selectedDistrict;
            if (currentDistrictIndex == -1)
            {
                currentDistrictIndex = 0;
            }
            CurrentNameLabel.Text = DistrictForm.initialForm.database[currentDistrictIndex].getDistrictName();
            searchErrorLabel.Text = "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DistrictForm.initialForm.Show();
            currentForm.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            foundSearchItem = false;
            int searchIndex = 0;
            searchErrorLabel.Text = "";

            while (foundSearchItem == false && searchIndex < DistrictForm.initialForm.numOfDistricts)
            {
                if (DistrictForm.initialForm.database[searchIndex].getDistrictName() == searchInputBox.Text)
                {
                    foundSearchItem = true;
                    currentDistrictIndex = searchIndex;
                    CurrentNameLabel.Text = DistrictForm.initialForm.database[searchIndex].getDistrictName();
                }
                searchIndex++;

            }
            if (foundSearchItem == false)
            {
                searchErrorLabel.Text = "District not found";
            }

        }

        private void NextDistrictButton_Click(object sender, EventArgs e)
        {
            
            if (currentDistrictIndex + 1 != DistrictForm.initialForm.numOfDistricts)
            {
                currentDistrictIndex++;
                CurrentNameLabel.Text = DistrictForm.initialForm.database[currentDistrictIndex].getDistrictName();

            }
            else
            {
                currentDistrictIndex = 0;
                CurrentNameLabel.Text = DistrictForm.initialForm.database[currentDistrictIndex].getDistrictName();
            }

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DistrictForm.initialForm.database[currentDistrictIndex].setDistrictName(newNameBox.Text);
            DistrictForm.initialForm.updateData();
            DistrictForm.initialForm.Show();
            currentForm.Close();

        }
    }
}
