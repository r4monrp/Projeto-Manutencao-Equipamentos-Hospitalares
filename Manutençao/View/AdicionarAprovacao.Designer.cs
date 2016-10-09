namespace Manutençao
{
    partial class AdicionarAprovacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarAprovacao));
            this.maskedTextBox_DataAp = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AdcAprv = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox_DataAp
            // 
            this.maskedTextBox_DataAp.Location = new System.Drawing.Point(128, 53);
            this.maskedTextBox_DataAp.Mask = "00/00/0000";
            this.maskedTextBox_DataAp.Name = "maskedTextBox_DataAp";
            this.maskedTextBox_DataAp.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBox_DataAp.TabIndex = 66;
            this.maskedTextBox_DataAp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_DataAp.ValidatingType = typeof(System.DateTime);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(12, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 16);
            this.label17.TabIndex = 67;
            this.label17.Text = "Data Aprovação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Aprovação Gestor";
            // 
            // button_AdcAprv
            // 
            this.button_AdcAprv.Location = new System.Drawing.Point(197, 84);
            this.button_AdcAprv.Name = "button_AdcAprv";
            this.button_AdcAprv.Size = new System.Drawing.Size(100, 38);
            this.button_AdcAprv.TabIndex = 93;
            this.button_AdcAprv.Text = "Adicionar";
            this.button_AdcAprv.UseVisualStyleBackColor = true;
            this.button_AdcAprv.Click += new System.EventHandler(this.button_AdcAprv_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(15, 100);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 92;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // AdicionarAprovacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 134);
            this.Controls.Add(this.button_AdcAprv);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.maskedTextBox_DataAp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdicionarAprovacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Aprovacão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataAp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AdcAprv;
        private System.Windows.Forms.Button button_Sair;
    }
}