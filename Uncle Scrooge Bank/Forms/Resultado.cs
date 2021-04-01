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
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
            maiorVariedade();
            menorQuantidade();
            btnSacar.Enabled = false;
            
        }
        
        public void menorQuantidade()
        {
            int valor = Int32.Parse(Data.valorDigitado2);
            int quantCem = 0, quantCinquenta = 0, quantVinte = 0, quantDez = 0, quantCinco = 0, quantDois = 0, aux = 0;
            if (valor % 2 > 0)
            {
                aux += 5;
                quantCinco++;
            }
            while (aux < valor)
            {
                aux += 100;
                quantCem++;
            }
            if (aux > valor)
            {
                aux -= 100;
                quantCem--;
            }
            while (aux < valor)
            {
                aux += 50;
                quantCinquenta++;
            }
            if (aux > valor)
            {
                aux -= 50;
                quantCinquenta--;
            }
            while (aux < valor)
            {
                aux += 20;
                quantVinte++;
            }
            if (aux > valor)
            {
                aux -= 20;
                quantVinte--;
            }
            while (aux < valor)
            {
                aux += 10;
                quantDez++;
            }
            if (aux > valor)
            {
                aux -= 10;
                quantDez--;
            }
            if (aux > valor)
            {
                aux -= 5;
                quantCinco--;
            }
            while (aux < valor)
            {
                aux += 2;
                quantDois++;
            }
            if (aux > valor)
            {
                aux -= 2;
                quantDois--;
            }
            if (valor > aux)
            {
                MessageBox.Show("Não é possível realizar o saque pois as notas disponíveis não atendem a demanda.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else
            //  MessageBox.Show("R$100 = " + quantCem + ", R$50 = " + quantCinquenta + ", R$20 = " + quantVinte + ", R$10 = " + quantDez + ", R$5 = " + quantCinco + ", R$2 = " + quantDois, "Quantidades");
            lblNota100Menor.Text = quantCem.ToString();
            lblNota50Menor.Text = quantCinquenta.ToString();
            lblNota20Menor.Text = quantVinte.ToString();
            lblNota10Menor.Text = quantDez.ToString();
            lblNota5Menor.Text = quantCinco.ToString();
            lblNota2Menor.Text = quantDois.ToString();
        }

        public void maiorVariedade()
        {
            int nota2 = 0, nota5 = 0, nota10 = 0, nota20 = 0, nota50 = 0, nota100 = 0;
            int valorCopia = Int32.Parse(Data.valorDigitado2), valorBackup = Int32.Parse(Data.valorDigitado2);
            int nota5Maximo = maximoNota5(valorCopia);
            do
            {
                valorCopia -= 2;
                if (valorCopia < 0 || (valorBackup % 5 == 0))
                {
                    valorCopia = valorBackup;

                }
                else
                {
                    nota2++;
                    valorBackup = valorCopia;//atualizar o valor de backup caso a conta informe um valor negativo;
                }
                if (nota5Maximo > nota5)
                {
                    valorCopia -= 5;
                    if (valorCopia < 0)
                    {
                        valorCopia = valorBackup;

                    }
                    else
                    {
                        nota5++;
                        valorBackup = valorCopia;//atualizar o valor de backup caso a conta informe um valor negativo;
                    }
                    if (valorCopia % 2 != 0 )
                    {
                        valorCopia -= 5;
                        if (valorCopia < 0)
                        {
                            valorCopia = valorBackup;

                        }
                        else
                        {
                            nota5++;
                            valorBackup = valorCopia;//atualizar o valor de backup caso a conta informe um valor negativo;
                        }
                    }
                }
                valorCopia -= 10;
                if (valorCopia < 0)
                {
                    valorCopia = valorBackup;

                }
                else
                {
                    nota10++;
                    valorBackup = valorCopia;//atualizar o valor de backup caso a conta informe um valor negativo;
                }
                valorCopia -= 20;
                if (valorCopia < 0)
                {
                    valorCopia = valorBackup;

                }
                else
                {
                    nota20++;
                    valorBackup = valorCopia;//atualizar o valor de backup caso a conta informe um valor negativo;
                }
                valorCopia -= 50;
                if (valorCopia < 0)
                {
                    valorCopia = valorBackup;

                }
                else
                {
                    nota50++;
                    valorBackup = valorCopia;//atualizar o valor de backup caso a conta informe um valor negativo;
                }
                valorCopia -= 100;
                if (valorCopia < 0)
                {
                    valorCopia = valorBackup;

                }
                else
                {
                    nota100++;
                    valorBackup = valorCopia;//atualizar o valor de backup caso a conta informe um valor negativo;
                }

            } while (valorCopia != 0);
            lblNota100Maior.Text = nota100.ToString();
            lblNota50Maior.Text = nota50.ToString();
            lblNota20Maior.Text = nota20.ToString();
            lblNota10Maior.Text = nota10.ToString();
            lblNota5Maior.Text = nota5.ToString();
            lblNota2Maior.Text = nota2.ToString();
        }

        private int maximoNota5(int i)
        {
            int nota5Max=0;
            do
            {
                if (i >= 5)
                {
                    i = i - 5;
                    nota5Max++;
                }

            } while (i >= 5);
            return nota5Max;
        }

        private void Fechar(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            this.Hide();
            banco.ShowDialog();
            this.Close();
        }
        private bool concluido = false;

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (concluido == false)
            {
                
                Data.saldo = Data.saldo - double.Parse(Data.valorDigitado2);
                string update = "UPDATE login SET saldo =" + Data.saldo + " WHERE Id =" + Data.idLogado + "";
                ClsConexao conexao = new ClsConexao();
                conexao.conectar();

                SqlCommand cmd = new SqlCommand(update, conexao.conexao);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                conexao.desconectar();
                
                /*string update = "update login set saldo=@saldo where id=@Id";
                ClsConexao conexao = new ClsConexao();
                conexao.conectar();

                SqlCommand cmd = new SqlCommand(update, conexao.conexao);
                cmd.Parameters.AddWithValue("@saldo", Convert.ToDecimal(label1.Text));
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(label2.Text));
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                conexao.desconectar();*/
               
                MessageBox.Show("Saque realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                concluido = true;
                btnSacar.Enabled = false;
                btnFechar.Text = "Voltar";
            }
            /*    string query = "SELECT * from login as L where L.login = '" + txtLogin.Text + "' AND L.senha = '" + txtSenha.Text + "'";
            ClsConexao conexao = new ClsConexao();
            try
            {
                conexao.conectar();
                SqlCommand cmd = new SqlCommand(query, conexao.conexao);
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Data.saldo = double.Parse(dr["saldo"].ToString());
                    Data.idLogado = Int16.Parse(dr["Id"].ToString());
                    return true;*/
        }

        private void OpcaoSelecionada(object sender, EventArgs e)
        {
            if (concluido == false)
            {
                btnSacar.Enabled = true;
            }
        }
    }
}
