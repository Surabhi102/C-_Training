using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class member
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Name { get; set; }
        public DateTime Issuedate { get; set; }

        internal visit visit
        {
            get => default;
            set
            {
            }
        }

        public void memberBookSummary()
        {

        }
        public void BookIssued()
        {

        }
        public void paybill()
        {

        }

    }
}
