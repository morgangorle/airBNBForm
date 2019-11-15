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
    }
}
