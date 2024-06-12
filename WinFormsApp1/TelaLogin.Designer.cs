using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    partial class TelaLogin : Form
    {
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Verifica se o login e a senha são "admin"
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login realizado com sucesso!");
                TelaItens form2 = new TelaItens();
                form2.Show();
                this.Hide();

                
            }
            else
            {
                MessageBox.Show("Senha inválida. Tente novamente.");
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Aqui você pode implementar a lógica para abrir a página de cadastro
            MessageBox.Show("Implemente a lógica para abrir a página de cadastro.");
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            linkRegister = new LinkLabel();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(189, 230);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(88, 27);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(117, 115);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(233, 23);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(117, 173);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(233, 23);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Location = new Point(117, 288);
            linkRegister.Margin = new Padding(4, 0, 4, 0);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(206, 15);
            linkRegister.TabIndex = 4;
            linkRegister.TabStop = true;
            linkRegister.Text = "Se você não tem cadastro, clique aqui";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(100, 62);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(267, 15);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Bem-vindo ao aplicativo. Insira seu login e senha:";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 359);
            Controls.Add(lblWelcome);
            Controls.Add(linkRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label lblWelcome; // Adicionando o Label
    }
}
