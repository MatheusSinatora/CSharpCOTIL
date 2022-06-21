namespace Aula04_Exemp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String curso = "";
            short serie = 0;

            if (radioButton1.Checked) curso = "Desenvolvimento de Sistemas";
            else if (radioButton2.Checked) curso = "Edificações";
            else if (radioButton3.Checked) curso = "Geodésia e Cartografia";

            if (radioButton6.Checked) serie = 1;
            else if (radioButton5.Checked) serie = 2;
            else if (radioButton4.Checked) serie = 3;

            if (!(String.IsNullOrEmpty(curso)) && (serie != 0))
            {
                label1.Text = "O aluno faz o curso de " + curso + " e está na " + serie + " série";
            }
            else MessageBox.Show("Escolha um curso e uma série");


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}