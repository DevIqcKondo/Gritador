using System;

namespace Gritador
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.WriteLine("Olá usuário");
            Console.Write("Qual é o seu nome? ");
            string nome=Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write(nome);
            Console.Write(", ");
            Console.Write("Você está bem? ");
            string estado=Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write(estado.ToUpper());
            Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.White;
            Console.Write("Por que você está gritando? ");
            Console.Write("Agora eu fiquei magoado :c ");
            Console.WriteLine();
            Console.ResetColor();
            
            


            
        }
    }
}
