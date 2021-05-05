/***********************************************************************
 * Module:  Doctor.cs
 * Author:  kriss
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/


using System;

namespace Model
{
    public class Doctor : Employee
    {
        public String specialty { get; set; }
        public Boolean Free { get; set; }
        public double Grade { get; set; }
        public double doctorCounter { get; set; }           //za sad ce biti ovako ovo ce da se menja
        public double doctorGradeSum { get; set; }          //za sad ce biti ovako ovo ce da se menja
        public String doctorFeedback { get; set; }          //za sad ce biti ovako ovo ce da se menja


        public Doctor() { }

        public Doctor(int id, String name, String surname, String specialization)
        {
            this.id = id;
            firstName = name;
            lastName = surname;
            specialty = specialization;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }

    }
}