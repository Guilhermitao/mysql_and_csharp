using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace naoseicara
{
    class Dao
    {
        private MySqlConnection conexao;
        private MySqlDataReader rdr;
        private MySqlCommand cmd;

        public Dao()
        {
            conexao = new MySqlConnection("server=localhost; database= phpmysql;uid=root;password=");

            try
            {
                conexao.Open();
            }catch (Exception e)
            {
                Console.WriteLine("erro");
            }
        }
        public bool verificarUsuario(Pessoa p)
        {
            string sql = "select * from login where usuario ='" + p.Usuario + "' and senha = '" + p.Senha + "'";
            cmd = new MySqlCommand(sql, conexao);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            return rdr.HasRows;
        }

        public void insertUsuario(Pessoa p)
        {
            String sql = "insert into login (id,usuario,senha) values (null,@usuario,@senha)";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@usuario", p.Usuario);
            cmd.Parameters.AddWithValue("@senha", p.Senha);
            cmd.ExecuteNonQuery();
        }

        public void deleteUsuario(Pessoa p)
        {
            String sql = "delete from login where id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.ExecuteNonQuery();
        }

        public MySqlDataReader listaUsuario()
        {
            string sql = "select * from login";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            rdr = cmd.ExecuteReader();
            return rdr;
        }
    }
}
