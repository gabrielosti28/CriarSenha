namespace CriarSenha
{
    partial class FormAlterar
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
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.ConfirmarSenha = new System.Windows.Forms.Label();
            this.txtAntiga = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Usuário = new System.Windows.Forms.Label();
            this.txtNova = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(172, 208);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmar.TabIndex = 12;
            // 
            // ConfirmarSenha
            // 
            this.ConfirmarSenha.AutoSize = true;
            this.ConfirmarSenha.Location = new System.Drawing.Point(84, 211);
            this.ConfirmarSenha.Name = "ConfirmarSenha";
            this.ConfirmarSenha.Size = new System.Drawing.Size(82, 13);
            this.ConfirmarSenha.TabIndex = 11;
            this.ConfirmarSenha.Text = "ConfirmarSenha";
            // 
            // txtAntiga
            // 
            this.txtAntiga.Location = new System.Drawing.Point(172, 113);
            this.txtAntiga.Name = "txtAntiga";
            this.txtAntiga.Size = new System.Drawing.Size(100, 20);
            this.txtAntiga.TabIndex = 10;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(96, 113);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(68, 13);
            this.Senha.TabIndex = 9;
            this.Senha.Text = "SenhaAntiga";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(154, 59);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // Usuário
            // 
            this.Usuário.AutoSize = true;
            this.Usuário.Location = new System.Drawing.Point(96, 59);
            this.Usuário.Name = "Usuário";
            this.Usuário.Size = new System.Drawing.Size(43, 13);
            this.Usuário.TabIndex = 7;
            this.Usuário.Text = "Usuário";
            // 
            // txtNova
            // 
            this.txtNova.Location = new System.Drawing.Point(166, 159);
            this.txtNova.Name = "txtNova";
            this.txtNova.Size = new System.Drawing.Size(100, 20);
            this.txtNova.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "SenhaNova";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(91, 272);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // FormAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtNova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.ConfirmarSenha);
            this.Controls.Add(this.txtAntiga);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Usuário);
            this.Name = "FormAlterar";
            this.Text = "FormAlterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label ConfirmarSenha;
        private System.Windows.Forms.TextBox txtAntiga;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label Usuário;
        private System.Windows.Forms.TextBox txtNova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
    }
}