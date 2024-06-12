using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1
{


    
    partial class TelaItens
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
            this.btnAlterarQuantidadeItem = new System.Windows.Forms.Button();
            this.txtProcessador = new System.Windows.Forms.Label(); 
            this.txtMemoriasFlash = new System.Windows.Forms.Label();
            this.txtCristaisDeClock = new System.Windows.Forms.Label();
            this.txtDisplayParaIHM = new System.Windows.Forms.Label();
            this.txtSoquetesDoProcessador = new System.Windows.Forms.Label();
            this.txtDissipadoresDeCalor = new System.Windows.Forms.Label();
            this.txtFonteDeAlimentacao = new System.Windows.Forms.Label();

            this.lblProcessador = new System.Windows.Forms.Label();
            this.lblMemoriasFlash = new System.Windows.Forms.Label();
            this.lblCristaisDeClock = new System.Windows.Forms.Label();
            this.lblDisplayParaIHM = new System.Windows.Forms.Label();
            this.lblSoquetesDoProcessador = new System.Windows.Forms.Label();
            this.lblDissipadoresDeCalor = new System.Windows.Forms.Label();
            this.lblFonteDeAlimentacao = new System.Windows.Forms.Label();

            this.SuspendLayout();


            // texto mostrando a quantidade  da Processador
            int processadorQnt = 0;                                           // variavel que armazena a quantidade de itens no estoque
            processadorQnt = Banco.PegarValorProcessador(processadorQnt);     //metodo para pegar o valor do banco e atribuir a variavel
            this.txtProcessador.Location = new System.Drawing.Point(150, 30); //localização na pagina
            this.txtProcessador.Name = "txtProcessador";                      //nome do objeto
            this.txtProcessador.Size = new System.Drawing.Size(200, 30);      //tamanho do texto
            this.txtProcessador.Text = "" + processadorQnt;                   //valor do texto

            // texto mostrando a quantidade  da MemoriasFlash
            int MemoriasFlashQnt = 0;
            MemoriasFlashQnt = Banco.PegarValorMemoriasFlash(MemoriasFlashQnt);
            this.txtMemoriasFlash.Location = new System.Drawing.Point(150, 70); 
            this.txtMemoriasFlash.Name = "txtMemoriasFlash";
            this.txtMemoriasFlash.Size = new System.Drawing.Size(200, 20);
            this.txtMemoriasFlash.Text = "" + MemoriasFlashQnt;

            // texto mostrando a quantidade  da CristaisDeClock
            int CristaisDeClockQnt = 0;
            CristaisDeClockQnt = Banco.PegarValorCristaisDeClock(CristaisDeClockQnt);
            this.txtCristaisDeClock.Location = new System.Drawing.Point(150, 110); 
            this.txtCristaisDeClock.Name = "txtCristaisDeClock";
            this.txtCristaisDeClock.Size = new System.Drawing.Size(200, 20);
            this.txtCristaisDeClock.Text = "" + CristaisDeClockQnt;

            // texto mostrando a quantidade  da DisplayParaIHM
            int DisplayParaIHMQnt = 0;
            DisplayParaIHMQnt = Banco.PegarValorDisplayParaIHM(DisplayParaIHMQnt);
            this.txtDisplayParaIHM.Location = new System.Drawing.Point(150, 150);
            this.txtDisplayParaIHM.Name = "txtDisplayParaIHM";
            this.txtDisplayParaIHM.Size = new System.Drawing.Size(200, 20);
            this.txtDisplayParaIHM.Text = "" + DisplayParaIHMQnt;

            // texto mostrando a quantidade  da SoquetesDoProcessador
            int SoquetesDoProcessadorQnt = 0;
            SoquetesDoProcessadorQnt = Banco.PegarValorSoquetesDoProcessador(SoquetesDoProcessadorQnt);
            this.txtSoquetesDoProcessador.Location = new System.Drawing.Point(150, 190);
            this.txtSoquetesDoProcessador.Name = "txtSoquetesDoProcessador";
            this.txtSoquetesDoProcessador.Size = new System.Drawing.Size(200, 20);
            this.txtSoquetesDoProcessador.Text = "" + SoquetesDoProcessadorQnt;

            // texto mostrando a quantidade  da DissipadoresDeCalor
            int DissipadoresDeCalorQnt = 0;
            DissipadoresDeCalorQnt = Banco.PegarValorDissipadoresDeCalor(DissipadoresDeCalorQnt);
            this.txtDissipadoresDeCalor.Location = new System.Drawing.Point(150, 230);
            this.txtDissipadoresDeCalor.Name = "txtDissipadoresDeCalor";
            this.txtDissipadoresDeCalor.Size = new System.Drawing.Size(200, 20);
            this.txtDissipadoresDeCalor.Text = "" + DissipadoresDeCalorQnt;

            // texto mostrando a quantidade  da FonteDeAlimentacao
            int FonteAlimentacaoQnt = 0;
            FonteAlimentacaoQnt = Banco.PegarValorFonteDeAlimentacao(FonteAlimentacaoQnt);
            this.txtFonteDeAlimentacao.AutoSize = true;
            this.txtFonteDeAlimentacao.Location = new System.Drawing.Point(150, 270);
            this.txtFonteDeAlimentacao.Name = "txtFonteDeAlimentacao";
            this.txtFonteDeAlimentacao.Size = new System.Drawing.Size(68, 13);
            this.txtFonteDeAlimentacao.TabIndex = 7;
            this.txtFonteDeAlimentacao.Text = "" + FonteAlimentacaoQnt;




            // Titulo antes da quantidade

            // PROCESSADOR
            this.lblProcessador.AutoSize = true;
            this.lblProcessador.Location = new System.Drawing.Point(30, 30);
            this.lblProcessador.Name = "lblProcessador";
            this.lblProcessador.Size = new System.Drawing.Size(68, 13);
            this.lblProcessador.TabIndex = 7;
            this.lblProcessador.Text = "Processador";

            // MemoriasFlash
            this.lblMemoriasFlash.AutoSize = true;
            this.lblMemoriasFlash.Location = new System.Drawing.Point(30, 70);
            this.lblMemoriasFlash.Name = "lblMemoriasFlash";
            this.lblMemoriasFlash.Size = new System.Drawing.Size(86, 13);
            this.lblMemoriasFlash.TabIndex = 8;
            this.lblMemoriasFlash.Text = "Memórias Flash";
            
            //CristaisDeClock
            this.lblCristaisDeClock.AutoSize = true;
            this.lblCristaisDeClock.Location = new System.Drawing.Point(30, 110);
            this.lblCristaisDeClock.Name = "lblCristaisDeClock";
            this.lblCristaisDeClock.Size = new System.Drawing.Size(84, 13);
            this.lblCristaisDeClock.TabIndex = 9;
            this.lblCristaisDeClock.Text = "Cristais de Clock";
            
            //DisplayParaIHM
            this.lblDisplayParaIHM.AutoSize = true;
            this.lblDisplayParaIHM.Location = new System.Drawing.Point(30, 150);
            this.lblDisplayParaIHM.Name = "lblDisplayParaIHM";
            this.lblDisplayParaIHM.Size = new System.Drawing.Size(89, 13);
            this.lblDisplayParaIHM.TabIndex = 10;
            this.lblDisplayParaIHM.Text = "Display para IHM";
            
            //SoquetesDoProcessador
            this.lblSoquetesDoProcessador.AutoSize = true;
            this.lblSoquetesDoProcessador.Location = new System.Drawing.Point(30, 190);
            this.lblSoquetesDoProcessador.Name = "lblSoquetesDoProcessador";
            this.lblSoquetesDoProcessador.Size = new System.Drawing.Size(123, 13);
            this.lblSoquetesDoProcessador.TabIndex = 11;
            this.lblSoquetesDoProcessador.Text = "Soquetes do Processador";
            
            //DissipadoresDeCalor
            this.lblDissipadoresDeCalor.AutoSize = true;
            this.lblDissipadoresDeCalor.Location = new System.Drawing.Point(30, 230);
            this.lblDissipadoresDeCalor.Name = "lblDissipadoresDeCalor";
            this.lblDissipadoresDeCalor.Size = new System.Drawing.Size(109, 13);
            this.lblDissipadoresDeCalor.TabIndex = 12;
            this.lblDissipadoresDeCalor.Text = "Dissipadores de Calor";
            
            //FonteDeAlimentacao
            this.lblFonteDeAlimentacao.AutoSize = true;
            this.lblFonteDeAlimentacao.Location = new System.Drawing.Point(30, 270);
            this.lblFonteDeAlimentacao.Name = "lblFonteDeAlimentacao";
            this.lblFonteDeAlimentacao.Size = new System.Drawing.Size(107, 13);
            this.lblFonteDeAlimentacao.TabIndex = 13;
            this.lblFonteDeAlimentacao.Text = "Fonte de Alimentação";

            //Botao na tela, com escrito CadastrarItem
            this.btnAlterarQuantidadeItem.Location = new System.Drawing.Point(150, 310);
            this.btnAlterarQuantidadeItem.Name = "btnAlterarQuantidadeItem";
            this.btnAlterarQuantidadeItem.Size = new System.Drawing.Size(200, 23);
            this.btnAlterarQuantidadeItem.TabIndex = 14;
            this.btnAlterarQuantidadeItem.Text = "AlterarQuantidadeItem";
            this.btnAlterarQuantidadeItem.UseVisualStyleBackColor = true;
            this.btnAlterarQuantidadeItem.Click += new System.EventHandler(this.btnAlterarQuantidadeItem_click);

            



            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnAlterarQuantidadeItem);
            this.Controls.Add(this.lblFonteDeAlimentacao);
            this.Controls.Add(this.lblDissipadoresDeCalor);
            this.Controls.Add(this.lblSoquetesDoProcessador);
            this.Controls.Add(this.lblDisplayParaIHM);
            this.Controls.Add(this.lblCristaisDeClock);
            this.Controls.Add(this.lblMemoriasFlash);
            this.Controls.Add(this.lblProcessador);
            this.Controls.Add(this.txtFonteDeAlimentacao);
            this.Controls.Add(this.txtDissipadoresDeCalor);
            this.Controls.Add(this.txtSoquetesDoProcessador);
            this.Controls.Add(this.txtDisplayParaIHM);
            this.Controls.Add(this.txtCristaisDeClock);
            this.Controls.Add(this.txtMemoriasFlash);
            this.Controls.Add(this.txtProcessador);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label txtProcessador;
        private System.Windows.Forms.Label txtMemoriasFlash;
        private System.Windows.Forms.Label txtCristaisDeClock;
        private System.Windows.Forms.Label txtDisplayParaIHM;
        private System.Windows.Forms.Label txtSoquetesDoProcessador;
        private System.Windows.Forms.Label txtDissipadoresDeCalor;
        private System.Windows.Forms.Label txtFonteDeAlimentacao;

        private System.Windows.Forms.Label lblProcessador;
        private System.Windows.Forms.Label lblMemoriasFlash;
        private System.Windows.Forms.Label lblCristaisDeClock;
        private System.Windows.Forms.Label lblDisplayParaIHM;
        private System.Windows.Forms.Label lblSoquetesDoProcessador;
        private System.Windows.Forms.Label lblDissipadoresDeCalor;
        private System.Windows.Forms.Label lblFonteDeAlimentacao;
        private System.Windows.Forms.Button btnAlterarQuantidadeItem;
    }
}
