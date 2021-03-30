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
      public void ChangeUsername()
      {
         // TODO: implement
      }
      
      public void ChangePassword()
      {
         // TODO: implement
      }
      
      public void ChangeFisteName()
      {
         // TODO: implement
      }
      
      public void ChangeLastName()
      {
         // TODO: implement
      }
      
      public void ChangeEMail()
      {
         // TODO: implement
      }
      
      public void ChangePhoneNumber()
      {
         // TODO: implement
      }
      
      public void ChangeAdress(String newNumber, String newStreet, String newCity, String newCountry, String newPostCode)
      {
         // TODO: implement
      }
   
      public String Username { get; set; }
      public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Jmbg { get; set; }
        public String EMail { get; set; }
        public String PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Adress;

        public String Id;
        
  
   
   }
}