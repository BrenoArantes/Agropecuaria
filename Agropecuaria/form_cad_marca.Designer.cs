namespace Agropecuaria
{
    partial class form_cad_marca
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
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.txt_data_cadastro = new System.Windows.Forms.TextBox();
            this.txt_cod_marca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome_marca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cad_marca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(31, 275);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 92);
            this.bt_cancelar.TabIndex = 36;
            this.bt_cancelar.Text = "Cancelar ";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_data_cadastro
            // 
            this.txt_data_cadastro.Location = new System.Drawing.Point(195, 146);
            this.txt_data_cadastro.Name = "txt_data_cadastro";
            this.txt_data_cadastro.Size = new System.Drawing.Size(100, 26);
            this.txt_data_cadastro.TabIndex = 35;
            // 
            // txt_cod_marca
            // 
            this.txt_cod_marca.Location = new System.Drawing.Point(195, 86);
            this.txt_cod_marca.Name = "txt_cod_marca";
            this.txt_cod_marca.Size = new System.Drawing.Size(100, 26);
            this.txt_cod_marca.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Data do cadastro ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Codigo da marca :";
            // 
            // txt_nome_marca
            // 
            this.txt_nome_marca.Location = new System.Drawing.Point(195, 25);
            this.txt_nome_marca.Name = "txt_nome_marca";
            this.txt_nome_marca.Size = new System.Drawing.Size(100, 26);
            this.txt_nome_marca.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nome da Marca :";
            // 
            // bt_cad_marca
            // 
            this.bt_cad_marca.Location = new System.Drawing.Point(173, 275);
            this.bt_cad_marca.Name = "bt_cad_marca";
            this.bt_cad_marca.Size = new System.Drawing.Size(122, 92);
            this.bt_cad_marca.TabIndex = 28;
            this.bt_cad_marca.Text = "Cadastrar";
            this.bt_cad_marca.UseVisualStyleBackColor = true;
            // 
            // form_cad_marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 390);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.txt_data_cadastro);
            this.Controls.Add(this.txt_cod_marca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome_marca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cad_marca);
            this.Name = "form_cad_marca";
            this.Text = "form_cad_marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TextBox txt_data_cadastro;
        private System.Windows.Forms.TextBox txt_cod_marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome_marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cad_marca;
    }
}