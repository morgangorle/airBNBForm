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
    public partial class addNeighborhoodForm : Form
    {
        addNeighborhoodForm currentForm;
        public addNeighborhoodForm()
        {
            InitializeComponent();
            currentForm = this;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DistrictForm.initialForm.Show();
            currentForm.Close();
        }
    }
}
