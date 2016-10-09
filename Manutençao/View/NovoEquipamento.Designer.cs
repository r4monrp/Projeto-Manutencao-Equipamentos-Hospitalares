namespace Manutençao
{
    partial class NovoEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoEquipamento));
            this.textBox_Desc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Adc = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Desc
            // 
            this.textBox_Desc.Location = new System.Drawing.Point(94, 60);
            this.textBox_Desc.Name = "textBox_Desc";
            this.textBox_Desc.Size = new System.Drawing.Size(249, 20);
            this.textBox_Desc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(125, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Novo Equipamento";
            // 
            // button_Adc
            // 
            this.button_Adc.Location = new System.Drawing.Point(243, 103);
            this.button_Adc.Name = "button_Adc";
            this.button_Adc.Size = new System.Drawing.Size(100, 38);
            this.button_Adc.TabIndex = 2;
            this.button_Adc.Text = "Adicionar";
            this.button_Adc.UseVisualStyleBackColor = true;
            this.button_Adc.Click += new System.EventHandler(this.button_Adc_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(18, 118);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 15;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descrição:";
            // 
            // NovoEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 156);
            this.Controls.Add(this.textBox_Desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Adc);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NovoEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Equipamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Adc;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Label label1;
    }
}