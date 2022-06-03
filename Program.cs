﻿using System;

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
            Console.WriteLine("\nJaki kształt chcesz stworzyć?:\nProstokąt: 1\nTrójkąt: 2");

            string shape = Console.ReadLine();
            switch(shape)
            {
                case "1":
                    // pobranie wszystkich potrzebnych danych do stworzenia prostokąta
                    Console.Write("Podaj szerokość prostokąta: ");
                    string width = Console.ReadLine();

                    Console.Write("Podaj wysokość prostokąta: ");
                    string height = Console.ReadLine();

                    Console.Write("Podaj wypełnienie prostokąta: ");
                    string insideRec = Console.ReadLine();

                    // wywołanie funkcji wraz z przekonwertowaniem na int
                    Rectangle(int.Parse(width), int.Parse(height), insideRec);
                    break;
                
                case "2":
                    // pobranie wszystkich potrzebnych danych do stworzenia trójkąta
                    Console.Write("Podaj wysokość trójkąta: ");
                    string levels = Console.ReadLine();

                    Console.Write("Podaj wypełnienie trójkąta: ");
                    string insideTri = Console.ReadLine();

                    // konwersja na int przy wywołaniu funkcji tworzącej trójkąt
                    Triangle(int.Parse(levels), insideTri);
                    break;
                
                case "exit":
                    break;
                
                default:
                    Console.WriteLine("Błąd: brak opcji " + shape);
                    Home();
                    break;
            }
        }

        static void Rectangle(int width, int height, string inside)
        {
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

        static void Triangle(int levels, string inside)
        {
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

        static void End()
        {
            // koniec programu i powrót do generatora
            Console.WriteLine("Wciśnij dowolny klawisz aby powrócić do generatora");
            Console.ReadKey();
            Home();
        }
    }
}