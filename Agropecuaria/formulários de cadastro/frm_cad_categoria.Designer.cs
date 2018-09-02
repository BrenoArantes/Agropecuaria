namespace Agropecuaria
{
    partial class frm_cad_categoria
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
            this.bt_cad_categoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome_categoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cod_categoria = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.mask_data_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.bt_cad_categoria_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_cad_categoria
            // 
            this.bt_cad_categoria.Location = new System.Drawing.Point(351, 151);
            this.bt_cad_categoria.Name = "bt_cad_categoria";
            this.bt_cad_categoria.Size = new System.Drawing.Size(122, 92);
            this.bt_cad_categoria.TabIndex = 19;
            this.bt_cad_categoria.Text = "Cadastrar";
            this.bt_cad_categoria.UseVisualStyleBackColor = true;
            this.bt_cad_categoria.Click += new System.EventHandler(this.bt_cad_clientes_cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome da Categoria";
            // 
            // txt_nome_categoria
            // 
            this.txt_nome_categoria.Location = new System.Drawing.Point(174, 22);
            this.txt_nome_categoria.Name = "txt_nome_categoria";
            this.txt_nome_categoria.Size = new System.Drawing.Size(169, 26);
            this.txt_nome_categoria.TabIndex = 21;
            this.txt_nome_categoria.TextChanged += new System.EventHandler(this.txt_nome_categoria_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Codigo da categoria ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data do cadastro ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Status";
            // 
            // txt_cod_categoria
            // 
            this.txt_cod_categoria.Location = new System.Drawing.Point(183, 63);
            this.txt_cod_categoria.Name = "txt_cod_categoria";
            this.txt_cod_categoria.Size = new System.Drawing.Size(100, 26);
            this.txt_cod_categoria.TabIndex = 25;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(373, 63);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(100, 26);
            this.txt_status.TabIndex = 26;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(26, 151);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 92);
            this.bt_cancelar.TabIndex = 27;
            this.bt_cancelar.Text = "Cancelar ";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // mask_data_cadastro
            // 
            this.mask_data_cadastro.Location = new System.Drawing.Point(174, 102);
            this.mask_data_cadastro.Mask = "00/00/0000";
            this.mask_data_cadastro.Name = "mask_data_cadastro";
            this.mask_data_cadastro.Size = new System.Drawing.Size(93, 26);
            this.mask_data_cadastro.TabIndex = 28;
            this.mask_data_cadastro.ValidatingType = typeof(System.DateTime);
            this.mask_data_cadastro.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // bt_cad_categoria_limpar
            // 
            this.bt_cad_categoria_limpar.Location = new System.Drawing.Point(183, 151);
            this.bt_cad_categoria_limpar.Name = "bt_cad_categoria_limpar";
            this.bt_cad_categoria_limpar.Size = new System.Drawing.Size(122, 92);
            this.bt_cad_categoria_limpar.TabIndex = 29;
            this.bt_cad_categoria_limpar.Text = "Limpar";
            this.bt_cad_categoria_limpar.UseVisualStyleBackColor = true;
            this.bt_cad_categoria_limpar.Click += new System.EventHandler(this.bt_cad_categoria_limpar_Click);
            // 
            // frm_cad_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 260);
            this.Controls.Add(this.bt_cad_categoria_limpar);
            this.Controls.Add(this.mask_data_cadastro);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_cod_categoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome_categoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cad_categoria);
            this.Name = "frm_cad_categoria";
            this.Text = "frm_cad_categoria";
            this.Load += new System.EventHandler(this.frm_cad_categoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cad_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome_categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cod_categoria;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.MaskedTextBox mask_data_cadastro;
        private System.Windows.Forms.Button bt_cad_categoria_limpar;
    }
}