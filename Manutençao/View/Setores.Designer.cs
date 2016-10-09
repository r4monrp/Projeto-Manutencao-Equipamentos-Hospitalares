namespace Manutençao
{
    partial class Setores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setores));
            this.button_Novo = new System.Windows.Forms.Button();
            this.dataGridView_Setor = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnfResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Setor)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Novo
            // 
            this.button_Novo.Location = new System.Drawing.Point(12, 22);
            this.button_Novo.Name = "button_Novo";
            this.button_Novo.Size = new System.Drawing.Size(75, 23);
            this.button_Novo.TabIndex = 0;
            this.button_Novo.Text = "Novo";
            this.button_Novo.UseVisualStyleBackColor = true;
            this.button_Novo.Click += new System.EventHandler(this.button_Novo_Click);
            // 
            // dataGridView_Setor
            // 
            this.dataGridView_Setor.AllowUserToAddRows = false;
            this.dataGridView_Setor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_Setor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Setor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Setor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Setor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Setor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Setor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Setor,
            this.EnfResponsavel,
            this.CoordResponsavel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Setor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Setor.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Setor.Location = new System.Drawing.Point(12, 51);
            this.dataGridView_Setor.Name = "dataGridView_Setor";
            this.dataGridView_Setor.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_Setor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Setor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Setor.Size = new System.Drawing.Size(634, 226);
            this.dataGridView_Setor.TabIndex = 1;
            this.dataGridView_Setor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Setor_CellDoubleClick);
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
            // Setor
            // 
            this.Setor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Setor.HeaderText = "Setor";
            this.Setor.Name = "Setor";
            this.Setor.ReadOnly = true;
            this.Setor.Width = 210;
            // 
            // EnfResponsavel
            // 
            this.EnfResponsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EnfResponsavel.HeaderText = "Enf.Responsavel";
            this.EnfResponsavel.Name = "EnfResponsavel";
            this.EnfResponsavel.ReadOnly = true;
            this.EnfResponsavel.Width = 190;
            // 
            // CoordResponsavel
            // 
            this.CoordResponsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CoordResponsavel.HeaderText = "Coord.Responsavel";
            this.CoordResponsavel.Name = "CoordResponsavel";
            this.CoordResponsavel.ReadOnly = true;
            this.CoordResponsavel.Width = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(297, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Setores";
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(301, 283);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 3;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // Setores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 318);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Setor);
            this.Controls.Add(this.button_Novo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Setores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setores";
            this.Activated += new System.EventHandler(this.Setores_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Setor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Novo;
        private System.Windows.Forms.DataGridView dataGridView_Setor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnfResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordResponsavel;
    }
}