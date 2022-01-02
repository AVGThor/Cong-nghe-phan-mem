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
    }
}
