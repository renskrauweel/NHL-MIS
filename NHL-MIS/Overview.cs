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

        private string[,] tableData = new string[,]
        {
            { "H. de Vries", "ICT", "0612345678", "16" },
            { "E. Hoekstra", "ICT", "0687654321", "21" },
            { "O. Koning", "Directie", "06976851432", "13" }
        };

        public Overview()
        {
            InitializeComponent();

            fillTable(this.tlpEmployees);
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            ViewEmployee employee = new ViewEmployee();
            employee.MdiParent = this.ParentForm;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee employee = new AddEmployee();
            employee.MdiParent = this.ParentForm;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.ParentForm.Close();
        }

        private void fillTable(TableLayoutPanel tlpEmployees)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    int varx = x;
                    int vary = y;
                    Console.WriteLine(varx + " " + vary);

                    Label label = new Label();
                    label.Text = tableData[x, y];
                    tlpEmployees.Controls.Add(label, y, x+1);
                }
            }
        }
    }
}
