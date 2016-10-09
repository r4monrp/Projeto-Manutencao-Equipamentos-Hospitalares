namespace Manutençao
{
    partial class ExibirEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExibirEquipamento));
            this.textBox_Desc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Salvar = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Desc
            // 
            this.textBox_Desc.Location = new System.Drawing.Point(92, 60);
            this.textBox_Desc.Name = "textBox_Desc";
            this.textBox_Desc.Size = new System.Drawing.Size(249, 20);
            this.textBox_Desc.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(142, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Equipamento";
            // 
            // button_Salvar
            // 
            this.button_Salvar.Location = new System.Drawing.Point(241, 103);
            this.button_Salvar.Name = "button_Salvar";
            this.button_Salvar.Size = new System.Drawing.Size(100, 38);
            this.button_Salvar.TabIndex = 19;
            this.button_Salvar.Text = "Salvar";
            this.button_Salvar.UseVisualStyleBackColor = true;
            this.button_Salvar.Click += new System.EventHandler(this.button_Salvar_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(16, 118);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 21;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descrição:";
            // 
            // ExibirEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 161);
            this.Controls.Add(this.textBox_Desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Salvar);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExibirEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Salvar;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Label label1;
    }
}