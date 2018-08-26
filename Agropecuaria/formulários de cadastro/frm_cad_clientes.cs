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
    public partial class frm_cad_clientes : Form
    {
        public frm_cad_clientes()
        {
            InitializeComponent();
        }

        private void txt_data_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void bt_cad_clientes_cadastrar_Click(object sender, EventArgs e)
        {
            classe_clientes cClientes = new classe_clientes();

            if (txt_nome_clientes.Text !="" && mask_cpf_clientes.Text !="" && txt_cidade_clientes.Text !="" && mask_data_nascimento_clientes.Text !="" && mask_cpf_clientes.Text !="")
            {
                cClientes.nome = txt_nome_clientes.Text;
                cClientes.rua = txt_rua_clientes.Text;
                cClientes.bairro = txt_bairro_clientes.Text;
                cClientes.cidade = txt_cidade_clientes.Text;
                cClientes.cpf = mask_cpf_clientes.Text;
                cClientes.numero = Convert.ToInt32( txt_numero_clientes.Text);
                cClientes.data_nascimento = Convert.ToDateTime(mask_data_nascimento_clientes.Text);

                if (rd_bt_feminino.Checked)
                    cClientes.sexo = 0;
                else
                    cClientes.sexo = 1;

                if (mask_telefone_clientes.Text != "(  )     -    ")
                    cClientes.tel_celular = mask_telefone_clientes.Text;
                else
                    cClientes.tel_celular = "";
                if (mask_celular_clientes.Text != "(  )     -    ")
                    cClientes.tel_celular2 = mask_celular_clientes.Text;
                if (mask_rg_clientes.Text != "  .   .   -")
                    cClientes.rg = mask_rg_clientes.Text;
                else
                    cClientes.rg = "  .   .   -";
                if (txt_numero_clientes.Text != "")
                    cClientes.numero = Convert.ToInt32(txt_numero_clientes.Text);
                else
                    cClientes.numero = 0;
                int aux = cClientes.cadastrar_clientes();

                if (aux != 0)
                {
                    MessageBox.Show(" Cliente: " + cClientes.nome + " cadastrado com sucesso.", "Sistema de agropecuária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bt_cad_clientes_limpar_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro.", "Sistema de agropecuária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nome_clientes.BackColor = Color.DeepPink;
                txt_nome_clientes.Focus();
                txt_cidade_clientes.BackColor = Color.DeepPink;
                txt_cidade_clientes.Focus();
                mask_data_nascimento_clientes.BackColor = Color.DeepPink;
                mask_data_nascimento_clientes.Focus();
                mask_cpf_clientes.BackColor = Color.DeepPink;
                mask_cpf_clientes.Focus();
            }
          

        }
    

private void frm_cad_clientes_Load(object sender, EventArgs e)
        {
            mask_data_cadastro_clientes.Text = DateTime.Now.ToShortDateString();
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_cidade_clientes_TextChanged(object sender, EventArgs e)
        {
        }

        private void bt_cad_clientes_limpar_Click(object sender, EventArgs e)
        {
      
        }

        private void mask_data_nascimento_clientes_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void mask_data_nascimento_clientes_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data inválida.", "Sistema de agropecuária",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
