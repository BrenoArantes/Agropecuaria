namespace Agropecuaria
{
    partial class frm_cad_produtos
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
            this.txt_nome_produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_marca_produto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_valor_produto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_data_produto = new System.Windows.Forms.TextBox();
            this.bt_cad_produtos_cadastrar = new System.Windows.Forms.Button();
            this.bt_cad_produtos_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_nome_produto
            // 
            this.txt_nome_produto.Location = new System.Drawing.Point(167, 11);
            this.txt_nome_produto.Name = "txt_nome_produto";
            this.txt_nome_produto.Size = new System.Drawing.Size(233, 26);
            this.txt_nome_produto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca do produto: ";
            // 
            // txt_marca_produto
            // 
            this.txt_marca_produto.Location = new System.Drawing.Point(167, 82);
            this.txt_marca_produto.Name = "txt_marca_produto";
            this.txt_marca_produto.Size = new System.Drawing.Size(233, 26);
            this.txt_marca_produto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor do produto :  ";
            // 
            // txt_valor_produto
            // 
            this.txt_valor_produto.Location = new System.Drawing.Point(167, 155);
            this.txt_valor_produto.Name = "txt_valor_produto";
            this.txt_valor_produto.Size = new System.Drawing.Size(233, 26);
            this.txt_valor_produto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data do cadastro : ";
            // 
            // txt_data_produto
            // 
            this.txt_data_produto.Location = new System.Drawing.Point(167, 232);
            this.txt_data_produto.Name = "txt_data_produto";
            this.txt_data_produto.Size = new System.Drawing.Size(233, 26);
            this.txt_data_produto.TabIndex = 7;
            // 
            // bt_cad_produtos_cadastrar
            // 
            this.bt_cad_produtos_cadastrar.Location = new System.Drawing.Point(237, 308);
            this.bt_cad_produtos_cadastrar.Name = "bt_cad_produtos_cadastrar";
            this.bt_cad_produtos_cadastrar.Size = new System.Drawing.Size(122, 92);
            this.bt_cad_produtos_cadastrar.TabIndex = 8;
            this.bt_cad_produtos_cadastrar.Text = "Cadastrar";
            this.bt_cad_produtos_cadastrar.UseVisualStyleBackColor = true;
            // 
            // bt_cad_produtos_cancelar
            // 
            this.bt_cad_produtos_cancelar.Location = new System.Drawing.Point(60, 308);
            this.bt_cad_produtos_cancelar.Name = "bt_cad_produtos_cancelar";
            this.bt_cad_produtos_cancelar.Size = new System.Drawing.Size(122, 92);
            this.bt_cad_produtos_cancelar.TabIndex = 9;
            this.bt_cad_produtos_cancelar.Text = "cancelar";
            this.bt_cad_produtos_cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_cad_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 412);
            this.Controls.Add(this.bt_cad_produtos_cancelar);
            this.Controls.Add(this.bt_cad_produtos_cadastrar);
            this.Controls.Add(this.txt_data_produto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_valor_produto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_marca_produto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome_produto);
            this.Controls.Add(this.label1);
            this.Name = "frm_cad_produtos";
            this.Text = "cad_produtos";
            this.Load += new System.EventHandler(this.frm_cad_produtos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_marca_produto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_valor_produto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_data_produto;
        private System.Windows.Forms.Button bt_cad_produtos_cadastrar;
        private System.Windows.Forms.Button bt_cad_produtos_cancelar;
    }
}