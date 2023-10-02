
using prova01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace questao02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pilha carros = new Pilha();

        private void button2_Click(object sender, EventArgs e)
        {
            if (carros.achar(txt_placa.Text))
            {
                carros.retirar_valor(txt_placa.Text);
                carros.Tam--;
                MessageBox.Show("Carro " + txt_placa.Text + " retirado! " + Convert.ToString(10 - carros.Tam) + " Vagas restantes!");
                txt_placa.Text = "";
                park.Text = carros.imprimir();
                

            }
            else
            {
                MessageBox.Show("Carro não existe!");
            }
            
        }

        private void bt_park_Click(object sender, EventArgs e)
        {
            if (carros.Tam < 10 & !(carros.achar(txt_placa.Text)))
            {
                carros.Empilhar(txt_placa.Text);
                carros.Tam++;
                MessageBox.Show("Carro " + txt_placa.Text + " estacionado! " + Convert.ToString(10 - carros.Tam) + " Vagas restantes!");
                txt_placa.Text = "";
                park.Text = carros.imprimir();
            }
            else if(carros.Tam >= 10)
            {
                MessageBox.Show("Estacionamento Lotado!");
            }
            else if (carros.achar(txt_placa.Text))
            {
                MessageBox.Show("Carro já foi adicionado!");
            }
            else
            {
                MessageBox.Show("Algo deu Errado!");
            }

        }
    }
}
