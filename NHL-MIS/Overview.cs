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
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
            //Utils utils = new Utils();
            //utils.InitialiseForm(this);
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            EditEmployee employee = new EditEmployee();
            employee.MdiParent = this.ParentForm;
            employee.Show();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee employee = new AddEmployee();
            employee.MdiParent = this.ParentForm;
            employee.Show();
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.ParentForm.Close();
        }
    }
}
