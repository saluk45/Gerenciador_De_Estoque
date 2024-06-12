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

        private void btnAlterarQuantidadeItem_click(object sender, EventArgs e)
        {
            // Abre a tela de cadastro de item
            AlterarQuantidadeItem AlterarQuantidadeItem = new AlterarQuantidadeItem();
            AlterarQuantidadeItem.Show();
        }
    }
}
