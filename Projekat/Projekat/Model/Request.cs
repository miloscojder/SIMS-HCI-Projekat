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
        public int Id { get; set; }
        public String Description { get; set; }
        public DateTime DateOfVacation { get; set; }
        public DateTime DateOfCreateRequest { get; set; }
        public int DurationOfVacation { get; set; }
        public StatusType Status { get; set; }
        public String Explanation { get; set; }

        public Doctor doctor { get; set; }

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

        public Request()
        {
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
//               oldDoctor.RemoveRequest(this);
            }
            if (newDoctor != null)
            {
               this.doctor = newDoctor;
              // this.doctor.AddRequest(this);
            }
         }
      }
   
   }
}