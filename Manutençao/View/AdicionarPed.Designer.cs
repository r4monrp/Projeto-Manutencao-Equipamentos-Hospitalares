namespace Manutençao
{
    partial class AdicionarPed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarPed));
            this.maskedTextBox_DataP = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox_PedMO = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_PedP = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button_AdcRet = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.maskedTextBox_EntregaP = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBox_DataP
            // 
            this.maskedTextBox_DataP.Location = new System.Drawing.Point(103, 56);
            this.maskedTextBox_DataP.Mask = "00/00/0000";
            this.maskedTextBox_DataP.Name = "maskedTextBox_DataP";
            this.maskedTextBox_DataP.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBox_DataP.TabIndex = 55;
            this.maskedTextBox_DataP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_DataP.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(12, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 16);
            this.label13.TabIndex = 54;
            this.label13.Text = "Data Pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Pedido de Compra";
            // 
            // maskedTextBox_PedMO
            // 
            this.maskedTextBox_PedMO.Location = new System.Drawing.Point(299, 97);
            this.maskedTextBox_PedMO.Name = "maskedTextBox_PedMO";
            this.maskedTextBox_PedMO.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBox_PedMO.TabIndex = 61;
            this.maskedTextBox_PedMO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox_PedP
            // 
            this.maskedTextBox_PedP.Location = new System.Drawing.Point(99, 97);
            this.maskedTextBox_PedP.Name = "maskedTextBox_PedP";
            this.maskedTextBox_PedP.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBox_PedP.TabIndex = 60;
            this.maskedTextBox_PedP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(188, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 16);
            this.label14.TabIndex = 59;
            this.label14.Text = "Ped. M.de Obra:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(12, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 16);
            this.label15.TabIndex = 58;
            this.label15.Text = "Ped. Peças:";
            // 
            // button_AdcRet
            // 
            this.button_AdcRet.Location = new System.Drawing.Point(280, 171);
            this.button_AdcRet.Name = "button_AdcRet";
            this.button_AdcRet.Size = new System.Drawing.Size(100, 38);
            this.button_AdcRet.TabIndex = 95;
            this.button_AdcRet.Text = "Adicionar";
            this.button_AdcRet.UseVisualStyleBackColor = true;
            this.button_AdcRet.Click += new System.EventHandler(this.button_AdcRet_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(15, 186);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 94;
            this.button_Sair.Text = "Cancelar";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // maskedTextBox_EntregaP
            // 
            this.maskedTextBox_EntregaP.Location = new System.Drawing.Point(134, 144);
            this.maskedTextBox_EntregaP.Mask = "00/00/0000";
            this.maskedTextBox_EntregaP.Name = "maskedTextBox_EntregaP";
            this.maskedTextBox_EntregaP.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBox_EntregaP.TabIndex = 97;
            this.maskedTextBox_EntregaP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_EntregaP.ValidatingType = typeof(System.DateTime);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkRed;
            this.label18.Location = new System.Drawing.Point(12, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 16);
            this.label18.TabIndex = 96;
            this.label18.Text = "Entrega Prevista:";
            // 
            // AdicionarPed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 221);
            this.Controls.Add(this.maskedTextBox_EntregaP);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button_AdcRet);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.maskedTextBox_PedMO);
            this.Controls.Add(this.maskedTextBox_PedP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox_DataP);
            this.Controls.Add(this.label13);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdicionarPed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PedMO;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PedP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_AdcRet;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_EntregaP;
        private System.Windows.Forms.Label label18;
    }
}