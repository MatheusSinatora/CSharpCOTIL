namespace ExCalcGasolina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcularCombústivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if(Application.OpenForms.OfType<Form2>().Count()==0)
                {
                    Form2 filho2 = new Form2();
                    filho2.MdiParent = this;
                    filho2.Show();
                }
        }

        private void calcularÓleoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form3>().Count() == 0)
            {
                Form3 filho3 = new Form3();
                filho3.MdiParent = this;
                filho3.Show();
            }
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();

        }
    }
}