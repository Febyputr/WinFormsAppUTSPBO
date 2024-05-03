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
    public partial class Loginmhs : Form
    {
        public Loginmhs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomepageMhs homepageMhs = new HomepageMhs();
            homepageMhs.Show();
        }

        private void Loginmhs_Load(object sender, EventArgs e)
        {
           
        }
    }
}
