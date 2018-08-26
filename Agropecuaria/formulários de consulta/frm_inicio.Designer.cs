namespace Agropecuaria
{
    partial class frm_inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolstrip_cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_cadastro_funcionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_cadastro_produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_cadastro_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_consulta_funcionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_consulta_produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_consulta_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_consulta_vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_cadastro,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolstrip_cadastro
            // 
            this.toolstrip_cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_cadastro_funcionarios,
            this.toolstrip_cadastro_produtos,
            this.toolstrip_cadastro_clientes,
            this.categoriaToolStripMenuItem,
            this.marcaToolStripMenuItem});
            this.toolstrip_cadastro.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_cadastro.Image")));
            this.toolstrip_cadastro.Name = "toolstrip_cadastro";
            this.toolstrip_cadastro.Size = new System.Drawing.Size(119, 29);
            this.toolstrip_cadastro.Text = "Cadastro";
            // 
            // toolstrip_cadastro_funcionarios
            // 
            this.toolstrip_cadastro_funcionarios.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_cadastro_funcionarios.Image")));
            this.toolstrip_cadastro_funcionarios.Name = "toolstrip_cadastro_funcionarios";
            this.toolstrip_cadastro_funcionarios.Size = new System.Drawing.Size(210, 30);
            this.toolstrip_cadastro_funcionarios.Text = "Funcionários ";
            this.toolstrip_cadastro_funcionarios.Click += new System.EventHandler(this.toolstrip_cadastro_funcionarios_Click);
            // 
            // toolstrip_cadastro_produtos
            // 
            this.toolstrip_cadastro_produtos.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_cadastro_produtos.Image")));
            this.toolstrip_cadastro_produtos.Name = "toolstrip_cadastro_produtos";
            this.toolstrip_cadastro_produtos.Size = new System.Drawing.Size(210, 30);
            this.toolstrip_cadastro_produtos.Text = "Produtos";
            this.toolstrip_cadastro_produtos.Click += new System.EventHandler(this.toolstrip_cadastro_produtos_Click);
            // 
            // toolstrip_cadastro_clientes
            // 
            this.toolstrip_cadastro_clientes.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_cadastro_clientes.Image")));
            this.toolstrip_cadastro_clientes.Name = "toolstrip_cadastro_clientes";
            this.toolstrip_cadastro_clientes.Size = new System.Drawing.Size(210, 30);
            this.toolstrip_cadastro_clientes.Text = "Clientes";
            this.toolstrip_cadastro_clientes.Click += new System.EventHandler(this.toolstrip_cadastro_clientes_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaToolStripMenuItem.Image")));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_consulta_funcionarios,
            this.toolstrip_consulta_produtos,
            this.toolstrip_consulta_clientes,
            this.toolstrip_consulta_vendas});
            this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.consultaToolStripMenuItem.Text = "Consulta ";
            // 
            // toolstrip_consulta_funcionarios
            // 
            this.toolstrip_consulta_funcionarios.Name = "toolstrip_consulta_funcionarios";
            this.toolstrip_consulta_funcionarios.Size = new System.Drawing.Size(210, 30);
            this.toolstrip_consulta_funcionarios.Text = "Funcionários";
            this.toolstrip_consulta_funcionarios.Click += new System.EventHandler(this.toolstrip_consulta_funcionarios_Click);
            // 
            // toolstrip_consulta_produtos
            // 
            this.toolstrip_consulta_produtos.Name = "toolstrip_consulta_produtos";
            this.toolstrip_consulta_produtos.Size = new System.Drawing.Size(210, 30);
            this.toolstrip_consulta_produtos.Text = "Produtos ";
            this.toolstrip_consulta_produtos.Click += new System.EventHandler(this.toolstrip_consulta_produtos_Click);
            // 
            // toolstrip_consulta_clientes
            // 
            this.toolstrip_consulta_clientes.Name = "toolstrip_consulta_clientes";
            this.toolstrip_consulta_clientes.Size = new System.Drawing.Size(210, 30);
            this.toolstrip_consulta_clientes.Text = "Clientes ";
            this.toolstrip_consulta_clientes.Click += new System.EventHandler(this.toolstrip_consulta_clientes_Click);
            // 
            // toolstrip_consulta_vendas
            // 
            this.toolstrip_consulta_vendas.Name = "toolstrip_consulta_vendas";
            this.toolstrip_consulta_vendas.Size = new System.Drawing.Size(210, 30);
            this.toolstrip_consulta_vendas.Text = "Vendas ";
            this.toolstrip_consulta_vendas.Click += new System.EventHandler(this.toolstrip_consulta_vendas_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 621);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frm_inicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_cadastro;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_cadastro_funcionarios;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_cadastro_produtos;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_cadastro_clientes;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_consulta_funcionarios;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_consulta_produtos;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_consulta_clientes;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_consulta_vendas;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
    }
}

