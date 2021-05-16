using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class librarian 
    {
       
        public int Id { get; set; }
        public string Name { get; set; }

        internal member member
        {
            get => default;
            set
            {
            }
        }

        internal book book
        {
            get => default;
            set
            {
            }
        }

        public void addBook()
        {
            throw new NotImplementedException();
        }
        public  void deleteBook()
        {
            throw new NotImplementedException();
        }
    }
}
