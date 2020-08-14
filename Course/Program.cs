using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int room = int.Parse(Console.ReadLine());

            Booking[] vect = new Booking[10];

            for (int i = 0; i < room; i++)
            {
                Console.WriteLine("Aluguel #{0}:", i + 1);
                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());

                vect[roomNumber] = new Booking { Name = name, Email = email };
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                    Console.WriteLine(i.ToString() + ": " + vect[i].ToString());
            }
        }
    }
}
