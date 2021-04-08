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

namespace gestao_condominio.Forms
{
    public partial class CadAtivo : Form
    {
        private List<Ativo> listResult = new List<Ativo>();

        public CadAtivo()
        {
            InitializeComponent();
        }

        public void CadAtivo_Load(object sender, EventArgs e)
        {
            var listResult = new List<Ativo>();

            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            txtArea.Enabled = true;
            txtItem.Enabled = true;
            txtMarca.Enabled = true;
            dtCadastro.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var listAtivo = new Ativo();

            listAtivo.Item = txtItem.Text;
            listAtivo.Marca = txtMarca.Text;
            listAtivo.Area = txtArea.Text;
            listAtivo.Data_Cadastro = dtCadastro.Value;

            listResult.Add(listAtivo);

            SqlUtils.InsertAtivo(listResult);

            btnSalvar.Enabled = false;
            txtArea.Enabled = false;
            txtArea.Text = string.Empty;
            txtItem.Enabled = false;
            txtItem.Text = string.Empty;
            txtMarca.Enabled = false;
            txtMarca.Text = string.Empty;
            dtCadastro.Enabled = false;

            btnSalvar.Enabled = false;
        }

        
    }
}
