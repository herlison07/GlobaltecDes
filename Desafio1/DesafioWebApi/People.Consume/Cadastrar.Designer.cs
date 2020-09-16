namespace People.Consume
{
    partial class Cadastrar
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
            this.LNome = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.TbCpf = new System.Windows.Forms.TextBox();
            this.LCpf = new System.Windows.Forms.Label();
            this.LUf = new System.Windows.Forms.Label();
            this.CbUf = new System.Windows.Forms.ComboBox();
            this.LNascimento = new System.Windows.Forms.Label();
            this.DtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNome
            // 
            this.LNome.AutoSize = true;
            this.LNome.Location = new System.Drawing.Point(23, 22);
            this.LNome.Name = "LNome";
            this.LNome.Size = new System.Drawing.Size(38, 13);
            this.LNome.TabIndex = 0;
            this.LNome.Text = "Nome:";
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(26, 38);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(313, 20);
            this.TbNome.TabIndex = 1;
            // 
            // TbCpf
            // 
            this.TbCpf.Location = new System.Drawing.Point(26, 84);
            this.TbCpf.Name = "TbCpf";
            this.TbCpf.Size = new System.Drawing.Size(313, 20);
            this.TbCpf.TabIndex = 3;
            // 
            // LCpf
            // 
            this.LCpf.AutoSize = true;
            this.LCpf.Location = new System.Drawing.Point(23, 68);
            this.LCpf.Name = "LCpf";
            this.LCpf.Size = new System.Drawing.Size(30, 13);
            this.LCpf.TabIndex = 2;
            this.LCpf.Text = "CPF:";
            // 
            // LUf
            // 
            this.LUf.AutoSize = true;
            this.LUf.Location = new System.Drawing.Point(23, 120);
            this.LUf.Name = "LUf";
            this.LUf.Size = new System.Drawing.Size(24, 13);
            this.LUf.TabIndex = 4;
            this.LUf.Text = "UF:";
            // 
            // CbUf
            // 
            this.CbUf.FormattingEnabled = true;
            this.CbUf.Items.AddRange(new object[] {
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
            this.CbUf.Location = new System.Drawing.Point(53, 117);
            this.CbUf.Name = "CbUf";
            this.CbUf.Size = new System.Drawing.Size(67, 21);
            this.CbUf.TabIndex = 5;
            this.CbUf.UseWaitCursor = true;
            // 
            // LNascimento
            // 
            this.LNascimento.AutoSize = true;
            this.LNascimento.Location = new System.Drawing.Point(163, 120);
            this.LNascimento.Name = "LNascimento";
            this.LNascimento.Size = new System.Drawing.Size(66, 13);
            this.LNascimento.TabIndex = 6;
            this.LNascimento.Text = "Nascimento:";
            // 
            // DtpNascimento
            // 
            this.DtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNascimento.Location = new System.Drawing.Point(235, 117);
            this.DtpNascimento.Name = "DtpNascimento";
            this.DtpNascimento.Size = new System.Drawing.Size(104, 20);
            this.DtpNascimento.TabIndex = 7;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(137, 173);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 8;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 213);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.DtpNascimento);
            this.Controls.Add(this.LNascimento);
            this.Controls.Add(this.CbUf);
            this.Controls.Add(this.LUf);
            this.Controls.Add(this.TbCpf);
            this.Controls.Add(this.LCpf);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.LNome);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNome;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.TextBox TbCpf;
        private System.Windows.Forms.Label LCpf;
        private System.Windows.Forms.Label LUf;
        private System.Windows.Forms.ComboBox CbUf;
        private System.Windows.Forms.Label LNascimento;
        private System.Windows.Forms.DateTimePicker DtpNascimento;
        private System.Windows.Forms.Button BtnCadastrar;
    }
}