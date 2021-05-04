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
        public String Specialty;
        public Boolean Free;
        public Appointment[] appointment;
        public Operations[] operations;
        public Prescription[] prescription;
        public double Grade { get; set; }
        public double doctorCounter { get; set; }           //za sad ce biti ovako ovo ce da se menja
        public double doctorGradeSum { get; set; }          //za sad ce biti ovako ovo ce da se menja
        public String doctorFeedback { get; set; }          //za sad ce biti ovako ovo ce da se menja


        public Doctor() { }

        public Doctor(int id, String name, String surname, String specialization)
        {
            this.Id = Id;
            FirstName = name;
            LastName = surname;
            Specialty = specialization;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

    }
}