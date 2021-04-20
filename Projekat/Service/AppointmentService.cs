/***********************************************************************
 * Module:  AppointmentFileStorage.cs
 * Author:  kriss
 * Purpose: Definition of the Class AppointmentFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;


namespace Service
{
   public class AppointmentService
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
   
      public System.Collections.ArrayList appointmentRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAppointmentRepository()
      {
         if (appointmentRepository == null)
            appointmentRepository = new System.Collections.ArrayList();
         return appointmentRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAppointmentRepository(System.Collections.ArrayList newAppointmentRepository)
      {
         RemoveAllAppointmentRepository();
         foreach (Repository.AppointmentRepository oAppointmentRepository in newAppointmentRepository)
            AddAppointmentRepository(oAppointmentRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAppointmentRepository(Repository.AppointmentRepository newAppointmentRepository)
      {
         if (newAppointmentRepository == null)
            return;
         if (this.appointmentRepository == null)
            this.appointmentRepository = new System.Collections.ArrayList();
         if (!this.appointmentRepository.Contains(newAppointmentRepository))
            this.appointmentRepository.Add(newAppointmentRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAppointmentRepository(Repository.AppointmentRepository oldAppointmentRepository)
      {
         if (oldAppointmentRepository == null)
            return;
         if (this.appointmentRepository != null)
            if (this.appointmentRepository.Contains(oldAppointmentRepository))
               this.appointmentRepository.Remove(oldAppointmentRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAppointmentRepository()
      {
         if (appointmentRepository != null)
            appointmentRepository.Clear();
      }
   
   }
}