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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Gebruikersnaam")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Gebruikersnaam";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Wachtwoord")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Wachtwoord";
                textBox2.ForeColor = Color.Gray;
            }
        }
    }
}
