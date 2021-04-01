using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Uncle_Scrooge_Bank
{
    class ClsConexao
    {
        public SqlConnection conexao = new SqlConnection();
        public void conectar()
        {
            desconectar();
            string startupPath = Environment.CurrentDirectory;
            startupPath = startupPath.Substring(0,startupPath.Length-9);
            conexao.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + startupPath + "bancoDeDados.mdf;Integrated Security=True";
            conexao.Open();
        }
        public void desconectar()
        {
            conexao.Close();
        }
    }
}
