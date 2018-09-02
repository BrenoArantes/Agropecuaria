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
    public partial class frm_cad_categoria : Form
    {
        public frm_cad_categoria()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_cad_clientes_cadastrar_Click(object sender, EventArgs e)
        {
            classe_categoria cCategoria = new classe_categoria();

            if (txt_nome_categoria.Text != "" )
            {
                cCategoria.nome_categoria = txt_nome_categoria.Text;
               
                int aux = cCategoria.cadastrar_categoria();

                if (aux != 0)
                {
                    MessageBox.Show(" categoria: " + cCategoria.nome_categoria + " cadastrada com sucesso.", "Sistema de agropecuária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bt_cad_categoria_limpar_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro.", "Sistema de agropecuária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nome_categoria.BackColor = Color.DeepPink;
                txt_nome_categoria.Focus();
                
            }



        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frm_cad_categoria_Load(object sender, EventArgs e)
        {
            mask_data_cadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void txt_nome_categoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_cad_categoria_limpar_Click(object sender, EventArgs e)
        {

        }
    }
}
