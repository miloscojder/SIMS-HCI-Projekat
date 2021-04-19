/***********************************************************************
 * Module:  Request.cs
 * Author:  cojder
 * Purpose: Definition of the Class Request
 ***********************************************************************/

using System;

namespace Model
{
   public class Request
   {
      public int Id;
      public String Description;
      public DateTime DateOfVacation;
      public DateTime DateOfCreateRequest;
      public int DurationOfVacation;
      public StatusType Status;
      public String Explanation;
      
      public Doctor doctor;

        public Request(int id, string description, DateTime dateOfVacation, DateTime dateOfCreateRequest, int durationOfVacation, StatusType status, string explanation, Doctor doctor)
        {
            Id = id;
            Description = description;
            DateOfVacation = dateOfVacation;
            DateOfCreateRequest = dateOfCreateRequest;
            DurationOfVacation = durationOfVacation;
            Status = status;
            Explanation = explanation;
            this.doctor = doctor;
        }


        /// <pdGenerated>default parent getter</pdGenerated>
        public Doctor GetDoctor()
      {
         return doctor;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newDoctor</param>
      public void SetDoctor(Doctor newDoctor)
      {
         if (this.doctor != newDoctor)
         {
            if (this.doctor != null)
            {
               Doctor oldDoctor = this.doctor;
               this.doctor = null;
               oldDoctor.RemoveRequest(this);
            }
            if (newDoctor != null)
            {
               this.doctor = newDoctor;
               this.doctor.AddRequest(this);
            }
         }
      }
   
   }
}