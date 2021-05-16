using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class commic:book
    {
        public commic() : base()
        {

        }
        public commic(int id, string name, Author author, DateTime publishdate) : base(id, name, author, publishdate)
        {

        }
        public override void addBook()
        {
            throw new NotImplementedException();
        }
        public override void deleteBook()
        {
            throw new NotImplementedException();
        }
    }
}
