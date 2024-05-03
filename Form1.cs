namespace WinFormsAppUTSPBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
           Registermhs registermhs = new Registermhs();
            registermhs.Show();
        }

        private void checkBoxDosen_CheckedChanged(object sender, EventArgs e)
        {
            Register_Dosen register_Dosen = new Register_Dosen();
            register_Dosen.Show();
        }
        
    }
}
