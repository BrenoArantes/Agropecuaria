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
    public partial class frm_cad_produtos : Form
    {
        public frm_cad_produtos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frm_cad_produtos_Load(object sender, EventArgs e)
        {

        }

        private void bt_cad_produtos_cadastrar_Click(object sender, EventArgs e)
        {
            classe_produtos cfunc = new classe_produtos();

            if (txt_nome_produto.Text != "" && txt_marca_produto.Text != "" && txt_valor_produto.Text != "")
            {
                cfunc.nome_produto = txt_nome_produto.Text;
               
            }

        }
    }
}
