namespace ConsumirWebApi
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.TbCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbUf = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Nome:";
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(70, 26);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(243, 20);
            this.TbNome.TabIndex = 1;
            // 
            // TbCpf
            // 
            this.TbCpf.Location = new System.Drawing.Point(70, 61);
            this.TbCpf.Name = "TbCpf";
            this.TbCpf.Size = new System.Drawing.Size(243, 20);
            this.TbCpf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UF:";
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
            this.CbUf.Location = new System.Drawing.Point(70, 98);
            this.CbUf.Name = "CbUf";
            this.CbUf.Size = new System.Drawing.Size(45, 21);
            this.CbUf.TabIndex = 5;
            this.CbUf.Text = "AC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nascimento:";
            // 
            // DtpNascimento
            // 
            this.DtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNascimento.Location = new System.Drawing.Point(215, 98);
            this.DtpNascimento.Name = "DtpNascimento";
            this.DtpNascimento.Size = new System.Drawing.Size(98, 20);
            this.DtpNascimento.TabIndex = 7;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(124, 167);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 8;
            this.BtnCadastrar.Text = "Cadsatrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 219);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.DtpNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbUf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.TextBox TbCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbUf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpNascimento;
        private System.Windows.Forms.Button BtnCadastrar;
    }
}