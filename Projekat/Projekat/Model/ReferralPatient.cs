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
        public int id { get; set; }
      public String Explanation { get; set; }
        public String Date { get; set; }
        public String timeStart { get; set; }
        public string duration { get; set; }
        public Room room { get; set; }
        public Patient patient { get; set; }
        public String endTime { get; set; }
        public String doc { get; set; }

        public ReferralPatient() { }

        public ReferralPatient(int id,String date, String start, String duration, String end, String ex, Room r, Patient p, String doctor) 
        {
            this.id = id;
            Date = date;
            timeStart = start;
            this.duration = duration;
            endTime = end;
            Explanation = ex;
            room = r;
            patient = p;
            doc = doctor;
        }

    }
}