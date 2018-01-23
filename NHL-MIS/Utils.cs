using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHL_MIS
{
    class Utils
    {
        public void InitialiseForm(Form form)
        {
            form.Font = new Font("Arial", 14);
            //form.Width = 1275;
            //form.Height = 715;
            form.Dock = DockStyle.Fill;
            // titel 28
        }
    }
}
