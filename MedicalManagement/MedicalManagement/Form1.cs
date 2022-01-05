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
    public partial class Form1 : Form
    {
        MEDICALCOMPANYEntities db = new MEDICALCOMPANYEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            bool adminCheck = db.userLogins.Any(x => x.username == usertxt.Text && x.userPass == passtxt.Text);
            bool userCheck = db.userLogins.Any(x => x.username == usertxt.Text && x.userPass == passtxt.Text);

            if (adminCheck)
            {
                AdminForm ad = new AdminForm();
                this.Hide();
                ad.Show();
                MessageBox.Show("Login Successfully");
            }
            else if (userCheck)
            {
                AdminForm uf = new AdminForm();
                this.Hide();
                uf.Show();
                MessageBox.Show("Login Successfully");
            }
            else
            {
                MessageBox.Show("Username or Password incorrect");
            }
        }
    }
}
