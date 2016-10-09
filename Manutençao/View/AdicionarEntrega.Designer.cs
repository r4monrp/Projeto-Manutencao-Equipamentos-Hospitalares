namespace Manutençao
{
    partial class AdicionarEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarEntrega));
            this.maskedTextBox_EntrData = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.button_AdcEntrega = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBox_EntrData
            // 
            this.maskedTextBox_EntrData.Location = new System.Drawing.Point(114, 64);
            this.maskedTextBox_EntrData.Mask = "00/00/0000";
            this.maskedTextBox_EntrData.Name = "maskedTextBox_EntrData";
            this.maskedTextBox_EntrData.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBox_EntrData.TabIndex = 91;
            this.maskedTextBox_EntrData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_EntrData.ValidatingType = typeof(System.DateTime);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DarkRed;
            this.label25.Location = new System.Drawing.Point(12, 68);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 16);
            this.label25.TabIndex = 90;
            this.label25.Text = "Entregue Data:";
            // 
            // button_AdcEntrega
            // 
            this.button_AdcEntrega.Location = new System.Drawing.Point(234, 106);
            this.button_AdcEntrega.Name = "button_AdcEntrega";
            this.button_AdcEntrega.Size = new System.Drawing.Size(100, 38);
            this.button_AdcEntrega.TabIndex = 95;
            this.button_AdcEntrega.Text = "Adicionar";
            this.button_AdcEntrega.UseVisualStyleBackColor = true;
            this.button_AdcEntrega.Click += new System.EventHandler(this.button_AdcEntrega_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(20, 121);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 94;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 96;
            this.label1.Text = "Entrega de Equipamento";
            // 
            // AdicionarEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AdcEntrega);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.maskedTextBox_EntrData);
            this.Controls.Add(this.label25);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdicionarEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Entrega";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_EntrData;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button_AdcEntrega;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Label label1;
    }
}