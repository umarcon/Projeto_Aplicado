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
    public partial class CadUsuario : Form
    {
        private List<Usuario> listResult = new List<Usuario>();

        public CadUsuario()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var listUsuario = new Usuario();

            listUsuario.Nome = txtNome.Text;
            listUsuario.Cargo = txtCargo.Text;
            listUsuario.Login = txtLogin.Text;
            listUsuario.Senha = txtSenha.Text;

            listResult.Add(listUsuario);

            SqlUtils.InsertUsuario(listResult);
        }

        private void CadUsuario_Load(object sender, EventArgs e)
        {
            var listResult = new List<Usuario>();
        }
    }
}
