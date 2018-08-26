using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropecuaria
{
    class classe_funcionarios
    {
        public classe_funcionarios()
        {
            bairro = null;
            cidade = null;
            cod_funcionario = 0;
            cpf = null;
            data_cadastro = DateTime.Now;
            data_nascimento = DateTime.Now;
            login_funcionario = null;
            numero_casa = 0;
            rg = null;
            rua = null;
            senha_funcionario = null;
            status = 0;
            tel_celular = null;
            nome = null;
            funcao = null;
            erro = null;
        }
        public string bairro { get; set; }
            public string cidade { get; set; }
            public int cod_funcionario { get; set; }
            public string cpf { get; set; }
            public DateTime data_cadastro { get; set; }
            public DateTime data_nascimento { get; set; }
            public string login_funcionario { get; set; }
            public int numero_casa { get; set; }
            public string rg { get; set; }
            public string rua { get; set; }
            public string senha_funcionario { get; set; }
            public int status { get; set; }
            public string tel_celular { get; set; }
            public string nome { get; set; }
            public int sexo { get; set; }
            public string tel_celular2 { get; set; }
            public string funcao { get; set; }
            public string erro { get; set; }
        public int cadastrar_funcionarios()
        {
            string query = "insert into funcionarios values (0, '" + rg + "', '" + cpf + "','" + data_nascimento.ToString("yyyy-MM-dd") + "', now(), '" + rua + "', '" + bairro + "','" + cidade + "', '" + numero_casa + "', '" + senha_funcionario + "', '" + login_funcionario + "', '" + tel_celular + "', 1, '" + nome + "', '" + sexo + "', '" + tel_celular2 + "', '" + funcao + "')";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
                }
        }
    }
