using System;

namespace Lab_11.Models
{
    class Book
    {
        public static int count = 0;
        private readonly int id = 1;
        private string namebook = "Why do I live";
        public string Namebook
        {
            get { return namebook; }
            private set { namebook = value; }
        }
        private string author { get; set; } = "Dimasik";
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private const string devel = "BSTU";
        public string Devel
        {
            get { return devel; }
            set { }
        }
        private int age = 2020;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int page = 456;
        public int Page
        {
            get { return page; }
            set { page = value; }
        }
        private int price = 105;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string typeofcover = "soft";
        public string Typeofcover
        {
            get { return typeofcover; }
            set { typeofcover = value; }
        }

        public Book(int id, string Namebook, string author, int age, int page, int price, string typeofcover)
        {
            this.id = id;
            this.Namebook = Namebook;
            this.author = author;
            this.age = age;
            this.page = page;
            this.price = price;
            this.typeofcover = typeofcover;
            count++;
        }

        public Book()
        {
            id = 4534568;
            Namebook = "How to become more skillfull in MTG";
            author = "Dmritriy Kulikov";
            age = 2019;
            page = 342;
            price = 20;
            typeofcover = "hard";
            count++;
        }

        public Book(int joga)
        {
            id = joga;
            count++;
        }

        public void Info()
        {
            Console.WriteLine($"id: {id}\nNamebook: {Namebook}\nauthor: {author}\ndevel: {devel}\nage: {age}\npage: {page}\nprice: {price}\ntypeofcover: {typeofcover}");
        }

        public static void InfoClass()
        {
            Console.WriteLine($"This class have fields: id, author, devel, age, page, price, typeofcover");
        }

        public void sum(ref int a, ref int b, out int c)
        {
            c = a + b;
        }


        private Book(int yoi, int oiy)
        {
            page = yoi;
            price = oiy;
        }
    }
}
