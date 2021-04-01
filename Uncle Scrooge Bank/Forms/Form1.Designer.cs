namespace Uncle_Scrooge_Bank
{
    partial class Banco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banco));
            this.btn8 = new System.Windows.Forms.Button();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.SlateGray;
            this.btn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn8.BackgroundImage")));
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn8.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(535, 112);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 11;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.tecladoNumerico);
            // 
            // txtSaque
            // 
            this.txtSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaque.Location = new System.Drawing.Point(472, 60);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(192, 38);
            this.txtSaque.TabIndex = 0;
            this.txtSaque.Click += new System.EventHandler(this.mudarFundo3);
            this.txtSaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarBotão);
            this.txtSaque.Leave += new System.EventHandler(this.mudarFundo1);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.SlateGray;
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn2.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(535, 244);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 5;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.tecladoNumerico);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.SlateGray;
            this.btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5.BackgroundImage")));
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn5.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(535, 178);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 8;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.tecladoNumerico);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.SlateGray;
            this.btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4.BackgroundImage")));
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn4.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(469, 178);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 7;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.tecladoNumerico);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.SlateGray;
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn1.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(469, 244);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 4;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.tecladoNumerico);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.SlateGray;
            this.btn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn7.BackgroundImage")));
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn7.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(469, 112);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 10;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.tecladoNumerico);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.SlateGray;
            this.btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn6.BackgroundImage")));
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn6.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(601, 178);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 9;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.tecladoNumerico);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.SlateGray;
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(601, 244);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 6;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.tecladoNumerico);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.SlateGray;
            this.btn9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn9.BackgroundImage")));
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn9.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(601, 112);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 12;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.tecladoNumerico);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.SlateGray;
            this.btn0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn0.BackgroundImage")));
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn0.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(535, 310);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 60);
            this.btn0.TabIndex = 3;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.tecladoNumerico);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.SlateGray;
            this.btnSacar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSacar.BackgroundImage")));
            this.btnSacar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSacar.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.ForeColor = System.Drawing.Color.Black;
            this.btnSacar.Location = new System.Drawing.Point(288, 163);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(124, 60);
            this.btnSacar.TabIndex = 2;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.Sacar);
            this.btnSacar.Leave += new System.EventHandler(this.mudarFundo2);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SlateGray;
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(288, 229);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(124, 60);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.Limpar);
            this.btnLimpar.Leave += new System.EventHandler(this.mudarFundo3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(399, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 47);
            this.label1.TabIndex = 13;
            this.label1.Text = "R$";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(241, 9);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(222, 22);
            this.lblSaldo.TabIndex = 15;
            this.lblSaldo.Text = "Saldo atual: R$10.000.000";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.SlateGray;
            this.btnDeposit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeposit.BackgroundImage")));
            this.btnDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.Black;
            this.btnDeposit.Location = new System.Drawing.Point(288, 97);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(124, 60);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Depositar";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            this.btnDeposit.Leave += new System.EventHandler(this.mudarFundo_1_2);
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDeslogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeslogar.BackgroundImage")));
            this.btnDeslogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeslogar.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeslogar.ForeColor = System.Drawing.Color.Black;
            this.btnDeslogar.Location = new System.Drawing.Point(12, 12);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(124, 33);
            this.btnDeslogar.TabIndex = 17;
            this.btnDeslogar.Text = "Deslogar";
            this.btnDeslogar.UseVisualStyleBackColor = false;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            this.btnDeslogar.Leave += new System.EventHandler(this.mudarFundo3);
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Uncle_Scrooge_Bank.Properties.Resources.fundo_form1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 408);
            this.Controls.Add(this.btnDeslogar);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.btn8);
            this.DoubleBuffered = true;
            this.Name = "Banco";
            this.Text = "Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnDeslogar;
    }
}

