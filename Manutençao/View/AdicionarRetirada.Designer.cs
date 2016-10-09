namespace Manutençao
{
    partial class AdicionarRetirada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarRetirada));
            this.maskedTextBox_DataRet = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button_AdcRet = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBox_DataRet
            // 
            this.maskedTextBox_DataRet.Location = new System.Drawing.Point(113, 65);
            this.maskedTextBox_DataRet.Mask = "00/00/0000";
            this.maskedTextBox_DataRet.Name = "maskedTextBox_DataRet";
            this.maskedTextBox_DataRet.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBox_DataRet.TabIndex = 85;
            this.maskedTextBox_DataRet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_DataRet.ValidatingType = typeof(System.DateTime);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(12, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 16);
            this.label19.TabIndex = 84;
            this.label19.Text = "Data Retirada:";
            // 
            // button_AdcRet
            // 
            this.button_AdcRet.Location = new System.Drawing.Point(220, 111);
            this.button_AdcRet.Name = "button_AdcRet";
            this.button_AdcRet.Size = new System.Drawing.Size(100, 38);
            this.button_AdcRet.TabIndex = 93;
            this.button_AdcRet.Text = "Adicionar";
            this.button_AdcRet.UseVisualStyleBackColor = true;
            this.button_AdcRet.Click += new System.EventHandler(this.button_AdcRet_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(6, 126);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 92;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 94;
            this.label1.Text = "Retirada Fornecedor";
            // 
            // AdicionarRetirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AdcRet);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.maskedTextBox_DataRet);
            this.Controls.Add(this.label19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdicionarRetirada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Retirada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataRet;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button_AdcRet;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Label label1;
    }
}