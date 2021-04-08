using gestao_condominio.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestao_condominio
{
    public partial class CadMorador : Form
    {
        private List<Morador> listResult = new List<Morador>();

        public CadMorador()
        {
            InitializeComponent();
        }

        private void CadMorador_Load(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textCpf.Enabled = true;
            textNome.Enabled = true;
            textApto.Enabled = true;
            textEmail.Enabled = true;
            textTelefone.Enabled = true;
            textRg.Enabled = true;
            textMoradores.Enabled = true;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = true;
            btnAdicionar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var listMorador = new Morador();
            var listPesquisa = new List<Morador>();

            listPesquisa = SqlUtils.GetMorador(Convert.ToInt32(textApto.Text));

            if (listPesquisa.Count == 0)
            {
                listMorador.nome = textNome.Text;
                listMorador.cpf = textCpf.Text;
                listMorador.apartamento = Convert.ToInt32(textApto.Text);
                listMorador.email = textEmail.Text;
                listMorador.telefone = textTelefone.Text;
                listMorador.rg = textRg.Text;
                listMorador.moradores = textMoradores.Text;

                listResult.Add(listMorador);

                SqlUtils.InsertMorador(listResult);
            }
            else
            {
                listMorador.nome = textNome.Text;
                listMorador.cpf = textCpf.Text;
                listMorador.apartamento = Convert.ToInt32(textApto.Text);
                listMorador.email = textEmail.Text;
                listMorador.telefone = textTelefone.Text;
                listMorador.rg = textRg.Text;
                listMorador.moradores = textMoradores.Text;

                listResult.Add(listMorador);

                SqlUtils.UpdateMorador(listResult);
            }
            

            textCpf.Enabled = false;
            textCpf.Text = string.Empty;

            textNome.Enabled = false;
            textNome.Text = string.Empty;

            textApto.Enabled = false;
            textApto.Text = string.Empty;

            textEmail.Enabled = false;
            textEmail.Text = string.Empty;

            textTelefone.Enabled = false;
            textTelefone.Text = string.Empty;

            textRg.Enabled = false;
            textRg.Text = string.Empty;
            
            textMoradores.Enabled = false;
            textMoradores.Text = string.Empty;

            btnPesquisar.Enabled = true;

            btnSalvar.Enabled = false;
            btnAdicionar.Enabled = true;

            listResult.Remove(listMorador);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var listPesquisa = new List<Morador>();

            if (string.IsNullOrEmpty(textApto.Text))
            {
                MessageBox.Show("Informe um número de apartamento!");
            }
            else
            {
                listPesquisa = SqlUtils.GetMorador(Convert.ToInt32(textApto.Text));

                foreach (var item in listPesquisa)
                {
                    var list = new Morador();

                    list.apartamento = item.apartamento;
                    textApto.Text = item.apartamento.ToString();

                    list.cpf = item.cpf;
                    textCpf.Text = item.cpf;

                    list.email = item.email;
                    textEmail.Text = item.email;

                    list.nome = item.nome;
                    textNome.Text = item.nome;

                    list.proprietario = item.proprietario;

                    list.rg = item.rg;
                    textRg.Text = item.rg;

                    list.telefone = item.telefone;
                    textTelefone.Text = item.telefone;

                    listResult.Add(list);

                    btnEditar.Enabled = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            textCpf.Enabled = true;
            textNome.Enabled = true;
            textApto.Enabled = true;
            textEmail.Enabled = true;
            textTelefone.Enabled = true;
            textRg.Enabled = true;
            textMoradores.Enabled = true;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = true;
            btnAdicionar.Enabled = false;
        }
    }
}
