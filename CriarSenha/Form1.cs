using System;
using System.IO;
using System.Windows.Forms;

public partial class FormLogin : Form
{
    string arquivo = "usuarios.txt";

    public FormLogin()
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
}