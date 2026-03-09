using System;
using System.IO;
using System.Windows.Forms;

public partial class Form1 : Form
{
    string arquivo = "usuarios.txt";

    public Form1()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string[] linhas = File.ReadAllLines(arquivo);

        string hash = Hash.GerarHash(txtSenha.Text);

        foreach (string linha in linhas)
        {
            string[] dados = linha.Split(';');

            if (dados[0] == txtUsuario.Text)
            {
                if (dados[1] == hash)
                {
                    MessageBox.Show("Login correto");
                    return;
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                    return;
                }
            }
        }

        MessageBox.Show("Usuário não encontrado");
    }

    private void btnAlterarSenha_Click(object sender, EventArgs e)
    {
        FormAlterar f = new FormAlterar();
        f.Show();
        this.Hide();
    }

    private void InitializeComponent()
    {
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Usuário = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(147, 144);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(89, 144);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 9;
            this.Senha.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(147, 90);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // Usuário
            // 
            this.Usuário.AutoSize = true;
            this.Usuário.Location = new System.Drawing.Point(89, 90);
            this.Usuário.Name = "Usuário";
            this.Usuário.Size = new System.Drawing.Size(43, 13);
            this.Usuário.TabIndex = 7;
            this.Usuário.Text = "Usuário";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(92, 234);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(366, 302);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Usuário);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    private TextBox txtSenha;
    private Label Senha;
    private TextBox txtUsuario;
    private Label Usuário;
    private Button btnLogin;

    private void btnLogin_Click_1(object sender, EventArgs e)
    {

    }
}