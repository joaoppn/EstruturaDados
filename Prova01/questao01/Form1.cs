using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarExpressao(textBox1.Text))
            {
                label1.Text = "Expressão " +textBox1.Text +  " está correta!";
                textBox1.Text = "";
            }
            else
            {
                label1.Text = "Expressão " +textBox1.Text +  " está errada!!";
                textBox1.Text = "";
            }


            textBox1.Text = "";

        }

        public static bool VerificarExpressao(string expressao)
        {
            Pilha pilha = new Pilha();

            foreach (char caractere in expressao)
            {
                if (caractere == '(' || caractere == '[' || caractere == '{')
                {
                    pilha.Empilhar(caractere);
                }
                else if (caractere == ')' || caractere == ']' || caractere == '}')
                {
                    if (pilha.EstaVazia())
                    {
                        return false;
                    }

                    char topo = pilha.Desempilhar();

                    if (caractere == ')' && topo != '(' ||
                        caractere == ']' && topo != '[' ||
                        caractere == '}' && topo != '{')
                    {
                        return false;
                    }
                }
                else
                {
                    continue;
                }
            }

            return pilha.EstaVazia();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}
