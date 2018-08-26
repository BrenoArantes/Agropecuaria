using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropecuaria
{
    class classe_marca
    {
        public classe_marca()
        {
            cod_marca = 0;
            data_cadastro_marca = DateTime.Now;
            nome_marca = null;
            status = 0;
            erro = null;
        }
        public int cod_marca { get; set; }
        public DateTime data_cadastro_marca { get; set; }
        public string nome_marca { get; set; }
        public int status { get; set; }
        public string erro { get; set; }

       public int cadastrar_marca()
        {
            string query = "insert into marca values (0, now(), '"+ nome_marca +"',1)";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }
    }
}
