namespace Manutençao
{
    partial class Logar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Entrar = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(37, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // button_Entrar
            // 
            this.button_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Entrar.ForeColor = System.Drawing.Color.Black;
            this.button_Entrar.Location = new System.Drawing.Point(225, 153);
            this.button_Entrar.Name = "button_Entrar";
            this.button_Entrar.Size = new System.Drawing.Size(75, 23);
            this.button_Entrar.TabIndex = 3;
            this.button_Entrar.Text = "Entrar";
            this.button_Entrar.UseVisualStyleBackColor = true;
            this.button_Entrar.Click += new System.EventHandler(this.button_Entrar_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sair.ForeColor = System.Drawing.Color.Black;
            this.button_Sair.Location = new System.Drawing.Point(12, 153);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 4;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Location = new System.Drawing.Point(93, 53);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(166, 20);
            this.textBox_Usuario.TabIndex = 1;
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Location = new System.Drawing.Point(93, 93);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.PasswordChar = '*';
            this.textBox_Senha.Size = new System.Drawing.Size(166, 20);
            this.textBox_Senha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(90, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Autenticação da Equipe";
            // 
            // Logar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 186);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Senha);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.button_Entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Logar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Logar_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Logar_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Entrar;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.Label label3;
    }
}