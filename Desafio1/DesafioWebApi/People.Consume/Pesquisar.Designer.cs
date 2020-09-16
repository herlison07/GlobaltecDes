namespace People.Consume
{
    partial class Pesquisar
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbFiltro = new System.Windows.Forms.ComboBox();
            this.TbFiltro = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.DgvPeople = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbCod = new System.Windows.Forms.TextBox();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbCpf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnExecutar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TbNasc = new System.Windows.Forms.DateTimePicker();
            this.TbUf = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro:";
            // 
            // CbFiltro
            // 
            this.CbFiltro.FormattingEnabled = true;
            this.CbFiltro.Items.AddRange(new object[] {
            "Nenhum",
            "CPF",
            "UF"});
            this.CbFiltro.Location = new System.Drawing.Point(64, 22);
            this.CbFiltro.Name = "CbFiltro";
            this.CbFiltro.Size = new System.Drawing.Size(71, 21);
            this.CbFiltro.TabIndex = 1;
            this.CbFiltro.Text = "Nenhum";
            // 
            // TbFiltro
            // 
            this.TbFiltro.Location = new System.Drawing.Point(199, 23);
            this.TbFiltro.Name = "TbFiltro";
            this.TbFiltro.Size = new System.Drawing.Size(179, 20);
            this.TbFiltro.TabIndex = 2;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPesquisar.Location = new System.Drawing.Point(26, 68);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 3;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnPesquisar_MouseClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.Location = new System.Drawing.Point(303, 68);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnExcluir_MouseClick);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlterar.Location = new System.Drawing.Point(155, 68);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 5;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAlterar_MouseClick);
            // 
            // DgvPeople
            // 
            this.DgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPeople.Location = new System.Drawing.Point(26, 110);
            this.DgvPeople.Name = "DgvPeople";
            this.DgvPeople.Size = new System.Drawing.Size(431, 82);
            this.DgvPeople.TabIndex = 6;
            this.DgvPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPeople_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo:";
            // 
            // TbCod
            // 
            this.TbCod.Enabled = false;
            this.TbCod.Location = new System.Drawing.Point(76, 208);
            this.TbCod.Name = "TbCod";
            this.TbCod.Size = new System.Drawing.Size(48, 20);
            this.TbCod.TabIndex = 9;
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(196, 208);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(261, 20);
            this.TbNome.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "UF:";
            // 
            // TbCpf
            // 
            this.TbCpf.Location = new System.Drawing.Point(196, 238);
            this.TbCpf.Name = "TbCpf";
            this.TbCpf.Size = new System.Drawing.Size(79, 20);
            this.TbCpf.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nascimento:";
            // 
            // BtnExecutar
            // 
            this.BtnExecutar.Location = new System.Drawing.Point(30, 276);
            this.BtnExecutar.Name = "BtnExecutar";
            this.BtnExecutar.Size = new System.Drawing.Size(75, 23);
            this.BtnExecutar.TabIndex = 18;
            this.BtnExecutar.Text = "Executar";
            this.BtnExecutar.UseVisualStyleBackColor = true;
            this.BtnExecutar.Click += new System.EventHandler(this.BtnExecutar_ClickAsync);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(382, 276);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 19;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TbNasc
            // 
            this.TbNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TbNasc.Location = new System.Drawing.Point(344, 237);
            this.TbNasc.Name = "TbNasc";
            this.TbNasc.Size = new System.Drawing.Size(113, 20);
            this.TbNasc.TabIndex = 20;
            // 
            // TbUf
            // 
            this.TbUf.FormattingEnabled = true;
            this.TbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SP",
            "SC",
            "SE",
            "TO"});
            this.TbUf.Location = new System.Drawing.Point(76, 234);
            this.TbUf.Name = "TbUf";
            this.TbUf.Size = new System.Drawing.Size(48, 21);
            this.TbUf.TabIndex = 21;
            this.TbUf.UseWaitCursor = true;
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 311);
            this.ControlBox = false;
            this.Controls.Add(this.TbUf);
            this.Controls.Add(this.TbNasc);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnExecutar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbCpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvPeople);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.TbFiltro);
            this.Controls.Add(this.CbFiltro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbFiltro;
        private System.Windows.Forms.TextBox TbFiltro;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.DataGridView DgvPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbCod;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnExecutar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DateTimePicker TbNasc;
        private System.Windows.Forms.ComboBox TbUf;
    }
}