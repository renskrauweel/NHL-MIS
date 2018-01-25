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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Overview overview = new Overview();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            overview.MdiParent = this;
            overview.Dock = DockStyle.Fill;
            overview.Show();
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }
    }
}
