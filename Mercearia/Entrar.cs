using System.Security.Cryptography;

namespace Mercearia
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var hashSenha = Program.sha256encrypt(tbSenha.Text);

            if (tbUsuario.Text == String.Empty || tbSenha.Text == String.Empty)
                {
                    lblEntrarInvalido.Text = "Campos em branco";
                }
                else if (tbUsuario.Text == "Douglads" && hashSenha == "D4460C6D9AA2BF8D2E6D91F392B95D3663D7435B8EF00B53643DC595E1DD68CF")
                {
                    lblEntrarInvalido.ForeColor = System.Drawing.Color.Green;
                    lblEntrarInvalido.Text = ("Bem vindo " + tbUsuario.Text);
                }
                else if (tbUsuario.Text != String.Empty && tbSenha.Text.Length < 8)
                {
                    lblEntrarInvalido.Text = ("A senha deve ter mais de 8 caracteres");
                }
                else
                {
                    lblEntrarInvalido.Text = "Usuário ou senha inválidos";
                }
        }
    }
}