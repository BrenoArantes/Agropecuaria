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
    public partial class frm_inicio : Form
    {
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button_Produtos_Click(object sender, EventArgs e)
        {
        }

        private void button_Vendas_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void toolstrip_cadastro_produtos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cad_produtos>().Count() > 0)
            {
                MessageBox.Show("O Formulário já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_cad_produtos form_cad_produtos = new frm_cad_produtos();
                form_cad_produtos.MdiParent = this;
                form_cad_produtos.Show();
            }
        }

        private void toolstrip_cadastro_clientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cad_clientes>().Count() > 0)
            {
                MessageBox.Show("O Formulário já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_cad_clientes form_cad_clientes = new frm_cad_clientes();
                form_cad_clientes.MdiParent = this;
                form_cad_clientes.Show();
            }
        }

        private void toolstrip_cadastro_funcionarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cad_funcionarios>().Count() > 0)
            {
                MessageBox.Show("O Formulário já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_cad_funcionarios form_cad_funcionarios = new frm_cad_funcionarios();
                form_cad_funcionarios.MdiParent = this;
                form_cad_funcionarios.Show();
            }
        }

        private void toolstrip_consulta_funcionarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cons_funcionarios>().Count() > 0)
            {
                MessageBox.Show("O Formulário já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_cons_funcionarios form_cons_funcionarios = new frm_cons_funcionarios();
                form_cons_funcionarios.MdiParent = this;
                form_cons_funcionarios.Show();
            }
        }

        private void toolstrip_consulta_produtos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cons_produtos>().Count() > 0)
            {
                MessageBox.Show("O Formulário já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_cons_produtos form_cons_produtos = new frm_cons_produtos();
                form_cons_produtos.MdiParent = this;
                form_cons_produtos.Show();
            }
        }

        private void toolstrip_consulta_clientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cons_clientes>().Count() > 0)
            {
                MessageBox.Show("O Formulário já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_cons_clientes form_cons_clientes = new frm_cons_clientes();
                form_cons_clientes.MdiParent = this;
                form_cons_clientes.Show();
            }
        }

        private void toolstrip_consulta_vendas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cons_vendas>().Count() > 0)
            {
                MessageBox.Show("O Formulário já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_cons_vendas form_cons_vendas = new frm_cons_vendas();
                form_cons_vendas.MdiParent = this;
                form_cons_vendas.Show();
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cad_categoria>().Count() > 0)
            {
                MessageBox.Show("O Formulário já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_cad_categoria form_cad_categoria = new frm_cad_categoria();
                form_cad_categoria.MdiParent = this;
                form_cad_categoria.Show();
            }
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_cad_marca>().Count() > 0)
            {
                MessageBox.Show("O Formulário já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                form_cad_marca form_cad_marca = new form_cad_marca();
                form_cad_marca.MdiParent = this;
                form_cad_marca.Show();
            }
        }
    }
}
