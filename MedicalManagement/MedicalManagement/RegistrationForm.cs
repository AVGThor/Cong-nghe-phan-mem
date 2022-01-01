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
    public partial class RegistrationForm : Form
    {
        MEDICALCOMPANYEntities db = new MEDICALCOMPANYEntities();
        int? ID;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        void dataShow()
        {
            dataGridViewType.DataSource = db.LoginShowData().ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            db.LoginInsert(usertxt.Text, passtxt.Text, comboBoxType.Text);
            db.SaveChanges();
            MessageBox.Show("Data insert successfully");
            this.dataShow();
            usertxt.Clear();
            passtxt.Clear();

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.dataShow();

        }

        private void dataGridViewType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridViewType.SelectedCells[0].Value.ToString());
            usertxt.Text = dataGridViewType.SelectedCells[1].Value.ToString();
            passtxt.Text = dataGridViewType.SelectedCells[2].Value.ToString();
            comboBoxType.Text = dataGridViewType.SelectedCells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID!=null)
            {
                db.LoginUpdate(ID, usertxt.Text, passtxt.Text, comboBoxType.Text);
                db.SaveChanges();
                MessageBox.Show("Data update successfully");
                this.dataShow();
                usertxt.Clear();
                passtxt.Clear();
            }
            else
            {
                MessageBox.Show("Please select data first");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID!=null)
            {
                db.LoginDelete(ID);
                db.SaveChanges();
                MessageBox.Show("Data delete successfully");
                this.dataShow();
                usertxt.Clear();
                passtxt.Clear();
            }
            else
            {
                MessageBox.Show ("Nothing to delete");
            }
        }
    }
}
