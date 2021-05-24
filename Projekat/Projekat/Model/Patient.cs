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
        //private User user;
        public MedicalRecord record { get; set; }

        public Patient() { }
public Patient(int id, string name, string surname, MedicalRecord mr)
        {
            this.id = id;
            firstName = name;
            lastName = surname;
            record = mr;
          
        }

        public Patient(int id, string name, string surname, string jmbg,
                       string phone_number, string username, string password)
        {
           // User user = new User();
            this.id = id;
            firstName = name;
            lastName = surname;
            Jmbg = jmbg;
            PhoneNumber = phone_number;
            Username = username;
            Password = password;
           // this.user = user;
        }

    }
}