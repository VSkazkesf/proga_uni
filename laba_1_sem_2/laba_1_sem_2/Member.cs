using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_sem_2
{
    public class Member
    {
        public string Name { get; private set; }
        public string MemberID { get; private set; }
        public List<Book> LoanedBooks {  get; set; }

        public Member(string name, string memberid, List<Book> loanedbooks)
        {
            Name = name;
            MemberID = memberid;
            LoanedBooks = loanedbooks;
        }
    }
}
