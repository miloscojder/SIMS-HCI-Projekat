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
        public String id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        //public Appointment[] appointment;
        public Patient() { }
        public Patient(string id, string name, string surname)
        {
            this.id = id;
            firstName = name;
            lastName = surname;
          
        }

    }
}