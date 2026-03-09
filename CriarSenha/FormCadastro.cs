using System;
using System.IO;
using System.Windows.Forms;

public partial class FormCadastro : Form
{
    string arquivo = "usuarios.txt";

    public FormCadastro()
    {
        InitializeComponent();
    }

    private void btnCriar_Click(object sender, EventArgs e)
    {
        if (txtSenha.Text != txtConfirmar.Text)
        {
            MessageBox.Show("Senhas diferentes");
            return;
        }

        string hash = Hash.GerarHash(txtSenha.Text);

        string linha = txtUsuario.Text + ";" + hash;

        File.AppendAllText(arquivo, linha + Environment.NewLine);

        MessageBox.Show("Usuário criado");
    }

    private void btnIrLogin_Click(object sender, EventArgs e)
    {
        FormLogin f = new FormLogin();
        f.Show();
        this.Hide();
    }

    private Label Usuário;
    private Button btnCriar;
    private TextBox txtUsuario;
    private TextBox txtSenha;
    private Label Senha;
    private TextBox txtConfirmar;
    private Label ConfirmarSenha;
    private Button btnIrLogin;

    private void InitializeComponent()
    {
        this.Usuário = new System.Windows.Forms.Label();
        this.btnCriar = new System.Windows.Forms.Button();
        this.txtUsuario = new System.Windows.Forms.TextBox();
        this.txtSenha = new System.Windows.Forms.TextBox();
        this.Senha = new System.Windows.Forms.Label();
        this.txtConfirmar = new System.Windows.Forms.TextBox();
        this.ConfirmarSenha = new System.Windows.Forms.Label();
        this.btnIrLogin = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // Usuário
        // 
        this.Usuário.AutoSize = true;
        this.Usuário.Location = new System.Drawing.Point(72, 72);
        this.Usuário.Name = "Usuário";
        this.Usuário.Size = new System.Drawing.Size(43, 13);
        this.Usuário.TabIndex = 0;
        this.Usuário.Text = "Usuário";
        // 
        // btnCriar
        // 
        this.btnCriar.Location = new System.Drawing.Point(64, 354);
        this.btnCriar.Name = "btnCriar";
        this.btnCriar.Size = new System.Drawing.Size(75, 23);
        this.btnCriar.TabIndex = 1;
        this.btnCriar.Text = "Cadastrar";
        this.btnCriar.UseVisualStyleBackColor = true;
        // 
        // txtUsuario
        // 
        this.txtUsuario.Location = new System.Drawing.Point(130, 72);
        this.txtUsuario.Name = "txtUsuario";
        this.txtUsuario.Size = new System.Drawing.Size(100, 20);
        this.txtUsuario.TabIndex = 2;
        // 
        // txtSenha
        // 
        this.txtSenha.Location = new System.Drawing.Point(130, 126);
        this.txtSenha.Name = "txtSenha";
        this.txtSenha.Size = new System.Drawing.Size(100, 20);
        this.txtSenha.TabIndex = 4;
        // 
        // Senha
        // 
        this.Senha.AutoSize = true;
        this.Senha.Location = new System.Drawing.Point(72, 126);
        this.Senha.Name = "Senha";
        this.Senha.Size = new System.Drawing.Size(38, 13);
        this.Senha.TabIndex = 3;
        this.Senha.Text = "Senha";
        // 
        // txtConfirmar
        // 
        this.txtConfirmar.Location = new System.Drawing.Point(160, 175);
        this.txtConfirmar.Name = "txtConfirmar";
        this.txtConfirmar.Size = new System.Drawing.Size(100, 20);
        this.txtConfirmar.TabIndex = 6;
        // 
        // ConfirmarSenha
        // 
        this.ConfirmarSenha.AutoSize = true;
        this.ConfirmarSenha.Location = new System.Drawing.Point(72, 178);
        this.ConfirmarSenha.Name = "ConfirmarSenha";
        this.ConfirmarSenha.Size = new System.Drawing.Size(82, 13);
        this.ConfirmarSenha.TabIndex = 5;
        this.ConfirmarSenha.Text = "ConfirmarSenha";
        // 
        // btnIrLogin
        // 
        this.btnIrLogin.Location = new System.Drawing.Point(64, 395);
        this.btnIrLogin.Name = "btnIrLogin";
        this.btnIrLogin.Size = new System.Drawing.Size(75, 23);
        this.btnIrLogin.TabIndex = 7;
        this.btnIrLogin.Text = "login";
        this.btnIrLogin.UseVisualStyleBackColor = true;
        // 
        // FormCadastro
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnIrLogin);
        this.Controls.Add(this.txtConfirmar);
        this.Controls.Add(this.ConfirmarSenha);
        this.Controls.Add(this.txtSenha);
        this.Controls.Add(this.Senha);
        this.Controls.Add(this.txtUsuario);
        this.Controls.Add(this.btnCriar);
        this.Controls.Add(this.Usuário);
        this.Name = "FormCadastro";
        this.Text = "FormCadastro";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
}