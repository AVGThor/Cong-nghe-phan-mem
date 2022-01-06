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
    public partial class Statistics : Form
    {
        MEDICALCOMPANYEntities db = new MEDICALCOMPANYEntities();
        public Statistics()
        {
            InitializeComponent();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.showIMPORT(Convert.ToInt32(month.Value));
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.showEXPORT(Convert.ToInt32(month.Value));
        }

        private void revenueBtn_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.showREVENUE(Convert.ToInt32(month.Value));
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            db.delRevenueValue();
            db.SaveChanges();
            this.Close();
        }
    }
}
