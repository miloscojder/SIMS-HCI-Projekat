/***********************************************************************
 * Module:  AppointmentFileStorage.cs
 * Author:  kriss
 * Purpose: Definition of the Class AppointmentFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class AppointmentController
   {
      public Repository.Appointment ScheduleDoctor()
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
      
      public Repository.Appointment StartAppointment()
      {
         // TODO: implement
         return null;
      }
      
      public Repository.Appointment ScedulePatient(DateTime timeStart, DateTime endTime, Model.Doctor doctor, Model.Room room, String id)
      {
         // TODO: implement
         return null;
      }
      
      public void ReschedulePatient(DateTime tImeStart, DateTime timeEnd, Model.Doctor doctor, Model.Room room, String id)
      {
         // TODO: implement
      }
      
      public Repository.Appointment DatePriority(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Repository.Appointment DoctorPriority(Model.Doctor parameter1)
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
   
      public System.Collections.ArrayList appointmentService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAppointmentService()
      {
         if (appointmentService == null)
            appointmentService = new System.Collections.ArrayList();
         return appointmentService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAppointmentService(System.Collections.ArrayList newAppointmentService)
      {
         RemoveAllAppointmentService();
         foreach (Service.AppointmentService oAppointmentService in newAppointmentService)
            AddAppointmentService(oAppointmentService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAppointmentService(Service.AppointmentService newAppointmentService)
      {
         if (newAppointmentService == null)
            return;
         if (this.appointmentService == null)
            this.appointmentService = new System.Collections.ArrayList();
         if (!this.appointmentService.Contains(newAppointmentService))
            this.appointmentService.Add(newAppointmentService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAppointmentService(Service.AppointmentService oldAppointmentService)
      {
         if (oldAppointmentService == null)
            return;
         if (this.appointmentService != null)
            if (this.appointmentService.Contains(oldAppointmentService))
               this.appointmentService.Remove(oldAppointmentService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAppointmentService()
      {
         if (appointmentService != null)
            appointmentService.Clear();
      }
   
   }
}