namespace Manutençao
{
    partial class AdicionarOBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarOBS));
            this.textBox_OBS = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button_Adc = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_OBS
            // 
            this.textBox_OBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OBS.Location = new System.Drawing.Point(106, 64);
            this.textBox_OBS.Multiline = true;
            this.textBox_OBS.Name = "textBox_OBS";
            this.textBox_OBS.Size = new System.Drawing.Size(269, 77);
            this.textBox_OBS.TabIndex = 74;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkRed;
            this.label21.Location = new System.Drawing.Point(7, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 16);
            this.label21.TabIndex = 73;
            this.label21.Text = "Observações:";
            // 
            // button_Adc
            // 
            this.button_Adc.Location = new System.Drawing.Point(275, 172);
            this.button_Adc.Name = "button_Adc";
            this.button_Adc.Size = new System.Drawing.Size(100, 38);
            this.button_Adc.TabIndex = 97;
            this.button_Adc.Text = "Adicionar";
            this.button_Adc.UseVisualStyleBackColor = true;
            this.button_Adc.Click += new System.EventHandler(this.button_Adc_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(16, 187);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 96;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "Observações";
            // 
            // AdicionarOBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Adc);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.textBox_OBS);
            this.Controls.Add(this.label21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdicionarOBS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Observação";
            this.Load += new System.EventHandler(this.AdicionarOBS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_OBS;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button_Adc;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Label label1;
    }
}