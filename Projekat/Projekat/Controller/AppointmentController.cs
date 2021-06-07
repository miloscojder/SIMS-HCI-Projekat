/***********************************************************************
 * Module:  AppointmentFileStorage.cs
 * Author:  kriss
 * Purpose: Definition of the Class AppointmentFileStorage
 ***********************************************************************/

using Model;
using System;
using Service;
using System.Collections.Generic;

namespace Controller
{
   public class AppointmentController
   {
        public AppointmentService appointmentService = new AppointmentService();
      public void ScheduleDoctor(Appointment newAppointment)
      {
            appointmentService.ScheduleDoctor(newAppointment);
      }

        public int GenerateNewId()
        {
            return appointmentService.GenerateNewId();

        }

 /*       public TypeOfAppointment GetTypes()
        {
            return appointmentService.GetTypes();
        }*/
        public void RescheduleDoctor(Appointment newAppointment)
      {
            appointmentService.RescheduleDoctor(newAppointment);
      }
      
      public Boolean Cancel(Appointment newAppointment)
      {
            appointmentService.Cancel(newAppointment);
            return true;
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
   
      
      public List<Appointment> GetAll()
      {
           return appointmentService.GetAll();
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
      
      public Appointment GetAppointment(int id)
      {
           return appointmentService.GetAppointment(id);
      }
      
     
    
   
   }
}