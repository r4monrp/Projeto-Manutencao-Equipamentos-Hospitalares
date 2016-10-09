namespace Manutençao
{
    partial class Equipamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Equipamentos = new System.Windows.Forms.DataGridView();
            this.button_Sair = new System.Windows.Forms.Button();
            this.button_Novo = new System.Windows.Forms.Button();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Equipamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Equipamentos";
            // 
            // dataGridView_Equipamentos
            // 
            this.dataGridView_Equipamentos.AllowUserToAddRows = false;
            this.dataGridView_Equipamentos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_Equipamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Equipamentos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Equipamentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Equipamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Equipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Equipamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Descrição});
            this.dataGridView_Equipamentos.Location = new System.Drawing.Point(10, 52);
            this.dataGridView_Equipamentos.Name = "dataGridView_Equipamentos";
            this.dataGridView_Equipamentos.ReadOnly = true;
            this.dataGridView_Equipamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Equipamentos.Size = new System.Drawing.Size(523, 197);
            this.dataGridView_Equipamentos.TabIndex = 6;
            this.dataGridView_Equipamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Equipamentos_CellDoubleClick);
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(240, 255);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(89, 21);
            this.button_Sair.TabIndex = 5;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // button_Novo
            // 
            this.button_Novo.Location = new System.Drawing.Point(10, 23);
            this.button_Novo.Name = "button_Novo";
            this.button_Novo.Size = new System.Drawing.Size(73, 23);
            this.button_Novo.TabIndex = 4;
            this.button_Novo.Text = "Novo";
            this.button_Novo.UseVisualStyleBackColor = true;
            this.button_Novo.Click += new System.EventHandler(this.button_Novo_Click);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Visible = false;
            // 
            // Descrição
            // 
            this.Descrição.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.Descrição.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            // 
            // Equipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Equipamentos);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.button_Novo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Equipamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipamentos";
            this.Activated += new System.EventHandler(this.Equipamentos_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Equipamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Equipamentos;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Button button_Novo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
    }
}