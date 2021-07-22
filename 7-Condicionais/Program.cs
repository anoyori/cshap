using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 7");

            int idadeJoao = 16;

            if(idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de 18 anos");
            }
            else
            {
                Console.WriteLine("João é menor de idade");
            }

            Console.ReadLine();
        }
    }
}
