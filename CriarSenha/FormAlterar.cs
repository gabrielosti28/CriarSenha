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
}