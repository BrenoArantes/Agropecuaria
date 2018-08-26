using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropecuaria
{
    class classe_categoria
    {
        public classe_categoria()
        {
            cod_categoria = 0;
            data_cadastro_categoria = DateTime.Now;
            nome_categoria = null;
            status = 0;
            erro = null;
        }
         public int cod_categoria { get; set; }
         public DateTime data_cadastro_categoria { get; set; }
        public string nome_categoria { get; set; }
        public int status { get; set; } 
        public string erro { get; set; } 
        
        public int cadastrar_categoria()
        {
            string query = "insert into categoria values (0, now(), '" + nome_categoria + "', 1)";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }           
    }
}
