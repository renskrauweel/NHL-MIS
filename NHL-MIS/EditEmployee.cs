using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHL_MIS
{
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        private void Opslaan_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            Overview page = new Overview();
            page.MdiParent = this.ParentForm;
            page.Dock = DockStyle.Fill;
            page.Show();
            Close();
        }
    }
}
