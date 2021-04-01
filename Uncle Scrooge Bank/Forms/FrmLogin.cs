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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
            //txtSenha.PasswordChar = "";
            
        }

        private bool validarLogin()
        {
            string query = "SELECT * from login as L where L.login = '" + txtLogin.Text + "' AND L.senha = '" + txtSenha.Text + "'";
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
                    return true;
                }
                else
                {
                    MessageBox.Show("Usuario ou senha inválidos");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validarLogin())
            {
                Banco frm = new Banco();
                //
                this.Hide();
                frm.ShowDialog();
                this.Close();
                //this.Hide();
                

            }
            
        }

        private void ExibirSenha(object sender, EventArgs e)
        {
            if (chkExibirSenha.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        
    }
}
