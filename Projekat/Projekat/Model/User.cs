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
      public String Id { get; set; }
      public String Username { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Jmbg { get; set; }
        public String EMail { get; set; }
        public String PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        private String Adress { get; set; }

    }
}