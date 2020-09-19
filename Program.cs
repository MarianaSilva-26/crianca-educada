using System;

namespace crianca_educada
{
    class Program
    {
        static void Main(string[] args)
        {
            string educado;

            Console.WriteLine("Me diga o que você pensa sobre o aluno que não faz a lição de casa:");
            educado = Console.ReadLine();
            Console.Write("\n ");
            //<---fim(digite)--->//

            //<---inicio(substituição)--->//
            Console.WriteLine("eu sou uma crinça educada. no seu lugar eu diria:"); 
            educado = Console.ReadLine();
            Console.WriteLine($"{educado}"
            .Replace("chato" , "#@$%*!&")

            .Replace("chto" , "#@$%*!&")

            .Replace("feio" , "#@$%*!&")

            .Replace("tonto" , "#@$%*!&")

            .Replace("paspalho" , "#@$%*!&")

            .Replace("pentelho" , "#@$%*!&")

            .Replace("burro" , "#@$%*!&")

            .Replace("boboca" , "#@$%*!&")

            .Replace("bocó" , "#@$%*!&")

            .Replace("palerma" , "#@$%*!&")

            .Replace("panaca" , "#@$%*!&")

            .Replace("besta" , "#@$%*!&"));
            //<---fim(subtituição)--->//

            //<---inicio(sair)--->//
            Console.WriteLine("pressione enter para finalizar");
            Console.ReadKey();
            //<---fim(sair)--->//
        }
    }
}
