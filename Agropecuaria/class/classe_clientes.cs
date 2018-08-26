using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropecuaria
{
    class classe_clientes
    {
        public classe_clientes()
        {
            bairro = null;
            cidade = null;
            cod_cliente = 0;
            cpf = null;
            data_nascimento = DateTime.Now;
            nome = null;
            numero = 0;
            rg = null;
            rua = null;
            sexo = 0;
            status = 0;
            tel_celular = null;
            tel_celular2 = null;
            data_cadastro = DateTime.Now;
        }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public int cod_cliente { get; set; }
        public string cpf { get; set; }
        public DateTime data_nascimento { get; set; }
        public string nome { get; set; }
        public int numero { get; set; }
        public string rg { get; set; }
        public string rua { get; set; }
        public int sexo { get; set; }
        public int status { get; set; }
        public string tel_celular { get; set; }
        public string tel_celular2 { get; set; }
        public DateTime data_cadastro { get; set; }

        public int cadastrar_clientes()
        {
            string query = "insert into cliente values (0, '" + nome + "', '" + tel_celular + "', '" + tel_celular2 + "', 1, '" + rua + "', '" + bairro + "', '" + numero + "', '" + cidade + "', " + sexo + ", '" + rg + "', '" + cpf + "', '" + data_nascimento.ToString("yyyy-MM-dd") + "', now())";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }
    }
}
