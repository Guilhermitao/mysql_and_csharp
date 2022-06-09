using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naoseicara
{
    class Program
    {
        static void Main(string[] args)
        {
            Dao dao = new Dao();
            Pessoa p = new Pessoa();
            var rdr = dao.listaUsuario();

            while (rdr.Read())
            {
                Console.WriteLine("Id:{0}", rdr["id"]);
                Console.WriteLine("Usuario:{0}", rdr["usuario"]);
                Console.WriteLine("Senha:{0}", rdr["senha"]);
            }
            Console.ReadKey();

            p.cadastrar();
            dao.insertUsuario(p);
            dao.deleteUsuario(p);

            if (dao.verificarUsuario(p))
            {
                Console.WriteLine("Usuario registrado");
            }
            else
            {
                Console.WriteLine("Usuario ou senha invalida");
            }
            Console.ReadKey();
        }
    }
}
