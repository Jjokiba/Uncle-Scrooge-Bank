using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Uncle_Scrooge_Bank
{
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
            txtSaque.MaxLength = 8;
            txtSaque.Text = "0,00";
            valorDigitado = "";
            valorDigitado2 = "";
            //char[] saldo = (Data.saldo.ToString()).ToArray();
            /*for (int cont = 0; cont < saldo.Length; cont++)
            {
                if (cont % 3 == 0)
                {
                    saldo[cont] += '.';
                }
            }*/
            lblSaldo.Text = "Saldo atual: " + Data.saldo.ToString("C");
            //txtSaque.Enabled = false;
        }

        public string valorDigitado, valorDigitado2="";

        private void Sacar(object sender, EventArgs e)
        {
            if (Data.saldo >= Convert.ToDouble(txtSaque.Text))
            {
                valorDigitado2 = txtSaque.Text;
                valorDigitado2 = valorDigitado2.Replace(".", "");
                valorDigitado2 = valorDigitado2.Replace(",00", "");
                Data.valorDigitado2 = valorDigitado2.Replace(",00", "");
                

                if ((Convert.ToDouble(valorDigitado2) == 2 || Convert.ToDouble(valorDigitado2) == 4 || Convert.ToDouble(valorDigitado2) >= 5) && txtSaque.Text != "")
                {
                    

                    BackgroundImage = Image.FromFile("fundo_form1_3.png");
                    Resultado formResult = new Resultado();

                    this.Hide();
                    formResult.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Numero digitado invalido, por favor tente novamente com outro valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente, Tente depositar algum dinheiro antes de sacar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Limpar(object sender, EventArgs e)
        {
            txtSaque.Text = "0,00";
            valorDigitado = "";
            valorDigitado2 = "";
            this.BackgroundImage = Image.FromFile("fundo_form1_2.png");
        }

        private void tecladoNumerico(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("fundo_form1_3.png");
            if (txtSaque.Text.Length < 8)
            {
                if (!((sender as Button).Text == "0" && txtSaque.Text == "0,00"))
                {
                    valorDigitado += (sender as Button).Text;
                    valorDigitado2 += (sender as Button).Text;
                    if (valorDigitado2.Length == 4)
                        valorDigitado = valorDigitado2.Insert(1, ".");
                    txtSaque.Text = valorDigitado + ",00";
                    
                    Data.valorDigitado2 = valorDigitado2;
                }
            }
        }

        private void mudarFundo1(object sender, EventArgs e)
        {
            if (txtSaque.Text != "0,00")
            {
                valorDigitado2 = txtSaque.Text;
                valorDigitado2 = valorDigitado2.Replace(".", "");
                valorDigitado2 = valorDigitado2.Replace(",00", "");
                Data.valorDigitado2 = valorDigitado2.Replace(",00", "");
                
                
            }
            this.BackgroundImage = Image.FromFile("fundo_form1_4.png");
        }
        
        private void mudarFundo_1_2(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("fundo_form1_3.png");
        }

        public void mudarFundo2(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("fundo_form1_2.png");
        }

        private void mudarFundo3(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("fundo_form1_1.png");
            txtSaque.Focus();
        }

        private void validarBotão(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back)) && (txtSaque.Text != "" || txtSaque.Text != ",00"))
            {
                e.Handled = false;
                if (txtSaque.Text.Length == 0 && e.KeyChar != (char)(Keys.Back) && e.KeyChar != '0')
                {
                    txtSaque.Text += ",00";

                }
                else if(txtSaque.Text.Length == 1 && e.KeyChar != (char)(Keys.Back))
                {
                    txtSaque.Text += ",00";
                    txtSaque.SelectionStart = txtSaque.TextLength -3;
                }
                else if (txtSaque.Text.Length == 6 && e.KeyChar != (char)(Keys.Back))
                {
                    txtSaque.Text = txtSaque.Text.Insert(1, ".");
                    txtSaque.SelectionStart = txtSaque.TextLength - 3;
                }
                else if (e.KeyChar == (char)(Keys.Back))
                {
                    
                    txtSaque.Text = "";
                    valorDigitado = "";
                    valorDigitado2 = "";
                }
                
                //txtSaque.SelectionStart = txtSaque.TextLength - 3;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            FrmDeposit deposit = new FrmDeposit();
            this.Hide();
            deposit.ShowDialog();
            this.Close();
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        

        

        
        
    }
}
