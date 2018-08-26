using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropecuaria
{
    class classe_produtos
    {
     public classe_produtos()
        {
            cod_categoria = 0;
            cod_marca = 0;
            cod_produto = 0;
            data_cadastro = DateTime.Now;
            nome_produto = null;
            preco = 0;
            quantidade = 0;
            status = 0;
            erro = null;
        }

        public int cod_categoria { get; set; }
        public int cod_marca { get; set; }
        public int cod_produto { get; set; }
        public DateTime data_cadastro { get; set; }
        public string nome_produto { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }
        public int status { get; set; }
        public string erro { get; set; }

        public int cadastrar_produtos()
        {
            string query = "insert into produtos values (0, 0, 0, now(),'" + nome_produto + "', 0,0,1 ";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }
    }
}
