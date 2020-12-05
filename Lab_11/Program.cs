using Lab_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            part1();
            part2();
        }

        static void part1()
        {
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] SumNWin = { "January", "February", "June", "July", "August", "December" };
            //Console.WriteLine($"Введите n (длина строки)");
            //int lenght = Convert.ToInt32(Console.ReadLine());
            var selectedMonth = month.Where(t => t.Length == 7).OrderBy(t => t);
            foreach (string s in selectedMonth)
                Console.WriteLine(s);

            Console.WriteLine();

            selectedMonth = month.Where(t => SumNWin.Contains(t)).OrderBy(t => t);
            foreach (string s in selectedMonth)
                Console.WriteLine(s);

            Console.WriteLine();

            selectedMonth = month.OrderBy(t => t);
            foreach (string s in selectedMonth)
                Console.WriteLine(s);

            Console.WriteLine();

            selectedMonth = month.Where(t => t.IndexOf("u") != -1 && t.Length >= 4).OrderBy(t => t);
            foreach (string s in selectedMonth)
                Console.WriteLine(s);

            Console.WriteLine();
        }
        static void part2()
        {
            List<Book> ListOfBooks = new List<Book>();
            ListOfBooks.Add(new Book(1, "LiveToWin", "Angel", 2001, 100, 2100, "soft"));
            ListOfBooks.Add(new Book(2, "LiveWin", "Agel", 2007, 150, 1100, "soft"));
            Book book3 = new Book(3, "ToWin", "gel", 2004, 170, 5100, "soft");
            ListOfBooks.Add(book3);
            ListOfBooks.Add(new Book(4, "Live", "Anel", 2005, 110, 2152, "soft"));
            ListOfBooks.Add(new Book(5, "Win", "Cris", 2000, 102, 2750, "soft"));
            ListOfBooks.Add(new Book(6, "LiveTo", "Briz", 1989, 104, 2999, "soft"));
            ListOfBooks.Add(new Book(7, "To", "Jovany", 1955, 116, 2147, "soft"));

            var selectedBook = ListOfBooks.Where(t => t.Author == "Agel" && t.Age == 2007).OrderBy(t => t);
            foreach (Book s in selectedBook)
            {
                s.Info();
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________________");

            var selectedAge = ListOfBooks.Where(t => t.Age > 2001);
            foreach (Book s in selectedAge)
            {
                s.Info();
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________________");

            var PageMin = ListOfBooks.Where(t => t.Page == ListOfBooks.Min(n => n.Page));
            foreach (Book s in PageMin)
            {
                s.Info();
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________________");

            var LowPrice = ListOfBooks.OrderByDescending(t => t.Page).Take(5).OrderBy(t => t.Price);
            foreach (Book s in LowPrice)
            {
                s.Info();
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________________");

            var Sort = ListOfBooks.OrderBy(t => t.Price);
            foreach (Book s in Sort)
            {
                s.Info();
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________________");



            Console.WriteLine("Task4");
            var My = ListOfBooks.Where(t => t.Age > 2001 && ListOfBooks.Contains(book3)).OrderByDescending(t => t.Page).Take(3).First();
                My.Info();
                Console.WriteLine();
            Console.WriteLine("__________________________________________________________");


            List<Book> ListOfBooks1 = new List<Book>();
            ListOfBooks1.Add(new Book(1, "LiveToWin", "Angel", 2001, 100, 2100, "soft"));
            ListOfBooks1.Add(new Book(2, "LiveWin", "Agel", 2007, 150, 1100, "soft"));
            var result = from t in ListOfBooks 
                         join n in ListOfBooks1 on t.Namebook equals n.Namebook 
                         select  new Book(1, t.Namebook, n.Author, 2001, 100, 2100, "soft") ;
            foreach (Book s in result)
            {
                s.Info();
                Console.WriteLine();
            }
        }
       
    }
}
