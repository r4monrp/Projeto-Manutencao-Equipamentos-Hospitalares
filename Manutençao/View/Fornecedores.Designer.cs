namespace Manutençao
{
    partial class Fornecedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedores));
            this.button_Novo = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.dataGridView_Fornecedores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Novo
            // 
            this.button_Novo.Location = new System.Drawing.Point(12, 17);
            this.button_Novo.Name = "button_Novo";
            this.button_Novo.Size = new System.Drawing.Size(73, 23);
            this.button_Novo.TabIndex = 0;
            this.button_Novo.Text = "Novo";
            this.button_Novo.UseVisualStyleBackColor = true;
            this.button_Novo.Click += new System.EventHandler(this.button_Novo_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(339, 298);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(89, 21);
            this.button_Sair.TabIndex = 1;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // dataGridView_Fornecedores
            // 
            this.dataGridView_Fornecedores.AllowUserToAddRows = false;
            this.dataGridView_Fornecedores.AllowUserToDeleteRows = false;
            this.dataGridView_Fornecedores.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Fornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Fornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome,
            this.Contato,
            this.Telefone,
            this.Email});
            this.dataGridView_Fornecedores.Location = new System.Drawing.Point(12, 46);
            this.dataGridView_Fornecedores.Name = "dataGridView_Fornecedores";
            this.dataGridView_Fornecedores.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Fornecedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Fornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Fornecedores.Size = new System.Drawing.Size(754, 246);
            this.dataGridView_Fornecedores.TabIndex = 2;
            this.dataGridView_Fornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Fornecedores_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fornecedores";
            // 
            // Código
            // 
            this.Código.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Visible = false;
            this.Código.Width = 80;
            // 
            // Nome
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 178;
            // 
            // Contato
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Contato.DefaultCellStyle = dataGridViewCellStyle3;
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            this.Contato.Width = 178;
            // 
            // Telefone
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle4;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 177;
            // 
            // Email
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Email.DefaultCellStyle = dataGridViewCellStyle5;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 178;
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Fornecedores);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.button_Novo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Activated += new System.EventHandler(this.Fornecedores_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Novo;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.DataGridView dataGridView_Fornecedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}