namespace Manutençao
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Fornec = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.button_Equip = new System.Windows.Forms.Button();
            this.tabControl_Equipamentos = new System.Windows.Forms.TabControl();
            this.tabPage_EmAberto = new System.Windows.Forms.TabPage();
            this.dataGridView_EmAberto = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodExterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Finalizado = new System.Windows.Forms.TabPage();
            this.dataGridView_Finalizados = new System.Windows.Forms.DataGridView();
            this.Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipamentoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CódigoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetorF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OSF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodExternoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Setor = new System.Windows.Forms.Button();
            this.tabControl_Equipamentos.SuspendLayout();
            this.tabPage_EmAberto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmAberto)).BeginInit();
            this.tabPage_Finalizado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finalizados)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(26, 315);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(272, 33);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Adicionar Equipamento";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Fornec
            // 
            this.button_Fornec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Fornec.Location = new System.Drawing.Point(26, 367);
            this.button_Fornec.Name = "button_Fornec";
            this.button_Fornec.Size = new System.Drawing.Size(272, 34);
            this.button_Fornec.TabIndex = 2;
            this.button_Fornec.Text = "Fornecedores";
            this.button_Fornec.UseVisualStyleBackColor = true;
            this.button_Fornec.Click += new System.EventHandler(this.button_Fornec_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sair.Location = new System.Drawing.Point(26, 529);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(272, 34);
            this.button_Sair.TabIndex = 3;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // button_Equip
            // 
            this.button_Equip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Equip.Location = new System.Drawing.Point(26, 419);
            this.button_Equip.Name = "button_Equip";
            this.button_Equip.Size = new System.Drawing.Size(272, 34);
            this.button_Equip.TabIndex = 4;
            this.button_Equip.Text = "Equipamentos";
            this.button_Equip.UseVisualStyleBackColor = true;
            this.button_Equip.Click += new System.EventHandler(this.button_Equip_Click);
            // 
            // tabControl_Equipamentos
            // 
            this.tabControl_Equipamentos.Controls.Add(this.tabPage_EmAberto);
            this.tabControl_Equipamentos.Controls.Add(this.tabPage_Finalizado);
            this.tabControl_Equipamentos.Location = new System.Drawing.Point(331, 24);
            this.tabControl_Equipamentos.Name = "tabControl_Equipamentos";
            this.tabControl_Equipamentos.SelectedIndex = 0;
            this.tabControl_Equipamentos.Size = new System.Drawing.Size(963, 553);
            this.tabControl_Equipamentos.TabIndex = 6;
            // 
            // tabPage_EmAberto
            // 
            this.tabPage_EmAberto.BackColor = System.Drawing.Color.Silver;
            this.tabPage_EmAberto.Controls.Add(this.dataGridView_EmAberto);
            this.tabPage_EmAberto.Location = new System.Drawing.Point(4, 22);
            this.tabPage_EmAberto.Name = "tabPage_EmAberto";
            this.tabPage_EmAberto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EmAberto.Size = new System.Drawing.Size(955, 527);
            this.tabPage_EmAberto.TabIndex = 0;
            this.tabPage_EmAberto.Text = "Em Aberto";
            // 
            // dataGridView_EmAberto
            // 
            this.dataGridView_EmAberto.AllowUserToAddRows = false;
            this.dataGridView_EmAberto.AllowUserToDeleteRows = false;
            this.dataGridView_EmAberto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_EmAberto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_EmAberto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmAberto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Equipamento,
            this.Código,
            this.Setor,
            this.OS,
            this.Fornecedor,
            this.CodExterno});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_EmAberto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_EmAberto.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_EmAberto.Name = "dataGridView_EmAberto";
            this.dataGridView_EmAberto.ReadOnly = true;
            this.dataGridView_EmAberto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_EmAberto.Size = new System.Drawing.Size(954, 527);
            this.dataGridView_EmAberto.TabIndex = 0;
            this.dataGridView_EmAberto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_EmAberto_CellDoubleClick);
            // 
            // Status
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Status.DefaultCellStyle = dataGridViewCellStyle2;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.Width = 250;
            // 
            // Equipamento
            // 
            this.Equipamento.HeaderText = "Equipamento";
            this.Equipamento.Name = "Equipamento";
            this.Equipamento.ReadOnly = true;
            this.Equipamento.Width = 190;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 75;
            // 
            // Setor
            // 
            this.Setor.HeaderText = "Setor";
            this.Setor.Name = "Setor";
            this.Setor.ReadOnly = true;
            this.Setor.Width = 150;
            // 
            // OS
            // 
            this.OS.HeaderText = "OS";
            this.OS.Name = "OS";
            this.OS.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.Width = 145;
            // 
            // CodExterno
            // 
            this.CodExterno.HeaderText = "CodExterno";
            this.CodExterno.Name = "CodExterno";
            this.CodExterno.ReadOnly = true;
            this.CodExterno.Visible = false;
            // 
            // tabPage_Finalizado
            // 
            this.tabPage_Finalizado.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage_Finalizado.Controls.Add(this.dataGridView_Finalizados);
            this.tabPage_Finalizado.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Finalizado.Name = "tabPage_Finalizado";
            this.tabPage_Finalizado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Finalizado.Size = new System.Drawing.Size(955, 527);
            this.tabPage_Finalizado.TabIndex = 1;
            this.tabPage_Finalizado.Text = "Finalizados";
            // 
            // dataGridView_Finalizados
            // 
            this.dataGridView_Finalizados.AllowUserToAddRows = false;
            this.dataGridView_Finalizados.AllowUserToDeleteRows = false;
            this.dataGridView_Finalizados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Finalizados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Finalizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Finalizados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entrega,
            this.EquipamentoF,
            this.CódigoF,
            this.SetorF,
            this.OSF,
            this.FornecedorF,
            this.CodExternoF});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Finalizados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Finalizados.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Finalizados.Name = "dataGridView_Finalizados";
            this.dataGridView_Finalizados.ReadOnly = true;
            this.dataGridView_Finalizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Finalizados.Size = new System.Drawing.Size(954, 527);
            this.dataGridView_Finalizados.TabIndex = 1;
            this.dataGridView_Finalizados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Finalizados_CellDoubleClick);
            // 
            // Entrega
            // 
            this.Entrega.HeaderText = "Entrega";
            this.Entrega.Name = "Entrega";
            this.Entrega.ReadOnly = true;
            this.Entrega.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Entrega.Width = 190;
            // 
            // EquipamentoF
            // 
            this.EquipamentoF.HeaderText = "Equipamento";
            this.EquipamentoF.Name = "EquipamentoF";
            this.EquipamentoF.ReadOnly = true;
            this.EquipamentoF.Width = 190;
            // 
            // CódigoF
            // 
            this.CódigoF.HeaderText = "Código";
            this.CódigoF.Name = "CódigoF";
            this.CódigoF.ReadOnly = true;
            this.CódigoF.Width = 90;
            // 
            // SetorF
            // 
            this.SetorF.HeaderText = "Setor";
            this.SetorF.Name = "SetorF";
            this.SetorF.ReadOnly = true;
            this.SetorF.Width = 160;
            // 
            // OSF
            // 
            this.OSF.HeaderText = "OS";
            this.OSF.Name = "OSF";
            this.OSF.ReadOnly = true;
            this.OSF.Width = 110;
            // 
            // FornecedorF
            // 
            this.FornecedorF.HeaderText = "Fornecedor";
            this.FornecedorF.Name = "FornecedorF";
            this.FornecedorF.ReadOnly = true;
            this.FornecedorF.Width = 170;
            // 
            // CodExternoF
            // 
            this.CodExternoF.HeaderText = "CodExternoF";
            this.CodExternoF.Name = "CodExternoF";
            this.CodExternoF.ReadOnly = true;
            this.CodExternoF.Visible = false;
            // 
            // button_Setor
            // 
            this.button_Setor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Setor.Location = new System.Drawing.Point(26, 475);
            this.button_Setor.Name = "button_Setor";
            this.button_Setor.Size = new System.Drawing.Size(272, 34);
            this.button_Setor.TabIndex = 7;
            this.button_Setor.Text = "Setores";
            this.button_Setor.UseVisualStyleBackColor = true;
            this.button_Setor.Click += new System.EventHandler(this.button_Setor_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1306, 589);
            this.Controls.Add(this.button_Setor);
            this.Controls.Add(this.tabControl_Equipamentos);
            this.Controls.Add(this.button_Equip);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Fornec);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Externa de Equipamentos";
            this.Activated += new System.EventHandler(this.Principal_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.tabControl_Equipamentos.ResumeLayout(false);
            this.tabPage_EmAberto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmAberto)).EndInit();
            this.tabPage_Finalizado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finalizados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Fornec;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Button button_Equip;
        private System.Windows.Forms.TabControl tabControl_Equipamentos;
        private System.Windows.Forms.TabPage tabPage_EmAberto;
        private System.Windows.Forms.TabPage tabPage_Finalizado;
        private System.Windows.Forms.Button button_Setor;
        private System.Windows.Forms.DataGridView dataGridView_EmAberto;
        private System.Windows.Forms.DataGridView dataGridView_Finalizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodExterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipamentoF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódigoF;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetorF;
        private System.Windows.Forms.DataGridViewTextBoxColumn OSF;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodExternoF;
    }
}

