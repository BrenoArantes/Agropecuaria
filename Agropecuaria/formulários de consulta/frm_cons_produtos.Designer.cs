namespace Agropecuaria
{
    partial class frm_cons_produtos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rd_btm_inicio = new System.Windows.Forms.RadioButton();
            this.rd_btm_contem = new System.Windows.Forms.RadioButton();
            this.rd_btm_ativo = new System.Windows.Forms.RadioButton();
            this.rd_btm_inativo = new System.Windows.Forms.RadioButton();
            this.cb_opcoes = new System.Windows.Forms.ComboBox();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.bt_pesq = new System.Windows.Forms.Button();
            this.dvg_produto = new System.Windows.Forms.DataGridView();
            this.gb_valores = new System.Windows.Forms.GroupBox();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.gb_tipo_pesquisa = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_produto)).BeginInit();
            this.gb_valores.SuspendLayout();
            this.gb_status.SuspendLayout();
            this.gb_tipo_pesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione um tipo de consulta : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço inicial :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço final :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Marca :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Categoria";
            // 
            // rd_btm_inicio
            // 
            this.rd_btm_inicio.AutoSize = true;
            this.rd_btm_inicio.Location = new System.Drawing.Point(4, 27);
            this.rd_btm_inicio.Name = "rd_btm_inicio";
            this.rd_btm_inicio.Size = new System.Drawing.Size(71, 24);
            this.rd_btm_inicio.TabIndex = 8;
            this.rd_btm_inicio.TabStop = true;
            this.rd_btm_inicio.Text = "Início";
            this.rd_btm_inicio.UseVisualStyleBackColor = true;
            // 
            // rd_btm_contem
            // 
            this.rd_btm_contem.AutoSize = true;
            this.rd_btm_contem.Location = new System.Drawing.Point(78, 29);
            this.rd_btm_contem.Name = "rd_btm_contem";
            this.rd_btm_contem.Size = new System.Drawing.Size(90, 24);
            this.rd_btm_contem.TabIndex = 9;
            this.rd_btm_contem.TabStop = true;
            this.rd_btm_contem.Text = "Contém";
            this.rd_btm_contem.UseVisualStyleBackColor = true;
            // 
            // rd_btm_ativo
            // 
            this.rd_btm_ativo.AutoSize = true;
            this.rd_btm_ativo.Location = new System.Drawing.Point(6, 30);
            this.rd_btm_ativo.Name = "rd_btm_ativo";
            this.rd_btm_ativo.Size = new System.Drawing.Size(69, 24);
            this.rd_btm_ativo.TabIndex = 10;
            this.rd_btm_ativo.TabStop = true;
            this.rd_btm_ativo.Text = "Ativo";
            this.rd_btm_ativo.UseVisualStyleBackColor = true;
            // 
            // rd_btm_inativo
            // 
            this.rd_btm_inativo.AutoSize = true;
            this.rd_btm_inativo.Location = new System.Drawing.Point(78, 30);
            this.rd_btm_inativo.Name = "rd_btm_inativo";
            this.rd_btm_inativo.Size = new System.Drawing.Size(81, 24);
            this.rd_btm_inativo.TabIndex = 11;
            this.rd_btm_inativo.TabStop = true;
            this.rd_btm_inativo.Text = "Inativo";
            this.rd_btm_inativo.UseVisualStyleBackColor = true;
            // 
            // cb_opcoes
            // 
            this.cb_opcoes.FormattingEnabled = true;
            this.cb_opcoes.Location = new System.Drawing.Point(16, 50);
            this.cb_opcoes.Name = "cb_opcoes";
            this.cb_opcoes.Size = new System.Drawing.Size(162, 28);
            this.cb_opcoes.TabIndex = 12;
            this.cb_opcoes.SelectedIndexChanged += new System.EventHandler(this.cb_opcoes_SelectedIndexChanged);
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(184, 52);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(299, 26);
            this.txt_pesquisar.TabIndex = 13;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 26);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(351, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 26);
            this.textBox3.TabIndex = 15;
            // 
            // cb_marca
            // 
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(79, 162);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(162, 28);
            this.cb_marca.TabIndex = 16;
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(362, 162);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(162, 28);
            this.cb_categoria.TabIndex = 17;
            // 
            // bt_pesq
            // 
            this.bt_pesq.Location = new System.Drawing.Point(539, 155);
            this.bt_pesq.Name = "bt_pesq";
            this.bt_pesq.Size = new System.Drawing.Size(119, 41);
            this.bt_pesq.TabIndex = 18;
            this.bt_pesq.Text = "Pesquisar :";
            this.bt_pesq.UseVisualStyleBackColor = true;
            this.bt_pesq.Click += new System.EventHandler(this.bt_pesq_Click);
            // 
            // dvg_produto
            // 
            this.dvg_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_produto.Location = new System.Drawing.Point(12, 202);
            this.dvg_produto.Name = "dvg_produto";
            this.dvg_produto.RowTemplate.Height = 28;
            this.dvg_produto.Size = new System.Drawing.Size(679, 383);
            this.dvg_produto.TabIndex = 19;
            this.dvg_produto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gb_valores
            // 
            this.gb_valores.Controls.Add(this.textBox2);
            this.gb_valores.Controls.Add(this.label4);
            this.gb_valores.Controls.Add(this.label5);
            this.gb_valores.Controls.Add(this.textBox3);
            this.gb_valores.Location = new System.Drawing.Point(16, 84);
            this.gb_valores.Name = "gb_valores";
            this.gb_valores.Size = new System.Drawing.Size(467, 65);
            this.gb_valores.TabIndex = 20;
            this.gb_valores.TabStop = false;
            this.gb_valores.Text = "Valores :";
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.rd_btm_inativo);
            this.gb_status.Controls.Add(this.rd_btm_ativo);
            this.gb_status.Location = new System.Drawing.Point(516, 84);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(175, 67);
            this.gb_status.TabIndex = 21;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status";
            // 
            // gb_tipo_pesquisa
            // 
            this.gb_tipo_pesquisa.Controls.Add(this.rd_btm_inicio);
            this.gb_tipo_pesquisa.Controls.Add(this.rd_btm_contem);
            this.gb_tipo_pesquisa.Location = new System.Drawing.Point(516, 19);
            this.gb_tipo_pesquisa.Name = "gb_tipo_pesquisa";
            this.gb_tipo_pesquisa.Size = new System.Drawing.Size(174, 59);
            this.gb_tipo_pesquisa.TabIndex = 22;
            this.gb_tipo_pesquisa.TabStop = false;
            this.gb_tipo_pesquisa.Text = "Tipo de pesquisa";
            // 
            // frm_cons_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 601);
            this.Controls.Add(this.gb_tipo_pesquisa);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.gb_valores);
            this.Controls.Add(this.dvg_produto);
            this.Controls.Add(this.bt_pesq);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.cb_opcoes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "frm_cons_produtos";
            this.Text = "frm_cons_produtos";
            this.Load += new System.EventHandler(this.frm_cons_produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_produto)).EndInit();
            this.gb_valores.ResumeLayout(false);
            this.gb_valores.PerformLayout();
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.gb_tipo_pesquisa.ResumeLayout(false);
            this.gb_tipo_pesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rd_btm_inicio;
        private System.Windows.Forms.RadioButton rd_btm_contem;
        private System.Windows.Forms.RadioButton rd_btm_ativo;
        private System.Windows.Forms.RadioButton rd_btm_inativo;
        private System.Windows.Forms.ComboBox cb_opcoes;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Button bt_pesq;
        private System.Windows.Forms.DataGridView dvg_produto;
        private System.Windows.Forms.GroupBox gb_valores;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.GroupBox gb_tipo_pesquisa;
    }
}