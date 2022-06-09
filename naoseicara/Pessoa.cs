using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naoseicara
{
    class Pessoa
    {
        private int id;
        private string senha;
        private string usuario;

        public int Id
        {
            get
            {
                return id;
            }//get return id
        }//public string Id

        public string Senha
        {
            get
            {
                return senha;
            }//get return senha

        }//public string Senha

        public string Usuario
        {
            get
            {
                return usuario;
            }//get return usuario

        }//public string Usuario

        public void cadastrar()
        {
            Console.WriteLine("Digite o nome do usuario:");
            this.usuario = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuario:");
            this.senha = Console.ReadLine();
        }//public void cadastrar
    }
}
