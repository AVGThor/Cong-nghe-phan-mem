using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class ProductManagement : Form
    {
        MEDICALCOMPANYEntities db = new MEDICALCOMPANYEntities();
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(proID.Text))
            {
                db.addProduct(proID.Text, proName.Text, int.Parse(price.Text), Convert.ToInt32(quantity.Value));
                db.SaveChanges();
                proID.Clear();
                proName.Clear();
                price.Clear();
                this.dataShow();
            }
            else
            {
                MessageBox.Show("Please input data first");
            }
        }

        // display data when input
        void dataShow()
        {
            productDataGridView.DataSource = db.showProduct();
        }
        private void ProductManagement_Load(object sender, EventArgs e)
        {
            this.dataShow();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(proID.Text))
            {
                db.updateProduct(proID.Text, proName.Text, int.Parse(price.Text), Convert.ToInt32(quantity.Value));
                db.SaveChanges();
                proID.Clear();
                proName.Clear();
                price.Clear();
                this.dataShow();
            }
            else
            {
                MessageBox.Show("Please input data first");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(proID.Text))
            {
                db.deleteProduct(proID.Text);
                db.SaveChanges();
                proID.Clear();
                proName.Clear();
                price.Clear();
                this.dataShow();
            }
            else
            {
                MessageBox.Show("Please input data first");
            }
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            proID.Text = productDataGridView.SelectedCells[0].Value.ToString();
            proName.Text = productDataGridView.SelectedCells[1].Value.ToString();
            price.Text = productDataGridView.SelectedCells[2].Value.ToString();
            quantity.Value = Convert.ToInt32(productDataGridView.SelectedCells[3].Value.ToString());
        }
    }
}
