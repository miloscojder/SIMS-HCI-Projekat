/***********************************************************************
 * Module:  AppointmentFileStorage.cs
 * Author:  kriss
 * Purpose: Definition of the Class AppointmentFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class AppointmentRepository
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
      
      public void Save(String appointments, Boolean sign)
      {
         // TODO: implement
      }
      
      public List<Appointment> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetAllDoctors()
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetSpecialty()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Appointment GetAppointment()
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAllAppointments()
      {
         // TODO: implement
         return null;
      }
   
      public String FileLocation;
      public List<Appointment> Appoinments;
   
   }
}