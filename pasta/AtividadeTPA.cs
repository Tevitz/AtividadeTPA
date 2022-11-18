using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_TPA
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int pt = 0;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Digite o nome de um time de futebol:");
                nome = Console.ReadLine();
   
                Console.WriteLine("Digite o ponto desse time:");
                pt = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
