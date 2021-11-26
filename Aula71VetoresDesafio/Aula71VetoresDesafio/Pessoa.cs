using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula71VetoresDesafio
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
              

        public override string ToString()
        {
            return Nome
                + ", "
                + Email;
        }
    }
}
