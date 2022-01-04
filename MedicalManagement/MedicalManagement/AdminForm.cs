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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void goodsReceivedBtn_Click(object sender, EventArgs e)
        {
            ImportForm import = new ImportForm();
            import.Show();
        }

        private void goodsDeliveryBtn_Click(object sender, EventArgs e)
        {
            ExportForm export = new ExportForm();
            export.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.Show();
        }

        private void productManagementBtn_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
        }

        private void agentBtn_Click(object sender, EventArgs e)
        {
            AgentList agentList = new AgentList();
            agentList.Show();
        }
    }
}
