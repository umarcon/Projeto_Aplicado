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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var listPesquisa = new List<Usuario>();

            var usuario = txtUsuario.Text;
            var senha = txtSenha.Text;

            listPesquisa = SqlUtils.GetUsuario(usuario, senha);

            if (listPesquisa.Count == 0)
            {
                MessageBox.Show("Usuário ou senha inválido!");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
