using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int equaçao, contador, numero;

           
            Console.Write("INSIRA UM NUMERO PARA OBTER UMA TABUADA  : ");
            numero = Int32.Parse(Console.ReadLine());

            
            for (contador = 1; contador <= 10; ++contador)
            {
                equaçao =  numero * contador;
                Console.WriteLine(numero + "  x  " + contador + "  =  " + equaçao);
                
            }

            
        }

    }
}