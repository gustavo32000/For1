using System;

namespace For1
{
    class Program
    {
        static void Main(string[] args)
        {
        int qtd = 0;    


        for (int n = 1 ; n <=50 ; n++){
             if (n % 2 == 0){
                 Console.WriteLine("O numero " + n +" é par!");
                    qtd++;

             }
        }
             Console.BackgroundColor = ConsoleColor.Black;
             Console.ForegroundColor = ConsoleColor.White;
             Console.WriteLine ("Entre 0 e 50 há " +qtd+ " pares");   

        }
        
         
        }
    }

