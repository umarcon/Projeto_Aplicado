using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestao_condominio.Forms
{
    public partial class EnviaEmail : Form
    {
        public EnviaEmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instancia um OpenFileDialog
            OpenFileDialog dialogo = new OpenFileDialog();

            // Define o título da janela
            dialogo.Title = "Procurar arquivos no computador";

            // Define o diretório inicial que a janela usará
            // Aqui provavelmente você vai querer colocar o
            // valor que está na sua caixa de texto
            dialogo.InitialDirectory = @"C:\";

            // Define o filtro que você quiser para mostrar
            // apenas os arquivos do tipo que você conhece
            dialogo.Filter = "Arquivos texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";

            // Mostra a janela para o usuário, e guarda o retorno
            // que indica se ele chegou a selecionar um arquivo, ou
            // cancelou a janela sem selecionar um arquivo...
            DialogResult resposta = dialogo.ShowDialog();

            // O usuário selecionou um arquivo e clicou em OK?
            if (resposta == DialogResult.OK)
            {
                // Sim!
                // Obtém o caminho completo do arquivo
                string caminhoCompleto = dialogo.FileName;
                textBox1.Text = caminhoCompleto;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Instancia um OpenFileDialog
            OpenFileDialog dialogo = new OpenFileDialog();

            // Define o título da janela
            dialogo.Title = "Procurar arquivos no computador";

            // Define o diretório inicial que a janela usará
            // Aqui provavelmente você vai querer colocar o
            // valor que está na sua caixa de texto
            dialogo.InitialDirectory = @"C:\";

            // Define o filtro que você quiser para mostrar
            // apenas os arquivos do tipo que você conhece
            dialogo.Filter = "Todos os arquivos (*.*)|*.*";

            // Mostra a janela para o usuário, e guarda o retorno
            // que indica se ele chegou a selecionar um arquivo, ou
            // cancelou a janela sem selecionar um arquivo...
            DialogResult resposta = dialogo.ShowDialog();

            // O usuário selecionou um arquivo e clicou em OK?
            if (resposta == DialogResult.OK)
            {
                // Sim!
                // Obtém o caminho completo do arquivo
                string caminhoCompleto = dialogo.FileName;
                textBox2.Text = caminhoCompleto;
            }
        }
    }
}
