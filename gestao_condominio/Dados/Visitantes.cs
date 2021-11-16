using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_condominio.Dados
{
    public class CadVisitantes
    {
        public int morador { get; set; }

        public string nome { get; set; }

        public Nullable<DateTime> data_visita { get; set; }

        public string rg { get; set; }
    }
}
