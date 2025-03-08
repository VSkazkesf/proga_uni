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
            Console.WriteLine("0. Exit");
        }

        static bool ContinueOrNot()
        {
            Console.WriteLine("Do you want to continue? (y/n)");
            while (true)
            {
                var answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                    {
                        return true;
                    }
                    case "n":
                    {
                        return false;
                    }
                    default:
                    {
                        Console.WriteLine("please enter a letter 'y' or 'n'");
                    } continue;
                }
            }
        }

        Console.Clear();
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
                Console.Clear();
                break;
            }

            switch (choice)
            {
                case 1:
                {
                    Console.Write("Enter a member name: ");
                    var name = Console.ReadLine();
                    lb.RegisterMember(new Member(name));
                    // Console.Clear();
                    Console.WriteLine("Member added");
                    Console.WriteLine();
                    
                    if (ContinueOrNot())
                    {
                        Console.Clear();
                        continue;
                    }
                    return;
                }
                
                case 2:
                {
                    Console.Write("Enter a book title: ");
                    var title = Console.ReadLine();
                    Console.Write("Enter a book author: ");
                    var author = Console.ReadLine();
                    lb.AddBook(new Book(title, author));
                    Console.WriteLine("Book added");
                    Console.WriteLine();
                    
                    if (ContinueOrNot())
                    {
                        Console.Clear(); 
                        continue;
                    }
                    return;
                }
                
                case 3:
                        
                {
                    Console.Write("Enter a book isbn: ");
                    var isbn = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter a member ID: ");
                    var memberId = Guid.Parse(Console.ReadLine());
                    var book = lb.Books.FirstOrDefault(x => x.Isbn == isbn);
                    var member = lb.Members.FirstOrDefault(x => x.MemberId == memberId);
                    lb.LoanBook(book, member);
                    Console.WriteLine("Book loaned");
                    Console.WriteLine();
                    
                    if (ContinueOrNot())
                    {
                        Console.Clear(); 
                        continue;
                    }
                    return;
                }
                
                case 4:
                {
                    Console.Write("Enter a book isbn: ");
                    var isbn = Guid.Parse(Console.ReadLine());
                    var book = lb.Books.FirstOrDefault(x => x.Isbn == isbn);
                    lb.ReturnBook(book);
                    Console.WriteLine("Book returned");
                    Console.WriteLine();
                    
                    if (ContinueOrNot())
                    {
                        Console.Clear(); 
                        continue;
                    }
                    return;
                }
                
                case 5:
                {
                    var loans = lb.GetLoans();
                    Console.WriteLine("Here is loaned books:");
                    Console.WriteLine();
                    foreach (var book in loans)
                    {
                        book.ShowMeYourBook();
                        Console.WriteLine();
                    }

                    if (ContinueOrNot())
                    {
                        Console.Clear();
                        continue;
                    }
                    return;
                }
                
                case 6:
                {
                    Console.Write("Enter a book title: ");
                    var title = Console.ReadLine();
                    var book = lb.SearchBook(title);
                    book.ShowMeYourBook();
                    
                    if (ContinueOrNot())
                    {
                        Console.Clear();
                        continue;
                    }
                    return;
                }
                
                case 7:
                {
                    var availableBooks = lb.GetAvailableBooks();
                    Console.WriteLine("Available books:");
                    Console.WriteLine();
                    foreach (var book in availableBooks)
                    {
                        book.ShowMeYourBook();
                        Console.WriteLine();
                    }
                    
                    if (ContinueOrNot())
                    {
                        Console.Clear();
                        continue;
                    }
                    return;
                }
                
                case 8:
                {
                    Console.Write("Enter a book title: ");
                    var title = Console.ReadLine();
                    var book = lb.SearchBook(title);
                    lb.RemoveBook(book);
                    Console.Clear();
                    Console.WriteLine("Book removed");
                    Console.WriteLine();
                    
                    if (ContinueOrNot())
                    {
                        Console.Clear(); 
                        continue;
                    }
                    return;
                }
                
                case 9:
                {
                    var members = lb.GetMembers();
                    Console.WriteLine("Members:");
                    Console.WriteLine();
                    foreach (var member in members)
                    {
                        member.ShowMeYourMember();
                        Console.WriteLine();
                    }
                    
                    if (ContinueOrNot())
                    {
                        Console.Clear();
                        continue;
                    }
                    return;
                }
                
                case 10:
                {
                    Console.Write("Enter a book title: ");
                    var title = Console.ReadLine();
                    var book = lb.SearchBook(title);
                    book.ShowMeYourBook();
                    
                    if (ContinueOrNot())
                    {
                        Console.Clear(); 
                        continue;
                    }
                    return;
                }
                
                case 0:
                {
                    return;
                }
            }
        }
    }
}