namespace Uncle_Scrooge_Bank
{
    partial class FrmDeposit
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
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnDoisReais = new System.Windows.Forms.Button();
            this.btnCincoReais = new System.Windows.Forms.Button();
            this.btnDezReais = new System.Windows.Forms.Button();
            this.btnCemReais = new System.Windows.Forms.Button();
            this.btnCinquentaReais = new System.Windows.Forms.Button();
            this.btnVinteReais = new System.Windows.Forms.Button();
            this.lblPosDeposito = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(45, 59);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(346, 38);
            this.txtDeposit.TabIndex = 1;
            this.txtDeposit.Text = "R$0,00";
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mascaraDinamica);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(47, 100);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(222, 22);
            this.lblSaldo.TabIndex = 16;
            this.lblSaldo.Text = "Saldo atual: R$10.000.000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Valor depositado:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(66, 367);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(152, 59);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar\r\nDeposito\r\n";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnDoisReais
            // 
            this.btnDoisReais.BackgroundImage = global::Uncle_Scrooge_Bank.Properties.Resources.Nota2Reais;
            this.btnDoisReais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoisReais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoisReais.Location = new System.Drawing.Point(66, 125);
            this.btnDoisReais.Name = "btnDoisReais";
            this.btnDoisReais.Size = new System.Drawing.Size(152, 64);
            this.btnDoisReais.TabIndex = 20;
            this.btnDoisReais.UseVisualStyleBackColor = true;
            this.btnDoisReais.Click += new System.EventHandler(this.AdicionarDois);
            // 
            // btnCincoReais
            // 
            this.btnCincoReais.BackgroundImage = global::Uncle_Scrooge_Bank.Properties.Resources.Nota5Reais;
            this.btnCincoReais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCincoReais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCincoReais.Location = new System.Drawing.Point(66, 195);
            this.btnCincoReais.Name = "btnCincoReais";
            this.btnCincoReais.Size = new System.Drawing.Size(152, 64);
            this.btnCincoReais.TabIndex = 21;
            this.btnCincoReais.UseVisualStyleBackColor = true;
            this.btnCincoReais.Click += new System.EventHandler(this.adicionarCinco);
            // 
            // btnDezReais
            // 
            this.btnDezReais.BackgroundImage = global::Uncle_Scrooge_Bank.Properties.Resources.Nota10Reais;
            this.btnDezReais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDezReais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDezReais.Location = new System.Drawing.Point(66, 265);
            this.btnDezReais.Name = "btnDezReais";
            this.btnDezReais.Size = new System.Drawing.Size(152, 64);
            this.btnDezReais.TabIndex = 22;
            this.btnDezReais.UseVisualStyleBackColor = true;
            this.btnDezReais.Click += new System.EventHandler(this.adicionarDez);
            // 
            // btnCemReais
            // 
            this.btnCemReais.BackgroundImage = global::Uncle_Scrooge_Bank.Properties.Resources.Nota100Reais;
            this.btnCemReais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCemReais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCemReais.Location = new System.Drawing.Point(224, 265);
            this.btnCemReais.Name = "btnCemReais";
            this.btnCemReais.Size = new System.Drawing.Size(152, 64);
            this.btnCemReais.TabIndex = 25;
            this.btnCemReais.UseVisualStyleBackColor = true;
            this.btnCemReais.Click += new System.EventHandler(this.adicionarCem);
            // 
            // btnCinquentaReais
            // 
            this.btnCinquentaReais.BackgroundImage = global::Uncle_Scrooge_Bank.Properties.Resources.Nota50Reais;
            this.btnCinquentaReais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCinquentaReais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinquentaReais.Location = new System.Drawing.Point(224, 195);
            this.btnCinquentaReais.Name = "btnCinquentaReais";
            this.btnCinquentaReais.Size = new System.Drawing.Size(152, 64);
            this.btnCinquentaReais.TabIndex = 24;
            this.btnCinquentaReais.UseVisualStyleBackColor = true;
            this.btnCinquentaReais.Click += new System.EventHandler(this.adicionarCinquenta);
            // 
            // btnVinteReais
            // 
            this.btnVinteReais.BackgroundImage = global::Uncle_Scrooge_Bank.Properties.Resources.Nota20Reais;
            this.btnVinteReais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVinteReais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVinteReais.Location = new System.Drawing.Point(224, 125);
            this.btnVinteReais.Name = "btnVinteReais";
            this.btnVinteReais.Size = new System.Drawing.Size(152, 64);
            this.btnVinteReais.TabIndex = 23;
            this.btnVinteReais.UseVisualStyleBackColor = true;
            this.btnVinteReais.Click += new System.EventHandler(this.adicionarVinte);
            // 
            // lblPosDeposito
            // 
            this.lblPosDeposito.AutoSize = true;
            this.lblPosDeposito.BackColor = System.Drawing.Color.Transparent;
            this.lblPosDeposito.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosDeposito.Location = new System.Drawing.Point(47, 342);
            this.lblPosDeposito.Name = "lblPosDeposito";
            this.lblPosDeposito.Size = new System.Drawing.Size(292, 22);
            this.lblPosDeposito.TabIndex = 26;
            this.lblPosDeposito.Text = "Saldo pós-deposito: R$10.000.000";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(224, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 59);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar\r\nDeposito\r\n";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Uncle_Scrooge_Bank.Properties.Resources.fundo_deposito;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblPosDeposito);
            this.Controls.Add(this.btnCemReais);
            this.Controls.Add(this.btnCinquentaReais);
            this.Controls.Add(this.btnVinteReais);
            this.Controls.Add(this.btnDezReais);
            this.Controls.Add(this.btnCincoReais);
            this.Controls.Add(this.btnDoisReais);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtDeposit);
            this.DoubleBuffered = true;
            this.Name = "FrmDeposit";
            this.Text = "FrmDeposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnDoisReais;
        private System.Windows.Forms.Button btnCincoReais;
        private System.Windows.Forms.Button btnDezReais;
        private System.Windows.Forms.Button btnCemReais;
        private System.Windows.Forms.Button btnCinquentaReais;
        private System.Windows.Forms.Button btnVinteReais;
        private System.Windows.Forms.Label lblPosDeposito;
        private System.Windows.Forms.Button btnCancelar;
    }
}