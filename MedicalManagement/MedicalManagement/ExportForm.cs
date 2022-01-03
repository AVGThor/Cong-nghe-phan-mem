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
    public partial class ExportForm : Form
    {
        MEDICALCOMPANYEntities db = new MEDICALCOMPANYEntities();
        public ExportForm()
        {
            InitializeComponent();
        }

        //add function
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(exportID.Text))
            {
                db.EXPORT_ORDER(exportID.Text, proID.Text, proName.Text, exportDate.Value, Convert.ToInt32(quantity.Value), int.Parse(price.Text), deliverStatus.Text, paymentStatus.Text);
                db.SaveChanges();
                exportID.Clear();
                proID.Clear();
                proName.Clear();
                price.Clear();
                deliverStatus.Text = "";
                paymentStatus.Text = "";
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
            exportDataGridView.DataSource = db.showTempEXPORT();
        }
        //display data when open
        private void ExportForm_Load(object sender, EventArgs e)
        {
            this.dataShow();
        }

        //for selecting to make changes of cells
        private void exportDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            exportID.Text = exportDataGridView.SelectedCells[0].Value.ToString();
            proID.Text = exportDataGridView.SelectedCells[1].Value.ToString();
            proName.Text = exportDataGridView.SelectedCells[2].Value.ToString();
            exportDate.Value = Convert.ToDateTime(exportDataGridView.SelectedCells[3].Value.ToString());
            quantity.Value = Convert.ToInt32(exportDataGridView.SelectedCells[4].Value.ToString());
            price.Text = exportDataGridView.SelectedCells[5].Value.ToString();
            deliverStatus.Text = exportDataGridView.SelectedCells[6].Value.ToString();
            paymentStatus.Text = exportDataGridView.SelectedCells[7].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(exportID.Text))
            {
                db.UPDATE_EXPORT_ORDER(exportID.Text, proID.Text, proName.Text, exportDate.Value, Convert.ToInt32(quantity.Value), int.Parse(price.Text), deliverStatus.Text, paymentStatus.Text);
                db.SaveChanges();
                exportID.Clear();
                proID.Clear();
                proName.Clear();
                price.Clear();
                deliverStatus.Text = "";
                paymentStatus.Text = "";
                this.dataShow();
            }
            else
            {
                MessageBox.Show("Please select something first");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(exportID.Text))
            {
                db.DELETE_EXPORT_ORDER(exportID.Text);
                db.SaveChanges();
                exportID.Clear();
                proID.Clear();
                proName.Clear();
                price.Clear();
                this.dataShow();
                deliverStatus.Text = "";
                paymentStatus.Text = "";
            }
            else
            {
                MessageBox.Show("Please select something first");
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            db.delTempExportValue();
            db.SaveChanges();
            this.Close();
        }
    }
}
