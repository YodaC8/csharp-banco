using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANCO
{
    public partial class Form1 : Form
    {
        Cliente cliente;

        public Form1()
        {
            InitializeComponent();
            this.cliente = new Cliente();

          
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

        private void aRQUIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDeposito_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBoxDeposito.Text);
            if (valor > 0)
            {

                cliente.Creditar(valor);

                labelSaldoValor.Text = cliente.saldo.ToString();

                MessageBox.Show("Parabéns você sabe clicar num botão.");
            }
            else 
            {
                MessageBox.Show("Digite um valor valido,seu incompetente");
            }
            textBoxDeposito.Clear();
        }

        private void labelSaldoValor_Click(object sender, EventArgs e)
        {

        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {

            double valor = Convert.ToDouble(textBoxDebito.Text);
            if (valor > 0)
            {

                cliente.Debitar(valor);

                labelSaldoValor.Text = cliente.saldo.ToString();
                 
                MessageBox.Show("Parabéns você sabe clicar num botão.");
            }
            else
            {
                MessageBox.Show("Digite um valor valido,seu incompetente");
            }
            textBoxDebito.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
