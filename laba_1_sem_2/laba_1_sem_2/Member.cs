namespace laba_1_sem_2
{
    public class Member
    {
        
        public string Name { get; private set; }
        public Guid MemberId { get; private set; }
        public List<Book> LoanedBooks {  get; set; }

        public Member(string name)
        {
            Name = name;
            MemberId = Guid.NewGuid();
            LoanedBooks = new List<Book>();
        }
    }
}
