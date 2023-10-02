using forms_listaDE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace questo03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ListaDE lista = new ListaDE();

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                lista.add(Convert.ToDouble(textBox1.Text));
                txt_lista.Text = lista.imprimi();
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Valor não é um double!");
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            try
            {
                lista.remove_valor(Convert.ToDouble(textBox1.Text));
                txt_lista.Text = lista.imprimi();

            }
            catch (FormatException)
            {
                MessageBox.Show("Valor não é um double!");
            }
        }
    }
}
