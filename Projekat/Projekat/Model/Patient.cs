/***********************************************************************
 * Module:  Patient.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.Patient
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Model
{
   public class Patient : User
   {
       
        public MedicalRecord record { get; set; }
        public Boolean isBaned = false;
        public int ActivitiyCounter;
        public List<DateTime> TimeOfActivities;

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