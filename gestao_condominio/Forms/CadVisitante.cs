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
    public partial class CadVisitante : Form
    {
        public CadVisitante()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.textBox1.Enabled = true;
            this.txtRG.Enabled = true;
            this.textBox2.Enabled = true;
            this.btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var listVisitantes = new CadVisitantes();
            var listPesquisa = new List<Morador>();
            var listResult = new List<CadVisitantes>();

            listPesquisa = SqlUtils.GetMorador(Convert.ToInt32(textBox2.Text));

            if (listPesquisa.Count > 0)
            {
                foreach (var item in listPesquisa)
                {
                    var data = DateTime.Parse(dtMudanca.Text);

                    var date = data.Year + "-" + data.Month + "-" + data.Day;

                    listVisitantes.nome = textBox1.Text;
                    listVisitantes.rg = txtRG.Text;
                    listVisitantes.morador = Convert.ToInt32(item.id);
                    listVisitantes.data_visita = DateTime.Parse(date);

                    listResult.Add(listVisitantes);

                    SqlUtils.InsertVisitantes(listResult);
                }

                listResult.Remove(listVisitantes);

                this.textBox1.Text = string.Empty;
                this.textBox2.Text = string.Empty;
                this.txtRG.Text = string.Empty;
                this.btnSalvar.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
