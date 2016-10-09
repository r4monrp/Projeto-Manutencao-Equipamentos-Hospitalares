namespace Manutençao
{
    partial class NovoFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoFornecedor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Sair = new System.Windows.Forms.Button();
            this.button_Adc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Contato = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.maskedtextBox_Tel = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(11, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(11, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail:";
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(15, 239);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 4;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // button_Adc
            // 
            this.button_Adc.Location = new System.Drawing.Point(240, 224);
            this.button_Adc.Name = "button_Adc";
            this.button_Adc.Size = new System.Drawing.Size(100, 38);
            this.button_Adc.TabIndex = 5;
            this.button_Adc.Text = "Adicionar";
            this.button_Adc.UseVisualStyleBackColor = true;
            this.button_Adc.Click += new System.EventHandler(this.button_Adc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(122, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Novo Fornecedor";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(80, 60);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(260, 20);
            this.textBox_Nome.TabIndex = 1;
            // 
            // textBox_Contato
            // 
            this.textBox_Contato.Location = new System.Drawing.Point(80, 92);
            this.textBox_Contato.Name = "textBox_Contato";
            this.textBox_Contato.Size = new System.Drawing.Size(260, 20);
            this.textBox_Contato.TabIndex = 2;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(80, 169);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(260, 20);
            this.textBox_Email.TabIndex = 4;
            // 
            // maskedtextBox_Tel
            // 
            this.maskedtextBox_Tel.Location = new System.Drawing.Point(82, 134);
            this.maskedtextBox_Tel.Mask = "(99) 0000-0000";
            this.maskedtextBox_Tel.Name = "maskedtextBox_Tel";
            this.maskedtextBox_Tel.Size = new System.Drawing.Size(89, 20);
            this.maskedtextBox_Tel.TabIndex = 3;
            // 
            // NovoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 274);
            this.Controls.Add(this.maskedtextBox_Tel);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Contato);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Adc);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NovoFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoFornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Button button_Adc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Contato;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.MaskedTextBox maskedtextBox_Tel;
    }
}