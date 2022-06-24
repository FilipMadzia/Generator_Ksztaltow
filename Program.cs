using System;

namespace Kształty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Witaj w generatorze kształtów! =====");
            Home();
        }

        static void Home()
        {
            Console.WriteLine("\nJaki kształt chcesz stworzyć?:\nProstokąt: 1\nTrójkąt: 2\nRomb: 3");

            string shape = Console.ReadLine();
            switch(shape)
            {
                case "1":
                    Rectangle();
                    break;
                
                case "2":
                    Triangle();
                    break;

                case "3":
                    Diamond();
                    break;
                
                case "exit":
                    break;
                
                default:
                    Console.WriteLine("Błąd: brak opcji " + shape);
                    Home();
                    break;
            }
        }

        static void Rectangle()
        {
            // pytanie o aspekty prostokąta
            Console.Write("Podaj szerokość prostokąta: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Podaj wysokość prostokąta: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Podaj wypełnienie prostokąta: ");
            string inside = Console.ReadLine();

            // z wcześniej wpisanych argumentów funkcja generuje prostokąt
            Console.WriteLine("\nTwój prostokąt:\n");

            for(int j = 0; j < height; j++)
            {
                for(int i = 0; i < width; i++)
                {
                    Console.Write(inside);
                }

                Console.WriteLine();
            }
            End();
        }

        static void Triangle()
        {
            // pytanie o aspekty trójkąta
            Console.Write("Podaj wysokość trójkąta: ");
            int levels = int.Parse(Console.ReadLine());

            Console.Write("Podaj wypełnienie trójkąta: ");
            string inside = Console.ReadLine();

            // pętla odpowiedzialna za wysokość trójkąta
            for(int i = 0; i < levels; i++)
            {
                // pisanie spacji przed trójkątem
                for(int j = 0; j < levels - i; j++)
                {
                    Console.Write(" ");
                }

                // trójkąt 
                for(int k = 0; k <i; k++)
                {
                    Console.Write(inside + " ");
                }

                Console.WriteLine();
            }
            End();
        }

        static void Diamond()
        {
            // pytanie o aspekty rombu
            Console.Write("Podaj wysokość rombu: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Podaj wypełnienie rombu: ");
            string inside = " " + Console.ReadLine();

            // zmniejszanie wysokości o połowę, ponieważ generowane są dwa trójkąty o tej samej wysokości więc height = height * 2
            height = (height / 2) + 1;

            // górny trójkąt
            for(int i = 0; i < height; i++)
		    {			
                for(int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }
                
                for(int k = 0; k < i; k++)
                {
                    Console.Write(inside);
                }
                
                Console.WriteLine();
		    }

            // dolny trójkąt
            for(int a = 0; a < height; a++)
		    {
                for(int b = 0; b < a; b++)
                {
                    Console.Write(" ");
                }
                
                for(int c = height; c > a; c--)
                {
                    Console.Write(inside);
                }
                
                Console.WriteLine();
		    }

            End();
        }

        static void End()
        {
            // koniec programu i powrót do generatora
            Console.WriteLine("Wciśnij dowolny klawisz aby powrócić do generatora");
            Console.ReadKey();
            Home();
        }
    }
}