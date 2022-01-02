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
    public partial class ImportForm : Form
    {
        MEDICALCOMPANYEntities db = new MEDICALCOMPANYEntities();

        public ImportForm()
        {
            InitializeComponent();
        }

        //add function
        private void addBtn_Click(object sender, EventArgs e)
        {
            db.IMPORT_ORDER(importID.Text, proID.Text, proName.Text, importDate.Value, int.Parse(price.Text), Convert.ToInt32(quantity.Value));
            db.SaveChanges();
            importID.Clear();
            proID.Clear();
            proName.Clear();
            price.Clear();
            this.dataShow();
        }

        // display data when input
        void dataShow()
        {
            importDataGridView.DataSource = db.showTempIMPORT();
        }
        //display data when open
        private void ImportForm_Load(object sender, EventArgs e)
        {
            this.dataShow();
        }

        //done button function, click after finish input all information
        private void doneBtn_Click(object sender, EventArgs e)
        {
            db.delTempImportValue();
            db.SaveChanges();
            this.Close();
        }

        //update button function
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(importID.Text))
            {
                db.UPDATE_IMPORT_ORDER(importID.Text, proID.Text, proName.Text, importDate.Value, int.Parse(price.Text), Convert.ToInt32(quantity.Value));
                db.SaveChanges();
                importID.Clear();
                proID.Clear();
                proName.Clear();
                price.Clear();
                this.dataShow();
            } else
            {
                MessageBox.Show("Please select something first");
            }
        }

        //for selecting to make changes of cells
        private void importDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            importID.Text = importDataGridView.SelectedCells[0].Value.ToString();
            proID.Text = importDataGridView.SelectedCells[1].Value.ToString();
            proName.Text = importDataGridView.SelectedCells[2].Value.ToString();
            importDate.Value = Convert.ToDateTime(importDataGridView.SelectedCells[3].Value.ToString());
            price.Text = importDataGridView.SelectedCells[4].Value.ToString();
            quantity.Value = Convert.ToInt32(importDataGridView.SelectedCells[5].Value.ToString());
        }

        //delete button function
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(importID.Text))
            {
                db.DELETE_IMPORT_ORDER(importID.Text);
                db.SaveChanges();
                importID.Clear();
                proID.Clear();
                proName.Clear();
                price.Clear();
                this.dataShow();
            }
            else
            {
                MessageBox.Show("Please select something first");
            }
        }
    }
}
