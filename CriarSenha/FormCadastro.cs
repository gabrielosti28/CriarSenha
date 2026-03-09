using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public partial class FormCadastro : Form
{
    string arquivo = "usuarios.txt";

    public FormCadastro()
    {
        InitializeComponent();

        txtSenha.PasswordChar = '*';
        txtConfirmar.PasswordChar = '*';
    }

    private void btnCriarClick_Click(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string senha = txtSenha.Text;

        if (usuario == "" || senha == "" || txtConfirmar.Text == "")
        {
            MessageBox.Show("Preencha todos os campos");
            return;
        }

        if (senha != txtConfirmar.Text)
        {
            MessageBox.Show("Senhas diferentes");
            return;
        }

        if (senha.Length <= 10)
        {
            MessageBox.Show("A senha deve ter mais de 10 caracteres");
            return;
        }

        if (!senha.Any(char.IsUpper))
        {
            MessageBox.Show("A senha deve ter pelo menos uma letra maiúscula");
            return;
        }

        if (!senha.Any(ch => !char.IsLetterOrDigit(ch)))
        {
            MessageBox.Show("A senha deve ter um caractere especial");
            return;
        }

        if (senha.ToLower().Contains(usuario.ToLower()))
        {
            MessageBox.Show("A senha não pode conter o nome do usuário");
            return;
        }

        if (!File.Exists(arquivo))
        {
            File.Create(arquivo).Close();
        }

        string[] linhas = File.ReadAllLines(arquivo);

        foreach (string linha in linhas)
        {
            string[] dados = linha.Split(';');

            if (dados[0] == usuario)
            {
                MessageBox.Show("Usuário já existe");
                return;
            }
        }

        string hash = Hash.GerarHash(senha);

        string novaLinha = usuario + ";" + hash;

        File.AppendAllText(arquivo, novaLinha + Environment.NewLine);

        MessageBox.Show("Usuário criado");

        txtUsuario.Clear();
        txtSenha.Clear();
        txtConfirmar.Clear();
    }

    private void btnIrLogin_Click(object sender, EventArgs e)
    {
        Form1 f = new Form1();
        f.Show();
        this.Hide();
    }

    private Label Usuário;
    private Button btnCriarClick;
    private TextBox txtUsuario;
    private TextBox txtSenha;
    private Label Senha;
    private TextBox txtConfirmar;
    private Label ConfirmarSenha;
    private Button btnIrLogin;

    private void InitializeComponent()
    {
        this.Usuário = new System.Windows.Forms.Label();
            this.btnCriarClick = new System.Windows.Forms.Button();
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
            // btnCriarClick
            // 
            this.btnCriarClick.Location = new System.Drawing.Point(64, 354);
            this.btnCriarClick.Name = "btnCriarClick";
            this.btnCriarClick.Size = new System.Drawing.Size(75, 23);
            this.btnCriarClick.TabIndex = 1;
            this.btnCriarClick.Text = "Cadastrar";
            this.btnCriarClick.UseVisualStyleBackColor = true;
            this.btnCriarClick.Click += new System.EventHandler(this.btnCriarClick_Click);
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
        this.btnIrLogin.Click += new System.EventHandler(this.btnIrLogin_Click);
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
            this.Controls.Add(this.btnCriarClick);
            this.Controls.Add(this.Usuário);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    
}