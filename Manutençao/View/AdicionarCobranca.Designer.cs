namespace Manutençao
{
    partial class AdicionarCobranca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarCobranca));
            this.label23 = new System.Windows.Forms.Label();
            this.maskedTextBox_DataC = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Adc = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.comboBox_ViaC = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DarkRed;
            this.label23.Location = new System.Drawing.Point(203, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 16);
            this.label23.TabIndex = 90;
            this.label23.Text = "Via:";
            // 
            // maskedTextBox_DataC
            // 
            this.maskedTextBox_DataC.Location = new System.Drawing.Point(120, 68);
            this.maskedTextBox_DataC.Mask = "00/00/0000";
            this.maskedTextBox_DataC.Name = "maskedTextBox_DataC";
            this.maskedTextBox_DataC.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBox_DataC.TabIndex = 1;
            this.maskedTextBox_DataC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_DataC.ValidatingType = typeof(System.DateTime);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkRed;
            this.label22.Location = new System.Drawing.Point(12, 73);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 16);
            this.label22.TabIndex = 88;
            this.label22.Text = "Data Cobrança:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 92;
            this.label1.Text = "Cobrança";
            // 
            // button_Adc
            // 
            this.button_Adc.Location = new System.Drawing.Point(270, 114);
            this.button_Adc.Name = "button_Adc";
            this.button_Adc.Size = new System.Drawing.Size(100, 38);
            this.button_Adc.TabIndex = 3;
            this.button_Adc.Text = "Adicionar";
            this.button_Adc.UseVisualStyleBackColor = true;
            this.button_Adc.Click += new System.EventHandler(this.button_Adc_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(11, 129);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 4;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // comboBox_ViaC
            // 
            this.comboBox_ViaC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ViaC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_ViaC.FormattingEnabled = true;
            this.comboBox_ViaC.Items.AddRange(new object[] {
            "E-mail",
            "Telefone",
            "Pessoalmente",
            "Outros"});
            this.comboBox_ViaC.Location = new System.Drawing.Point(240, 67);
            this.comboBox_ViaC.Name = "comboBox_ViaC";
            this.comboBox_ViaC.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ViaC.TabIndex = 2;
            // 
            // AdicionarCobranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 164);
            this.Controls.Add(this.comboBox_ViaC);
            this.Controls.Add(this.button_Adc);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.maskedTextBox_DataC);
            this.Controls.Add(this.label22);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdicionarCobranca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Cobranca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataC;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Adc;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.ComboBox comboBox_ViaC;
    }
}