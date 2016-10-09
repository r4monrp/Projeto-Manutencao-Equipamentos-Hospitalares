namespace Manutençao
{
    partial class AdicionarReq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarReq));
            this.button_Adc = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.maskedTextBox_Datareq = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox_ReqMO = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_ReqP = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Adc
            // 
            this.button_Adc.Location = new System.Drawing.Point(271, 159);
            this.button_Adc.Name = "button_Adc";
            this.button_Adc.Size = new System.Drawing.Size(100, 38);
            this.button_Adc.TabIndex = 93;
            this.button_Adc.Text = "Adicionar";
            this.button_Adc.UseVisualStyleBackColor = true;
            this.button_Adc.Click += new System.EventHandler(this.button_Adc_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(12, 179);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 92;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // maskedTextBox_Datareq
            // 
            this.maskedTextBox_Datareq.Location = new System.Drawing.Point(130, 68);
            this.maskedTextBox_Datareq.Mask = "00/00/0000";
            this.maskedTextBox_Datareq.Name = "maskedTextBox_Datareq";
            this.maskedTextBox_Datareq.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBox_Datareq.TabIndex = 95;
            this.maskedTextBox_Datareq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_Datareq.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(12, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 94;
            this.label10.Text = "Data Requisição:";
            // 
            // maskedTextBox_ReqMO
            // 
            this.maskedTextBox_ReqMO.Location = new System.Drawing.Point(295, 107);
            this.maskedTextBox_ReqMO.Name = "maskedTextBox_ReqMO";
            this.maskedTextBox_ReqMO.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBox_ReqMO.TabIndex = 99;
            this.maskedTextBox_ReqMO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox_ReqP
            // 
            this.maskedTextBox_ReqP.Location = new System.Drawing.Point(100, 111);
            this.maskedTextBox_ReqP.Name = "maskedTextBox_ReqP";
            this.maskedTextBox_ReqP.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBox_ReqP.TabIndex = 98;
            this.maskedTextBox_ReqP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(183, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 97;
            this.label12.Text = "Req. M.de Obra:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(12, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 96;
            this.label11.Text = "Req. Peças:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 100;
            this.label1.Text = "Requisição";
            // 
            // AdicionarReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox_ReqMO);
            this.Controls.Add(this.maskedTextBox_ReqP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maskedTextBox_Datareq);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_Adc);
            this.Controls.Add(this.button_Sair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdicionarReq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Requisição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Adc;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Datareq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ReqMO;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ReqP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
    }
}