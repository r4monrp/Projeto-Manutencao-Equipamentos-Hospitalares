namespace Manutençao
{
    partial class AdicionarOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarOrcamento));
            this.maskedTextBox_ValorO = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.maskedTextBox_NOrc = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.maskedTextBox_DataO = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.maskedTextBox_Orcamento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Adc = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog_orc = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_AdcArq = new System.Windows.Forms.ToolStripButton();
            this.label26 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox_ValorO
            // 
            this.maskedTextBox_ValorO.Location = new System.Drawing.Point(76, 156);
            this.maskedTextBox_ValorO.Name = "maskedTextBox_ValorO";
            this.maskedTextBox_ValorO.Size = new System.Drawing.Size(92, 20);
            this.maskedTextBox_ValorO.TabIndex = 87;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DarkRed;
            this.label24.Location = new System.Drawing.Point(9, 161);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 16);
            this.label24.TabIndex = 86;
            this.label24.Text = "Valor:";
            // 
            // maskedTextBox_NOrc
            // 
            this.maskedTextBox_NOrc.Location = new System.Drawing.Point(110, 120);
            this.maskedTextBox_NOrc.Name = "maskedTextBox_NOrc";
            this.maskedTextBox_NOrc.Size = new System.Drawing.Size(101, 20);
            this.maskedTextBox_NOrc.TabIndex = 85;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkRed;
            this.label20.Location = new System.Drawing.Point(9, 124);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 16);
            this.label20.TabIndex = 84;
            this.label20.Text = "Nº Orçamento:";
            // 
            // maskedTextBox_DataO
            // 
            this.maskedTextBox_DataO.Location = new System.Drawing.Point(124, 46);
            this.maskedTextBox_DataO.Mask = "00/00/0000";
            this.maskedTextBox_DataO.Name = "maskedTextBox_DataO";
            this.maskedTextBox_DataO.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBox_DataO.TabIndex = 83;
            this.maskedTextBox_DataO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_DataO.ValidatingType = typeof(System.DateTime);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(9, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 16);
            this.label19.TabIndex = 82;
            this.label19.Text = "Data Orçamento:";
            // 
            // maskedTextBox_Orcamento
            // 
            this.maskedTextBox_Orcamento.Location = new System.Drawing.Point(93, 81);
            this.maskedTextBox_Orcamento.Name = "maskedTextBox_Orcamento";
            this.maskedTextBox_Orcamento.Size = new System.Drawing.Size(224, 20);
            this.maskedTextBox_Orcamento.TabIndex = 89;
            this.maskedTextBox_Orcamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 88;
            this.label1.Text = "Orçamento:";
            // 
            // button_Adc
            // 
            this.button_Adc.Location = new System.Drawing.Point(226, 188);
            this.button_Adc.Name = "button_Adc";
            this.button_Adc.Size = new System.Drawing.Size(100, 38);
            this.button_Adc.TabIndex = 91;
            this.button_Adc.Text = "Adicionar";
            this.button_Adc.UseVisualStyleBackColor = true;
            this.button_Adc.Click += new System.EventHandler(this.button_Adc_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(12, 203);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 90;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 93;
            this.label2.Text = "Orçamento";
            // 
            // openFileDialog_orc
            // 
            this.openFileDialog_orc.InitialDirectory = "\\\\VM-SRVARQ1\\Engenharia_Clinica\\Manutenção Externa\\Orçamentos\\";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_AdcArq});
            this.toolStrip1.Location = new System.Drawing.Point(320, 73);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(28, 28);
            this.toolStrip1.TabIndex = 94;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_AdcArq
            // 
            this.toolStripButton_AdcArq.AutoSize = false;
            this.toolStripButton_AdcArq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_AdcArq.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AdcArq.Image")));
            this.toolStripButton_AdcArq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AdcArq.Name = "toolStripButton_AdcArq";
            this.toolStripButton_AdcArq.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton_AdcArq.Text = "toolStripButton1";
            this.toolStripButton_AdcArq.Click += new System.EventHandler(this.toolStripButton_AdcArq_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(52, 158);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 15);
            this.label26.TabIndex = 95;
            this.label26.Text = "R$";
            // 
            // AdicionarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 238);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Adc);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.maskedTextBox_Orcamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox_ValorO);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.maskedTextBox_NOrc);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.maskedTextBox_DataO);
            this.Controls.Add(this.label19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdicionarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Orçamento";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_ValorO;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_NOrc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataO;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Orcamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Adc;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog_orc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_AdcArq;
        private System.Windows.Forms.Label label26;
    }
}