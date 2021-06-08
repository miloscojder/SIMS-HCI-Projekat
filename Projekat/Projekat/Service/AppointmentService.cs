/***********************************************************************
 * Module:  AppointmentFileStorage.cs
 * Author:  kriss
 * Purpose: Definition of the Class AppointmentFileStorage
 ***********************************************************************/

using Model;
using Repository;
using System;
using System.Collections.Generic;


namespace Service
{
   public class AppointmentService
   {
        public AppointmentRepository appointmentRepository = new AppointmentRepository();
        public void ScheduleAppointemnt(Appointment newAppointment)
      {
            appointmentRepository.ScheduleAppointment(newAppointment);
      }

        public int GenerateNewId()
        {
            return appointmentRepository.GenerateNewId();

        }


        public void RescheduleDoctor(Appointment newAppointment)
      {
            appointmentRepository.RescheduleDoctor(newAppointment);
           
      }
      
      public Boolean CancelAppointment(Appointment newAppointment)
      {
            appointmentRepository.CancelAppointment(newAppointment);
            return true;
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
      
      
      
      public List<Appointment> GetAll()
      {
            return appointmentRepository.GetAll();
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
            return appointmentRepository.GetAppointment(id);
      }




    }
}