using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula143CriandoExecoesPersonalizadas.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string messagem) : base(message)
        {

        }
    }
}
