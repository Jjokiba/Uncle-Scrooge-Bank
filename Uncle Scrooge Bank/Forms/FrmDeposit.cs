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
    public partial class FrmDeposit : Form
    {
        public FrmDeposit()
        {
            InitializeComponent();
            txtDeposit.MaxLength = 6;
            lblSaldo.Text = "Saldo atual: " + Data.saldo.ToString("C");
            lblPosDeposito.Text = "Saldo pós-deposito: " + (Data.saldo + valorDeposito).ToString("C");
        }

        private int valorDeposito = 0;

        private void mascaraDinamica(object sender, KeyPressEventArgs e)
        {
            //if ((char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back) || e.KeyChar == ','))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            e.Handled = true;
            //}

        }

        private void AdicionarDois(object sender, EventArgs e)
        {
            //while (e == (char)(Keys.Enter))
            //{
                valorDeposito += 2;
                txtDeposit.Text = valorDeposito.ToString("C");
                lblPosDeposito.Text = "Saldo pós-deposito: " + (Data.saldo + valorDeposito).ToString("C");
            //}
        }

        private void adicionarCinco(object sender, EventArgs e)
        {
            valorDeposito += 5;
            txtDeposit.Text = valorDeposito.ToString("C");
            lblPosDeposito.Text = "Saldo pós-deposito: " + (Data.saldo + valorDeposito).ToString("C");
        }

        private void adicionarDez(object sender, EventArgs e)
        {
            valorDeposito += 10;
            txtDeposit.Text = valorDeposito.ToString("C");
            lblPosDeposito.Text = "Saldo pós-deposito: " + (Data.saldo + valorDeposito).ToString("C");
        }

        private void adicionarVinte(object sender, EventArgs e)
        {
            valorDeposito += 20;
            txtDeposit.Text = valorDeposito.ToString("C");
            lblPosDeposito.Text = "Saldo pós-deposito: " + (Data.saldo + valorDeposito).ToString("C");
        }

        private void adicionarCinquenta(object sender, EventArgs e)
        {
            valorDeposito += 50;
            txtDeposit.Text = valorDeposito.ToString("C");
            lblPosDeposito.Text = "Saldo pós-deposito: " + (Data.saldo + valorDeposito).ToString("C");
        }

        private void adicionarCem(object sender, EventArgs e)
        {
            valorDeposito += 100;
            txtDeposit.Text = valorDeposito.ToString("C");
            lblPosDeposito.Text = "Saldo pós-deposito: " + (Data.saldo + valorDeposito).ToString("C");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Data.saldo = Data.saldo + valorDeposito;
            Banco banco = new Banco();
            string update = "UPDATE login SET saldo =" + Data.saldo + " WHERE Id =" + Data.idLogado + "";
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand(update, conexao.conexao);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();
            this.Hide();
            banco.ShowDialog();
            this.Close();
            /*string update = "UPDATE login SET saldo = '" + Data.saldo + "' WHERE Id = '" + Data.idLogado + "'";
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand(update, conexao.conexao);
            cmd.ExecuteReader();
            MessageBox.Show("Saque realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);
            concluido = true;
            btnSacar.Enabled = false;
            btnFechar.Text = "Voltar";*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            this.Hide();
            banco.ShowDialog();
            this.Close();
        }

        private void TabIndexTo1(object sender, EventArgs e)
        {
            btnDoisReais.Focus();
        }

        

        
    }
}
