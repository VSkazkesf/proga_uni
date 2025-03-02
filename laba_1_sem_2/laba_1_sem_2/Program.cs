using System.Diagnostics;

namespace laba_1_sem_2;

class Program
{
    static void Main()
    {
        Library lb = new Library();
        static void ShowMeYourMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Enter a number:");
            Console.WriteLine("1. Register a new user");
            Console.WriteLine("2. Add a new book");
            Console.WriteLine("3. Loan a book");
            Console.WriteLine("4. Return a book");
            Console.WriteLine("5. Find out which books can not be rented");
            Console.WriteLine("6. Find a book by name");
            Console.WriteLine("7. Find out which books can be rented");
            Console.WriteLine("8. Remove a book");
            Console.WriteLine("9. Find out all the library members");
            Console.WriteLine("10. Get book details");
            Console.WriteLine("11. Exit");
        }
        
        Console.Clear();
        Console.WriteLine("What do you want to do?");
        while (true)
        {
            int choice;
            while (true)
            {
                ShowMeYourMenu();
                var input = Console.ReadLine();
                try
                {
                    choice = int.Parse(input);
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("please enter a number from 1 to 11");
                    Console.WriteLine();
                    continue;
                }
                break;
            }

            switch (choice)
            {
                case 1:
                {
                    var name = Console.ReadLine();
                    lb.RegisterMember(new Member(name));
                }continue;
                
                case 2:
                {
                    var title = Console.ReadLine();
                    var author = Console.ReadLine();
                    lb.AddBook(new Book(title, author));
                }continue;
                
                case 3:
                {
                    var isbn = Guid.Parse(Console.ReadLine());
                    var memberId = Guid.Parse(Console.ReadLine());
                    var book = lb.Books.FirstOrDefault(x => x.Isbn == isbn);
                    var member = lb.Members.FirstOrDefault(x => x.MemberId == memberId);
                    lb.LoanBook(book, member);
                }continue;
                
                case 4:
                {
                    var isbn = Guid.Parse(Console.ReadLine());
                    var book = lb.Books.FirstOrDefault(x => x.Isbn == isbn);
                    lb.ReturnBook(book);
                }continue;
                
                case 5:
                {
                    
                }continue;
                
                case 6:
                {
                    
                }continue;
                
                case 7:
                {
                    
                }continue;
                
                case 8:
                {
                    
                }continue;
                
                case 9:
                {
                    
                }continue;
                
                case 10:
                {
                    
                }continue;
                
                case 11:
                {
                    break;
                }
            }
        }
        
        //TODO Console with Console.Clear();
        
        
    }
}