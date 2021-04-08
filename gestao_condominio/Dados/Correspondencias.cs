using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_condominio.Dados
{
    public class Correspondencias
    {
        public int morador { get; set; }

        public int tipo { get; set; }

        public Nullable<DateTime> data_recebimento { get; set; }

        public Nullable<DateTime> data_retirada { get; set; }

        public string obs { get; set; }
    }
}
