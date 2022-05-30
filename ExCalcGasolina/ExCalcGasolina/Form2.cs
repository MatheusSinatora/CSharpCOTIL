using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExCalcGasolina
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float calc;
            try
            {
                if (radioButton1.Checked)
                {
                    calc = (float.Parse(textBox1.Text) * float.Parse(textBox3.Text));
                    label6.Text = calc.ToString("0.00");
                }
                else if (radioButton2.Checked)
                {
                    calc = (float.Parse(textBox2.Text) * float.Parse(textBox3.Text));
                    label6.Text = calc.ToString("0.00");
                }
                else
                    MessageBox.Show("Selecione um combustível", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //try
            catch (Exception ex)
            {
                MessageBox.Show("Dados Incorretos");
                //MessageBox.Show(ex.Message);
                //catch
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
        }
    }
}
