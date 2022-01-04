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
    public partial class AgentList : Form
    {
        MEDICALCOMPANYEntities db = new MEDICALCOMPANYEntities();
        public AgentList()
        {
            InitializeComponent();
        }

        private void AgentList_Load(object sender, EventArgs e)
        {
            AgentDataGridView.DataSource = db.showAgent();
        }
    }
}
