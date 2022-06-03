using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula07IDatasArquivos
{
    public partial class Form2 : Form
    {
        int op = 0;
        DialogResult bolinha;
        string caminho = Directory.GetCurrentDirectory();
        int linha_tabela;
        public Form2()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToLongDateString();
            //textBox1.Text = monthCalendar1.SelectionRange.Start.ToString("MM/dd/yyyy");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            op = 2;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            op = 4;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            op = 6;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            op = 8;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            op = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(op == 2)
            {
                label3.Text = textBox2.Text;
            }
            else if (op == 4)
            {
                label5.Text = textBox2.Text;
            }
            else if (op == 6)
            {
                label7.Text = textBox2.Text;
            }
            else if (op == 8)
            {
                label9.Text = textBox2.Text;
            }
            else if (op == 10)
            {
                label11.Text = textBox2.Text;
            }
            else
                MessageBox.Show("Escolha um horário");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome_arq = monthCalendar1.SelectionRange.Start.ToLongDateString();
            StreamWriter arquivo;

            if (System.IO.File.Exists(caminho + nome_arq + ".txt"))
                File.Delete(caminho + nome_arq + ".txt");
            arquivo = new StreamWriter(caminho + nome_arq + ".txt");

            foreach (Label controle in tableLayoutPanel1.Controls)
            {
                arquivo.WriteLine(controle.Text);
            }
            arquivo.Close();

            MessageBox.Show("Arquivo Gravado com Sucesso!", "Finalização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
