/***********************************************************************
 * Module:  Appointment.cs
 * Author:  kriss
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using System;

namespace Repository
{
   public class Appointment
   {
      public Appointment ScheduleDoctor()
      {
         // TODO: implement
         return null;
      }
      
      public void RescheduleDoctor(DateTime date, double durations)
      {
         // TODO: implement
      }
      
      public void Cancel()
      {
         // TODO: implement
      }
      
      public Appointment StartAppointment()
      {
         // TODO: implement
         return null;
      }
      
      public Appointment ScedulePatient(DateTime timeStart, DateTime endTime, Model.Doctor doctor, Model.Room room, String id)
      {
         // TODO: implement
         return null;
      }
      
      public void ReschedulePatient(DateTime tImeStart, DateTime timeEnd, Model.Doctor doctor, Model.Room room, String id)
      {
         // TODO: implement
      }
      
      public Appointment DatePriority(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Appointment DoctorPriority(Model.Doctor parameter1)
      {
         // TODO: implement
         return null;
      }
   
      public String Id;
      public DateTime Date;
      public DateTime TimeStart;
      public double Duration;
      public Boolean Finished;
      public DateTime EndTime;
      public Model.TypeOfAppointment AppointmentType;
      public Model.MedicalRecord MedicalRecord;
   
   }
}