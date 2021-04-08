using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_condominio.Dados
{
    public class ControleEstoque
    {
        public int IdItem { get; set; }

        public string Item { get; set; }

        public string MarcaItem { get; set; }

        public DateTime Data { get; set; }

        public int Entrada { get; set; }

        public int Saida { get; set; }

    }
}
