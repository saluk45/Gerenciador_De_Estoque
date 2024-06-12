namespace WinFormsApp1
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            Banco.conectar();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
