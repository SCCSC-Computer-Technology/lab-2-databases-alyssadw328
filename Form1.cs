using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Walker_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void btnAscend_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.OrderByPop(this.cityDBDataSet.City);
        }

        private void btnDescend_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.OrderedPopDesc(this.cityDBDataSet.City);
        }

        private void btnCityName_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.CityNameOrder(this.cityDBDataSet.City);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Population: " + this.cityTableAdapter.PopulationSum());
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Average Population: " + this.cityTableAdapter.AvgPop());
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Highest Population: " + this.cityTableAdapter.HighestPop());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lowest Population: " + this.cityTableAdapter.LowestPop());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
