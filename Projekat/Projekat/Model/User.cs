/***********************************************************************
 * Module:  User.cs
 * Author:  Korisnik
 * Purpose: Definition of the Class User
 ***********************************************************************/

using System;

namespace Model
{
    public class User
    {
        public int id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String Jmbg { get; set; }
        public String EMail { get; set; }
        public String PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Doctor doctor { get; set; }
        private String Adress { get; set; }

        public RoolType Rool { get; set; }

    }
}