namespace ExercTabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int valor;
            valor = int.Parse(textValor.Text);
            
            for(int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(valor + "*" + i + "=" + (i * valor));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textValor.Clear();
        }
    }
}