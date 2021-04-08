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
    public partial class CadOrcamento : Form
    {
        public CadOrcamento()
        {
            InitializeComponent();
        }

        private void CadOrcamento_Load(object sender, EventArgs e)
        {
            txtConteudo.TextChanged += txtConteudo_TextChanged;
            txtConteudo.Multiline = true;
            txtConteudo.ScrollBars = ScrollBars.None;

            AutoSizeTextBox(txtConteudo);
        }

        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {
            AutoSizeTextBox(txtConteudo);
        }

        private void AutoSizeTextBox(TextBox txt)
        {
            const int margem_x = 20;
            const int margem_y = 20;

            Size tamanho = TextRenderer.MeasureText(txt.Text, txt.Font);
            txt.ClientSize = new Size(tamanho.Width + margem_x, tamanho.Height + margem_y);
        }
    }
}
