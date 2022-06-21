namespace Aula04_Exemp4
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

        private void progressBar1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
                progressBar1.Value = i;

            listBox1.Items.Add(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            listBox1.Items.Add(comboBox1.Text);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(comboBox1.Text);
        }
    }
}