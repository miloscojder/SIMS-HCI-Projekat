/***********************************************************************
 * Module:  ReferralPatient.cs
 * Author:  kriss
 * Purpose: Definition of the Class Model.ReferralPatient
 ***********************************************************************/

using System;

namespace Model
{
   public class ReferralPatient
   {
        public int Id { get; set; }
      public String Explanation { get; set; }
        public String Date { get; set; }
        public String TimeStart { get; set; }
        public string Duration { get; set; }
        public Room Room { get; set; }
        public Patient Patient { get; set; }
        public String EndTime { get; set; }
        public String Doc { get; set; }

        public ReferralPatient() { }

        public ReferralPatient(int id,String date, String start, String duration, String end, String ex, Room r, Patient p, String doctor) 
        {
            this.Id = id;
            Date = date;
            TimeStart = start;
            this.Duration = duration;
            EndTime = end;
            Explanation = ex;
            Room = r;
            Patient = p;
            Doc = doctor;
        }

    }
}