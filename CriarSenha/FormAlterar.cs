using System;
using System.IO;
using System.Windows.Forms;

public partial class FormAlterar : Form
{
    string arquivo = "usuarios.txt";

    public FormAlterar()
    {
        InitializeComponent();
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        if (txtNova.Text != txtConfirmar.Text)
        {
            MessageBox.Show("Senhas diferentes");
            return;
        }

        string[] linhas = File.ReadAllLines(arquivo);

        for (int i = 0; i < linhas.Length; i++)
        {
            string[] dados = linhas[i].Split(';');

            if (dados[0] == txtUsuario.Text)
            {
                string hashAntigo = Hash.GerarHash(txtAntiga.Text);

                if (dados[1] == hashAntigo)
                {
                    string hashNovo = Hash.GerarHash(txtNova.Text);

                    linhas[i] = txtUsuario.Text + ";" + hashNovo;

                    File.WriteAllLines(arquivo, linhas);

                    MessageBox.Show("Senha alterada");
                    return;
                }
                else
                {
                    MessageBox.Show("Senha antiga incorreta");
                    return;
                }
            }
        }

        MessageBox.Show("Usuário não encontrado");
    }

    private TextBox txtConfirmar;
    private Label ConfirmarSenha;
    private TextBox txtAntiga;
    private Label Senha;
    private TextBox txtUsuario;
    private Label Usuário;
    private TextBox txtNova;
    private Label label1;
    private Button btnAlterar;

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
            this.ClientSize = new System.Drawing.Size(644, 367);
            this.Name = "FormAlterar";
            this.ResumeLayout(false);

    }
}