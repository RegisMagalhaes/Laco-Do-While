using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Você deseja receber um bom dia?");

            string resposta = "";

            int numeroDeVezes = 0;

            do
            {
                //O programa executa pelo menos uma vez
                Console.WriteLine("Bom dia");

                Console.WriteLine("Ainda deseja receber bom dia?");

                numeroDeVezes++;

                resposta = Console.ReadLine();

            } while(resposta == "Sim");

            Console.WriteLine($"Numero de vezes: {numeroDeVezes}");
            Console.WriteLine("Fim do programa");
        }
    }
}
