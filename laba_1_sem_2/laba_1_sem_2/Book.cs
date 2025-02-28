using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_sem_2
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string authot, string isbn, bool isavailible)
        {
            Title = title;
            Author = authot;
            ISBN = isbn;
            IsAvailable = isavailible;
        }
    }
}
