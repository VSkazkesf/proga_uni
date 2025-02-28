using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_sem_2
{
    public class Library
    {
        List<Book> Books { get; }
        List<Member> Members { get; }

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }
    }
}
