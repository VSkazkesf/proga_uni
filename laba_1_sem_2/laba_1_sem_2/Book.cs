namespace laba_1_sem_2
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public Guid Isbn { get; private set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Isbn = Guid.NewGuid();
            IsAvailable = true;
        }
    }
}
