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
    public partial class CadMudanca : Form
    {
        private List<Mudanca> listResult = new List<Mudanca>();
        public CadMudanca()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var listMudanca = new Mudanca();

            listMudanca.Morador = txtMorador.Text;
            listMudanca.Data = dtMudanca.Value;

            if (chkEntrada.Checked)
            {
                listMudanca.Tipo = 1;
            }
            else
            {
                listMudanca.Tipo = 2;
            }
            
            listMudanca.Obs = txtObs.Text;

            listResult.Add(listMudanca);

            SqlUtils.InsertMudanca(listResult);
        }

        private void CadMudanca_Load(object sender, EventArgs e)
        {
            var listResult = new List<Mudanca>();
        }
    }
}
