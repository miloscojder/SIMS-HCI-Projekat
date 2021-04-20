/***********************************************************************
 * Module:  Patient.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.Patient
 ***********************************************************************/

using System;

namespace Model
{
   public class Patient : User
   {
        private User user;

        public String Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String Jmbg { get; set; }

        public String PhoneNumber { get; set; }

        public String Username { get; set; }

        public String Password { get; set; }


        //public Appointment[] appointment;
       /* public Patient(string id, string name, string surname)
        {
            this.id = id;
            firstName = name;
            lastName = surname;
          
        }*/

        public Patient(string id, string name, string surname, string jmbg,
                       string phone_number, string username, string password)
        {
           // User user = new User();
            Id = id;
            FirstName = name;
            LastName = surname;
            Jmbg = jmbg;
            PhoneNumber = phone_number;
            Username = username;
            Password = password;
           // this.user = user;
        }

    }
}