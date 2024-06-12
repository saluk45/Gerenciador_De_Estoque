namespace WinFormsApp1
{
    partial class TelaCadastroItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCadastroItem = new Label();
            SuspendLayout();
            // 
            // lblCadastroItem
            // 
            lblCadastroItem.AutoSize = true;
            lblCadastroItem.Location = new Point(175, 173);
            lblCadastroItem.Margin = new Padding(4, 0, 4, 0);
            lblCadastroItem.Name = "lblCadastroItem";
            lblCadastroItem.Size = new Size(96, 15);
            lblCadastroItem.TabIndex = 0;
            lblCadastroItem.Text = "Você está logado";
            // 
            // TelaCadastroItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 417);
            Controls.Add(lblCadastroItem);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TelaCadastroItem";
            Text = "TelaCadastroItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCadastroItem;
    }
}
