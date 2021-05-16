using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract class book

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Publishdate { get; set; }
        public Author Author { get; set; }

        internal Author author
        {
            get => default;
            set
            {
            }
        }

        public book() { }
        public book(int id, string name, Author author, DateTime publishdate)
        {
            Id = id;
            Name = name;
            Author = author;
            Publishdate = publishdate;
        }

        public abstract void addBook();
        public abstract void deleteBook();

        public void BookDetails()
        {
            Console.WriteLine("-----------Summary---------");
            Console.WriteLine(Author.Id);
            Console.WriteLine(Author.Name);
            Console.WriteLine("---------------------------");
        }
    }
}
