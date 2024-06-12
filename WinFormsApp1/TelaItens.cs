using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TelaItens : Form
    {
        public TelaItens()
        {
            InitializeComponent();
        }

        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            // Abre a tela de cadastro de item
            TelaCadastroItem telaCadastroItem = new TelaCadastroItem();
            telaCadastroItem.Show();
        }
    }
}
