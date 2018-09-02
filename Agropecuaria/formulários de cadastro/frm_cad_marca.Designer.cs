namespace Agropecuaria
{
    partial class frm_cad_marca
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
            this.bt_cad_marca_limpar = new System.Windows.Forms.Button();
            this.mask_data_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_cod_marca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome_marca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cad_marca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_cad_marca_limpar
            // 
            this.bt_cad_marca_limpar.Location = new System.Drawing.Point(177, 161);
            this.bt_cad_marca_limpar.Name = "bt_cad_marca_limpar";
            this.bt_cad_marca_limpar.Size = new System.Drawing.Size(122, 92);
            this.bt_cad_marca_limpar.TabIndex = 40;
            this.bt_cad_marca_limpar.Text = "Limpar";
            this.bt_cad_marca_limpar.UseVisualStyleBackColor = true;
            this.bt_cad_marca_limpar.Click += new System.EventHandler(this.bt_cad_marca_limpar_Click);
            // 
            // mask_data_cadastro
            // 
            this.mask_data_cadastro.Location = new System.Drawing.Point(168, 112);
            this.mask_data_cadastro.Mask = "00/00/0000";
            this.mask_data_cadastro.Name = "mask_data_cadastro";
            this.mask_data_cadastro.Size = new System.Drawing.Size(93, 26);
            this.mask_data_cadastro.TabIndex = 39;
            this.mask_data_cadastro.ValidatingType = typeof(System.DateTime);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(20, 161);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 92);
            this.bt_cancelar.TabIndex = 38;
            this.bt_cancelar.Text = "Cancelar ";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(367, 73);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(100, 26);
            this.txt_status.TabIndex = 37;
            // 
            // txt_cod_marca
            // 
            this.txt_cod_marca.Location = new System.Drawing.Point(177, 73);
            this.txt_cod_marca.Name = "txt_cod_marca";
            this.txt_cod_marca.Size = new System.Drawing.Size(100, 26);
            this.txt_cod_marca.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data do cadastro ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Codigo da Marca ";
            // 
            // txt_nome_marca
            // 
            this.txt_nome_marca.Location = new System.Drawing.Point(168, 32);
            this.txt_nome_marca.Name = "txt_nome_marca";
            this.txt_nome_marca.Size = new System.Drawing.Size(169, 26);
            this.txt_nome_marca.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome da Marca";
            // 
            // bt_cad_marca
            // 
            this.bt_cad_marca.Location = new System.Drawing.Point(345, 161);
            this.bt_cad_marca.Name = "bt_cad_marca";
            this.bt_cad_marca.Size = new System.Drawing.Size(122, 92);
            this.bt_cad_marca.TabIndex = 30;
            this.bt_cad_marca.Text = "Cadastrar";
            this.bt_cad_marca.UseVisualStyleBackColor = true;
            this.bt_cad_marca.Click += new System.EventHandler(this.bt_cad_marca_Click);
            // 
            // frm_cad_marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 282);
            this.Controls.Add(this.bt_cad_marca_limpar);
            this.Controls.Add(this.mask_data_cadastro);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_cod_marca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome_marca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cad_marca);
            this.Name = "frm_cad_marca";
            this.Text = "frm_cad_marca";
            this.Load += new System.EventHandler(this.frm_cad_marca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cad_marca_limpar;
        private System.Windows.Forms.MaskedTextBox mask_data_cadastro;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_cod_marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome_marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cad_marca;
    }
}