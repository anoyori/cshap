using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            char primeiraLetra = 'a';
            string nome = "Amanda";

            Console.WriteLine(primeiraLetra + nome);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia " + 2021;
            Console.WriteLine(titulo);

            string cursos = 
@"- .NET
- Java
- Javascript";

            Console.WriteLine(cursos);


            Console.ReadLine();
        }
    }
}
