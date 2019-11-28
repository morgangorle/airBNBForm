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
    public partial class addDistrictForm : Form
    {
        addDistrictForm currentForm;
        District newDistrict;
        public addDistrictForm()
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
            newDistrict = new District(districtNameBox.Text);
            DistrictForm.initialForm.numOfDistricts++;
            Array.Resize(ref DistrictForm.initialForm.database, DistrictForm.initialForm.numOfDistricts);
            DistrictForm.initialForm.database[DistrictForm.initialForm.numOfDistricts - 1] = newDistrict;
            DistrictForm.initialForm.updateData();
            DistrictForm.initialForm.Show();
            currentForm.Close();




        }
    }
}
