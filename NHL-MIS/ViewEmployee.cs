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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditEmployee page = new EditEmployee();
            page.MdiParent = this.ParentForm;
            page.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            Overview page = new Overview();
            page.MdiParent = this.ParentForm;
            page.Show();
            Close();
        }
    }
}
