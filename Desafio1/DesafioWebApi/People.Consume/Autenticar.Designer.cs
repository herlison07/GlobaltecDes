namespace People.Consume
{
    partial class Index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.TbCpf = new System.Windows.Forms.TextBox();
            this.BtnAutenticar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNome
            // 
            this.LNome.AutoSize = true;
            this.LNome.Location = new System.Drawing.Point(12, 30);
            this.LNome.Name = "LNome";
            this.LNome.Size = new System.Drawing.Size(38, 13);
            this.LNome.TabIndex = 0;
            this.LNome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(15, 46);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(188, 20);
            this.TbNome.TabIndex = 2;
            // 
            // TbCpf
            // 
            this.TbCpf.Location = new System.Drawing.Point(15, 107);
            this.TbCpf.Name = "TbCpf";
            this.TbCpf.Size = new System.Drawing.Size(188, 20);
            this.TbCpf.TabIndex = 3;
            // 
            // BtnAutenticar
            // 
            this.BtnAutenticar.Location = new System.Drawing.Point(68, 143);
            this.BtnAutenticar.Name = "BtnAutenticar";
            this.BtnAutenticar.Size = new System.Drawing.Size(75, 23);
            this.BtnAutenticar.TabIndex = 4;
            this.BtnAutenticar.Text = "Autenticar";
            this.BtnAutenticar.UseVisualStyleBackColor = true;
            this.BtnAutenticar.Click += new System.EventHandler(this.BtnAutenticar_Click);
            this.BtnAutenticar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAutenticar_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Não tem um cadastro? ";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(135, 189);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 22);
            this.BtnCadastrar.TabIndex = 6;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 215);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAutenticar);
            this.Controls.Add(this.TbCpf);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auteticar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.TextBox TbCpf;
        private System.Windows.Forms.Button BtnAutenticar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCadastrar;
    }
}

