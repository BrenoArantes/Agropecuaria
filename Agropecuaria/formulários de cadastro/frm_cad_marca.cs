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
    public partial class frm_cad_marca : Form
    {
        public frm_cad_marca()
        {
            InitializeComponent();
        }

        private void frm_cad_marca_Load(object sender, EventArgs e)
        {
            mask_data_cadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void bt_cad_marca_Click(object sender, EventArgs e)
        {
            classe_marca cMarca = new classe_marca();

            if (txt_nome_marca.Text != "")
            {
                cMarca.nome_marca = txt_nome_marca.Text;

                int aux = cMarca.cadastrar_marca();

                if (aux != 0)
                {
                    MessageBox.Show(" Marca: " + cMarca.nome_marca + " cadastrada com sucesso.", "Sistema de agropecuária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bt_cad_marca_limpar_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro.", "Sistema de agropecuária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nome_marca.BackColor = Color.DeepPink;
                txt_nome_marca.Focus();

            }
        }

        private void bt_cad_marca_limpar_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
