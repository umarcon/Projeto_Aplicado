using gestao_condominio.Dados;
using gestao_condominio.Forms;
using Npgsql;
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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void moradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadMorador form = new CadMorador();

            form.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadUsuario form = new CadUsuario();

            form.Show();
        }

        private void ativoFixoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadAtivo form = new CadAtivo();

            form.Show();
        }

        private void mudançasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadMudanca form = new CadMudanca();

            form.Show();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadDespesas form = new CadDespesas();

            form.Show();
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadReceitas form = new CadReceitas();

            form.Show();
        }

        private void itemDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadItemEstoque form = new CadItemEstoque();

            form.Show();
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadControleEstoque form = new CadControleEstoque();

            form.Show();
        }

        private void automóveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadAutomovel form = new CadAutomovel();

            form.Show();
        }

        private void envioDeComunicadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnviaEmail form = new EnviaEmail();

            form.Show();
        }

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadOrcamento form = new CadOrcamento();

            form.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios form = new Relatorios();

            form.Show();
        }

        private void visitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadVisitante form = new CadVisitante();

            form.Show();
        }
    }
}
