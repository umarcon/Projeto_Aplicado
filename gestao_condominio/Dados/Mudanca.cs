using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_condominio.Dados
{
    public class Mudanca
    {
        public string Morador { get; set; }

        public Nullable<DateTime> Data { get; set; }

        public int Tipo { get; set; }

        public string Obs { get; set; }
    }
}
