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
