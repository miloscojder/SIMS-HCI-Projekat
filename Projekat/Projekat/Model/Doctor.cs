/***********************************************************************
 * Module:  Doctor.cs
 * Author:  kriss
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/


using System;
using System.Collections.Generic;

namespace Model
{
    public class Doctor : Employee
    {
        public String Specialty { get; set; }
        public Boolean Free { get; set; }
        public double Grade { get; set; }
       
        public CalculateRating CalculateRating { get; set; }

        public Doctor() { }

        public Doctor(int id, String name, String surname, String specialization)
        {
            this.id = id;
            firstName = name;
            lastName = surname;
            Specialty = specialization;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }

    }
}