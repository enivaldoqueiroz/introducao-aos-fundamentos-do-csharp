using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "Olá";
            string nome = "Jose";
            MessageBox.Show($"{mensagem} {nome}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 25;
            int idadeJose = 30;
            int mediaIdades = (idadeJoao + idadeMaria + idadeJose) / 3;

            MessageBox.Show("Media das idades " + mediaIdades);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int pi = 3.14; // O codigo não compila
            
            //MessageBox.Show("pi " + pi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;

            MessageBox.Show("piQuebrodo = " + piQuebrado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;

            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }

            MessageBox.Show("Saldo atual: " + saldo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;

            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }

            MessageBox.Show("Saldo atual: " + saldo);
        }
    }
}
