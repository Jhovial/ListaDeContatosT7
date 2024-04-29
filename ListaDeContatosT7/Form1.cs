using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaDeContatosT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private contato[] contatos = new contato[1];

        private void Escrever(contato contato)
        {
            StreamWriter escreverEmArquivo = new StreamWriter("contatos.txt");
            escreverEmArquivo.WriteLine(contatos.Length + 1);
            escreverEmArquivo.WriteLine(contato.Nome);
            escreverEmArquivo.WriteLine(contato.Sobrenome);
            escreverEmArquivo.WriteLine(contato.Telefone);

            for (int x = 0; x < contatos.Length; x++)
            {
                escreverEmArquivo.WriteLine(contatos[x].Nome);
                escreverEmArquivo.WriteLine(contatos[x].Sobrenome);
                escreverEmArquivo.WriteLine(contatos[x].Telefone);
            }

            escreverEmArquivo.Close();
        }

        private void Ler()
        {
            StreamReader lerArquivo = new StreamReader("contatos.txt");
            contatos = new contato[Convert.ToInt32(lerArquivo.ReadLine())];

            for (int x = 0;x < contatos.Length; x++)
            {
                contatos[x] = new contato();
                contatos[x].Nome = lerArquivo.ReadLine();
                contatos[x].Sobrenome = lerArquivo.ReadLine();
                contatos[x].Telefone = lerArquivo.ReadLine();
            }

            lerArquivo.Close ();
        }

        private void Exibir () 
        { 
            listBoxLista.Items.Clear();
            for (int x = 0; x< contatos.Length; x++)
            {
                listBoxLista.Items.Add(contatos[x].ToString());
            }
        }

        private void LimparFormulario()
        {
            textBoxNome.Text = String.Empty;
            textBoxSobrenome.Text = String.Empty;
            textBoxTelefone.Text = String.Empty;
            
        }

        private void buttonEnvio_Click(object sender, EventArgs e)
        {
            contato contato = new contato();
            contato.Nome=textBoxNome.Text;
            contato.Sobrenome=textBoxSobrenome.Text;
            contato.Telefone=textBoxTelefone.Text;

            //listBoxLista.Items.Add(contato.ToString());

            Escrever(contato);
            Ler();
            Exibir();
            LimparFormulario();
        }


        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Exibir();
        }
    }
}
