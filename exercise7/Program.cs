using System;
using System.Globalization;

namespace exercise7
{
    public class _exercise7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua senha");
            int senha = int.Parse(Console.ReadLine());  

            while ( senha != 2002)
            {
                Console.WriteLine("Senha incorreta! Digite novamente");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido! Seja bem vindo");
        }
    }
    
}