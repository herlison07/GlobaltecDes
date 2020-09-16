namespace ConsumirWebApi
{
    partial class Autenticar
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
            this.BtnAutenticar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(34, 43);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(184, 20);
            this.TbNome.TabIndex = 1;
            // 
            // TbCpf
            // 
            this.TbCpf.Location = new System.Drawing.Point(34, 107);
            this.TbCpf.Name = "TbCpf";
            this.TbCpf.Size = new System.Drawing.Size(184, 20);
            this.TbCpf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // BtnAutenticar
            // 
            this.BtnAutenticar.Location = new System.Drawing.Point(34, 158);
            this.BtnAutenticar.Name = "BtnAutenticar";
            this.BtnAutenticar.Size = new System.Drawing.Size(83, 24);
            this.BtnAutenticar.TabIndex = 4;
            this.BtnAutenticar.Text = "Autenticar";
            this.BtnAutenticar.UseVisualStyleBackColor = true;
            this.BtnAutenticar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAutenticar_MouseClick);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(135, 158);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(83, 24);
            this.BtnCadastrar.TabIndex = 5;
            this.BtnCadastrar.Text = "Cadasatrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // Autenticar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 207);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnAutenticar);
            this.Controls.Add(this.TbCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Autenticar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.TextBox TbCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAutenticar;
        private System.Windows.Forms.Button BtnCadastrar;
    }
}