using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agropecuaria
{
    public partial class frm_cons_produtos : Form
    {
        public frm_cons_produtos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_pesq_Click(object sender, EventArgs e)
        {
            //váriavel p guardar a opção selecionada na combo de opções
            string Consulta = cb_opcoes.SelectedItem.ToString();
            classe_produtos cProduto = new classe_produtos();

           switch (Consulta)
            {
                case "Nome":
                    //verificar se algo foi digitado no text pesquisar
                    if (txt_pesquisar.Text != "")
                    {
                        //início
                        if (rd_btm_inicio.Checked)
                            {
                               cProduto.nome_produto = txt_pesquisar.Text;
                            dvg_produto.DataSource = cProduto.nome_produto();
                            }
                            //contem
                        else if (rd_btm_contem.Checked)
                            {
                                cProduto.nome_produto = txt_pesquisar.Text;
                                dvg_produto.DataSource = cProduto.nome_produto();
                            }
                     }
                        else
                            MessageBox.Show("Favor informar um nome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    //case categoria
                case "Categoria":
                        if (cb_categoria.Text != "")
                             {
                                cProduto.cod_categoria = Convert.ToInt32(cb_categoria.SelectedValue);
                                dvg_produto.DataSource = cProduto.buscar_produto_categoria();
                             }
                        else
                       MessageBox.Show("Favor escolher uma categoria.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    //case marca
                case "Marca":
                        if (cb_marca.Text != "")
                        {
                            cProduto.cod_marca = Convert.ToInt32(cb_marca.SelectedValue);
                            dvg_produto.DataSource = cProduto.buscar_produto_marca();
                        }
                        else
                        MessageBox.Show("Favor escolher uma marca.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    //case status
                case "Status":
                        if (rd_btm_ativo.Checked == true)
                        {
                            cProduto.status = 1;
                            dvg_produto.DataSource = cProduto.buscar_produto_status();
                        }
                        else
                            cProduto.status = 0;
                            dvg_produto.DataSource = cProduto.buscar_produto_status();
                        break;
            }
           
        }

        private void frm_cons_produtos_Load(object sender, EventArgs e)
        {
            //Combo com as opções de pesquisa
            cb_opcoes.Items.Add("Descrição");
            cb_opcoes.Items.Add("Categoria)");
            cb_opcoes.Items.Add("Marca");
            cb_opcoes.Items.Add("Status");
            cb_opcoes.SelectedIndex = 0;
//            rdbm_contem.Checked = true;
            //Combo de Marca
            classe_marca cMarca = new classe_marca();
//            cb_marca.DataSource = cMarca.buscar_marca(); //executa o método de consulta da classe marca
            cb_marca.DisplayMember = "NomeMarca"; //exibir o nome na combo
            cb_marca.ValueMember = "CodigoMarca"; // guardar no banco
            cb_marca.SelectedIndex = -1; // limpar a combo (n selecionar)
            //Combo Categoria 
            classe_categoria cCategoria = new classe_categoria();
//            cb_categoria.DataSource = cCategoria.buscar_categoria(); //executa o método de consulta da classe marca
            cb_categoria.DisplayMember = "NomeCategoria"; //exibir o nome na combo
            cb_categoria.ValueMember = "CodigoCategoria"; // guardar no banco
            cb_categoria.SelectedIndex = -1; // limpar a combo (n selecionar)
        }

        private void cb_opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_opcoes.SelectedIndex == 0) //nome
            {
                txt_pesquisar.Enabled = true;
                gb_tipo_pesquisa.Enabled = false;
                cb_categoria.Enabled = false;
                cb_marca.Enabled = false;
                gb_valores.Enabled = false;
                txt_pesquisar.Focus();
            }
            if (cb_opcoes.SelectedIndex == 1) //categoria
            {
                txt_pesquisar.Enabled = false;
                gb_tipo_pesquisa.Enabled = false;
                cb_categoria.Enabled = true;
                cb_marca.Enabled = false;
                gb_valores.Enabled = false;
            }
            if (cb_opcoes.SelectedIndex == 2) // marca
            { 
                txt_pesquisar.Enabled = false;
                gb_tipo_pesquisa.Enabled = false;
                cb_categoria.Enabled = false;
                cb_marca.Enabled = true;
                gb_valores.Enabled = false;
                txt_pesquisar.Focus();
            }
            if (cb_opcoes.SelectedIndex == 3) // status
            {
                txt_pesquisar.Enabled = false;
                gb_tipo_pesquisa.Enabled = false;
                cb_categoria.Enabled = false;
                cb_marca.Enabled = false;
                gb_valores.Enabled = false;
                txt_pesquisar.Focus();
            }
        }

        //método de pesquisa de produto
        //por nome, categoria, marca, preço e status
        //campos : código, produto, qtde, preço, marca, categoria, status

        //pesquisa de produto por descrição (inicial)
        public DataTable buscar_produto_nome_inicial()
        {
            string query = "select Produto.CodigoProduto 'Código', Produto.NomeProduto 'Produto', Produto.QtdeEstoque, Produto.PrecoVenda, Categoria.NomeCategoria, Marca.NomeMarca, Produto.Status from Produto inner join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria inner join Marca on marca.Codigomarca = Produto.Codigomarca where Produto.NomeProduto like '" + buscar_produto_nome_inicial + "%' and produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
