using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppUTSPBO
{
    public partial class Registermhs : Form
    {
        public Registermhs()
        {
            InitializeComponent();
        }

        private void Registermhs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginmhs loginmhs = new Loginmhs();
            loginmhs.Show();
        }
    }
}
