using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_condominio.Dados
{
    public class Ocorrencias
    {
        public int morador { get; set; }

        public string ocorrencia { get; set; }

        public Nullable<DateTime> data { get; set; }
    }
}
