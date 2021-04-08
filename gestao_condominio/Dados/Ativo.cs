using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_condominio.Dados
{
    public class Ativo
    {
        public string Item { get; set; }

        public string Marca { get; set; }

        public string Area { get; set; }

        public Nullable<DateTime> Data_Cadastro { get; set; }
    }
}
