using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeContatosT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonEnvio_Click(object sender, EventArgs e)
        {
            contato contato = new contato();
            contato.Nome=textBoxNome.Text;
            contato.Sobrenome=textBoxSobrenome.Text;
            contato.Telefone=textBoxTelefone.Text;

            listBoxLista.Items.Add(contato.ToString());
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
