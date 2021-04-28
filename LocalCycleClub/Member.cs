using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCycleClub
{
    public class Member
    {
        string Username { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        DateTime DOB { get; set; }
        string Address { get; set; }
        string CyclingExperience { get; set; }
      

        public Member(string username, string fname, string lname, string email, string pword, 
            DateTime dob, string address, string cycExp)
        {
            this.Username = username;
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
            this.Password = pword;
            this.DOB = dob;
            this.Address = address;
            this.CyclingExperience = cycExp;
           

        }

        public Member(string username)
        {
            this.Username = username;
        }
    }
}
