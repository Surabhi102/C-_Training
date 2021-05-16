using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class visit
    {
        public int Id { get; set; }
        public DateTime VisitDate { get; set; }
        public member member { get; set; }

        internal member member1
        {
            get => default;
            set
            {
            }
        }
    }
}
