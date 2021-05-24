/***********************************************************************
 * Module:  ReferralPatient.cs
 * Author:  kriss
 * Purpose: Definition of the Class Model.ReferralPatient
 ***********************************************************************/

using System;

namespace Model
{
   public class HospitalReferrals
   {
        public int Id { get; set; }
        public String Date { get; set; }
        public Room Room { get; set; }
        public Patient Patient { get; set; }
        public String EndDate { get; set; }

        public HospitalReferrals() { }

        public HospitalReferrals(int id,String date, String end, Room r, Patient p) 
        {
            this.Id = id;
            Date = date;
            EndDate = end;
            Room = r;
            Patient = p;
        }

    }
}