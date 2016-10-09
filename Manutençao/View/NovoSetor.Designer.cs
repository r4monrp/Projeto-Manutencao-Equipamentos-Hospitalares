namespace Manutençao
{
    partial class Novo_Setor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Novo_Setor));
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CoordResp = new System.Windows.Forms.TextBox();
            this.textBox_EnfResp = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.button_Adc = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(135, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Novo Setor";
            // 
            // textBox_CoordResp
            // 
            this.textBox_CoordResp.Location = new System.Drawing.Point(153, 132);
            this.textBox_CoordResp.Name = "textBox_CoordResp";
            this.textBox_CoordResp.Size = new System.Drawing.Size(262, 20);
            this.textBox_CoordResp.TabIndex = 20;
            // 
            // textBox_EnfResp
            // 
            this.textBox_EnfResp.Location = new System.Drawing.Point(153, 94);
            this.textBox_EnfResp.Name = "textBox_EnfResp";
            this.textBox_EnfResp.Size = new System.Drawing.Size(262, 20);
            this.textBox_EnfResp.TabIndex = 19;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(153, 60);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(262, 20);
            this.textBox_Nome.TabIndex = 18;
            // 
            // button_Adc
            // 
            this.button_Adc.Location = new System.Drawing.Point(315, 173);
            this.button_Adc.Name = "button_Adc";
            this.button_Adc.Size = new System.Drawing.Size(100, 38);
            this.button_Adc.TabIndex = 16;
            this.button_Adc.Text = "Adicionar";
            this.button_Adc.UseVisualStyleBackColor = true;
            this.button_Adc.Click += new System.EventHandler(this.button_Adc_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(26, 188);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 15;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Coord.Responsavel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enf. Responsavel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(104, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Setor:";
            // 
            // Novo_Setor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 223);
            this.Controls.Add(this.textBox_CoordResp);
            this.Controls.Add(this.textBox_EnfResp);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.button_Adc);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Novo_Setor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Setor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CoordResp;
        private System.Windows.Forms.TextBox textBox_EnfResp;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button button_Adc;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}