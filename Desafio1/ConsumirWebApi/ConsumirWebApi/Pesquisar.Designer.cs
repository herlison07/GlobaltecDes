namespace ConsumirWebApi
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
            this.label2 = new System.Windows.Forms.Label();
            this.TbFiltro = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DgvPeople = new System.Windows.Forms.DataGridView();
            this.BtnExecutar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TbCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.TbCpf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbUf = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbNasc = new System.Windows.Forms.DateTimePicker();
            this.BtnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
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
            "UF",
            "CPF"});
            this.CbFiltro.Location = new System.Drawing.Point(62, 25);
            this.CbFiltro.Name = "CbFiltro";
            this.CbFiltro.Size = new System.Drawing.Size(121, 21);
            this.CbFiltro.TabIndex = 1;
            this.CbFiltro.Text = "Nenhum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chave:";
            // 
            // TbFiltro
            // 
            this.TbFiltro.Location = new System.Drawing.Point(252, 25);
            this.TbFiltro.Name = "TbFiltro";
            this.TbFiltro.Size = new System.Drawing.Size(145, 20);
            this.TbFiltro.TabIndex = 3;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(27, 68);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 4;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnPesquisar_MouseClick);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(171, 68);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 5;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAlterar_MouseClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(322, 68);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 6;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnExcluir_MouseClick);
            // 
            // DgvPeople
            // 
            this.DgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPeople.Location = new System.Drawing.Point(27, 110);
            this.DgvPeople.Name = "DgvPeople";
            this.DgvPeople.Size = new System.Drawing.Size(558, 181);
            this.DgvPeople.TabIndex = 7;
            this.DgvPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPeople_CellClick);
            // 
            // BtnExecutar
            // 
            this.BtnExecutar.Location = new System.Drawing.Point(27, 407);
            this.BtnExecutar.Name = "BtnExecutar";
            this.BtnExecutar.Size = new System.Drawing.Size(75, 23);
            this.BtnExecutar.TabIndex = 8;
            this.BtnExecutar.Text = "Executar";
            this.BtnExecutar.UseVisualStyleBackColor = true;
            this.BtnExecutar.Click += new System.EventHandler(this.BtnExecutar_ClickAsync);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo:";
            // 
            // TbCod
            // 
            this.TbCod.Enabled = false;
            this.TbCod.Location = new System.Drawing.Point(73, 307);
            this.TbCod.Name = "TbCod";
            this.TbCod.Size = new System.Drawing.Size(39, 20);
            this.TbCod.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome:";
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(189, 307);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(196, 20);
            this.TbNome.TabIndex = 12;
            // 
            // TbCpf
            // 
            this.TbCpf.Location = new System.Drawing.Point(73, 345);
            this.TbCpf.Name = "TbCpf";
            this.TbCpf.Size = new System.Drawing.Size(196, 20);
            this.TbCpf.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "UF:";
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
            this.TbUf.Location = new System.Drawing.Point(456, 306);
            this.TbUf.Name = "TbUf";
            this.TbUf.Size = new System.Drawing.Size(45, 21);
            this.TbUf.TabIndex = 16;
            this.TbUf.Text = "AC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nascimento:";
            // 
            // TbNasc
            // 
            this.TbNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TbNasc.Location = new System.Drawing.Point(447, 345);
            this.TbNasc.Name = "TbNasc";
            this.TbNasc.Size = new System.Drawing.Size(138, 20);
            this.TbNasc.TabIndex = 18;
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(510, 407);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 19;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TbNasc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbUf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnExecutar);
            this.Controls.Add(this.DgvPeople);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.TbFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbFiltro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbFiltro;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DgvPeople;
        private System.Windows.Forms.Button BtnExecutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.TextBox TbCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TbUf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker TbNasc;
        private System.Windows.Forms.Button BtnSair;
    }
}