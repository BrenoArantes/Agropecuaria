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
    public partial class frm_cad_funcionarios : Form
    {
        public frm_cad_funcionarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_cad_clientes_cancelar_Click(object sender, EventArgs e)
        {
            

        }

        private void bt_cad_clientes_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_cpf_clientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_endereco_clientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_nome_clientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_cad_funcionarios_Load(object sender, EventArgs e)
        {
            mask_data_cadastro_funcionarios.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            classe_funcionarios cfunc = new classe_funcionarios();

            if (txt_nome_funcionarios.Text != "" && txt_cidade_funcionarios.Text != "" && mask_data_nascimento_funcionarios.Text != "" && mask_cpf_funcionarios.Text != "")
            {
                cfunc.nome = txt_nome_funcionarios.Text;
                cfunc.rua = txt_rua_funcionarios.Text;
                cfunc.bairro = txt_bairro_funcionarios.Text;
                cfunc.cidade = txt_cidade_funcionarios.Text;
                cfunc.cpf = mask_cpf_funcionarios.Text;
                cfunc.numero_casa = Convert.ToInt32( txt_numero_funcionarios.Text);
                cfunc.data_nascimento = Convert.ToDateTime(mask_data_nascimento_funcionarios.Text);
                cfunc.login_funcionario = txt_login_funcionarios.Text;
                cfunc.senha_funcionario = txt_senha_funcionarios.Text;


                if (rd_btm_feminino.Checked)
                    cfunc.sexo = 0;
                else
                    cfunc.sexo = 1;

                if (mask_telefone_funcionarios.Text != "(  )     -    ")
                    cfunc.tel_celular = mask_telefone_funcionarios .Text;
                else
                    cfunc.tel_celular = "";
                if (mask_celular_funcionarios.Text != "(  )     -    ")
                    cfunc.tel_celular2 = mask_telefone_funcionarios.Text;
                else
                    cfunc.tel_celular2 = "";
                if (mask_rg_funcionarios.Text != "  .   .   -")
                    cfunc.rg = mask_rg_funcionarios.Text;
                else
                    cfunc.rg = "  .   .   -";
                if (txt_numero_funcionarios.Text != "")
                    cfunc.numero_casa = Convert.ToInt32(txt_numero_funcionarios.Text);
                else
                    cfunc.numero_casa = 0;
                if (txt_login_funcionarios.Text != "")
                    cfunc.login_funcionario = txt_login_funcionarios.Text;
                else
                    cfunc.login_funcionario = "";
                if (txt_senha_funcionarios.Text != "")
                    cfunc.senha_funcionario = txt_senha_funcionarios.Text;
                else
                    cfunc.senha_funcionario = "";
                if (txt_funcao_funcionarios.Text != "")
                    cfunc.funcao = txt_funcao_funcionarios.Text;
                int aux = cfunc.cadastrar_funcionarios();

                if (aux != 0)
                {
                    MessageBox.Show(" Funcionário: " + cfunc.nome + " cadastrado com sucesso.", "Sistema de agropecuária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bt_cad_func_limpar_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro.", "Sistema de agropecuária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nome_funcionarios.BackColor = Color.DeepPink;
                txt_nome_funcionarios.Focus();
                txt_cidade_funcionarios.BackColor = Color.DeepPink;
                txt_cidade_funcionarios.Focus();
                mask_data_nascimento_funcionarios.BackColor = Color.DeepPink;
                mask_data_nascimento_funcionarios.Focus();
                mask_cpf_funcionarios.BackColor = Color.DeepPink;
                mask_cpf_funcionarios.Focus();
                txt_funcao_funcionarios.BackColor = Color.DeepPink;
                txt_funcao_funcionarios.Focus();
            }


        }

        private void bt_cad_func_limpar_Click(object sender, EventArgs e)
        {

        }

        private void mask_data_nascimento_funcionarios_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        private void mask_data_nascimento_funcionarios_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data inválida. ", "Sistema de Agropecuária",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
