using static System.Reflection.Metadata.BlobBuilder;

namespace laba_1_sem_2
{
    public class Member
    {
        
        public string Name { get; private set; }
        public Guid MemberId { get; private set; }
        public IReadOnlyList<Book> LoanedBooks => loanedBooks.AsReadOnly();
        private List<Book> loanedBooks;

        public Member(string name)
        {
            Name = name;
            MemberId = Guid.NewGuid();
            loanedBooks = new List<Book>();
        }

        public void ShowMeYourMember()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"MemberId: {MemberId}");
        }

        public void BookToLoans(Book book)
        {
            loanedBooks.Add(book);
        }
    }
}
