using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula48ConversaoDeMoeda
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        
        public static double ConversaoEmReais(double cotacao, double quantidade)
        {
            double conversaoDeDolarParaReal = cotacao * quantidade;
            double descontoDoIof = (conversaoDeDolarParaReal * Iof) / 100;
            
            return conversaoDeDolarParaReal + descontoDoIof;
        }
                
    }
}
