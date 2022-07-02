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
            if (tbUsuario.Text == "" ||tbSenha.Text == "")
            {
                lblEntrarInvalido.Text = "Campos em branco";
            }
            else if(tbUsuario.Text == "Douglas" && tbSenha.Text == "Douglas")
            {
                lblEntrarInvalido.ForeColor = System.Drawing.Color.Green;
                lblEntrarInvalido.Text = ("Bem vindo " + tbUsuario.Text);
            }
            else
            {
                lblEntrarInvalido.Text = "Usuário ou senha inválidos";
            }
        }
    }
}