namespace Manutençao
{
    partial class Entrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrar));
            this.button_Visualizar = new System.Windows.Forms.Button();
            this.button_Equipe = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Visualizar
            // 
            this.button_Visualizar.Location = new System.Drawing.Point(105, 88);
            this.button_Visualizar.Name = "button_Visualizar";
            this.button_Visualizar.Size = new System.Drawing.Size(227, 46);
            this.button_Visualizar.TabIndex = 0;
            this.button_Visualizar.Text = "Visualização para Setores";
            this.button_Visualizar.UseVisualStyleBackColor = true;
            this.button_Visualizar.Click += new System.EventHandler(this.button_Visualizar_Click);
            // 
            // button_Equipe
            // 
            this.button_Equipe.Location = new System.Drawing.Point(105, 166);
            this.button_Equipe.Name = "button_Equipe";
            this.button_Equipe.Size = new System.Drawing.Size(227, 46);
            this.button_Equipe.TabIndex = 1;
            this.button_Equipe.Text = "Área Equipe Interna";
            this.button_Equipe.UseVisualStyleBackColor = true;
            this.button_Equipe.Click += new System.EventHandler(this.button_Equipe_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(105, 241);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(227, 45);
            this.button_Sair.TabIndex = 2;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem Vindo,";
            // 
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.button_Equipe);
            this.Controls.Add(this.button_Visualizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Entrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Visualizar;
        private System.Windows.Forms.Button button_Equipe;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Label label1;
    }
}