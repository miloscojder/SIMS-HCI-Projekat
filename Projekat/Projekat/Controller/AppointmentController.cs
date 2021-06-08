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

        public CheckingAppointmentAvailabilityForRenovationService checkingAppointmentAvailibilityForRenovationService = new CheckingAppointmentAvailabilityForRenovationService();
        public DoctorsBusynessService doctorBusynessService = new DoctorsBusynessService();
        public OrganisingDoctorAppointmentsService organisingDoctorAppointmentsService = new OrganisingDoctorAppointmentsService();
        public OrganisingPatientAppointmentsService organisingPatientAppointmentService = new OrganisingPatientAppointmentsService();
        

        public void ScheduleAppointemnt(Appointment newAppointment)

        {
            appointmentService.ScheduleAppointemnt(newAppointment);
        }

        public int GenerateNewId()
        {
            return appointmentService.GenerateNewId();

        }

        public void RescheduleDoctor(Appointment newAppointment)
        {
            organisingDoctorAppointmentsService.RescheduleDoctor(newAppointment);
        }

        public Boolean CancelAppointment(Appointment newAppointment)
        {
            appointmentService.CancelAppointment(newAppointment);
            return true;
        }

        public List<Appointment> GetAppointmentsByPatientsUsername(String username)
        {
            return organisingPatientAppointmentService.GetAppointmentsByPatientsUsername(username);
        }


      

        public List<DateTime> GetDoctosBusyTimes(String doctorsUsername)
        {
            return doctorBusynessService.GetDoctosBusyTimes(doctorsUsername);
        }


        public Boolean IsDoctorBusy(String doctorsUsername, DateTime choosenDate)
        {
            return doctorBusynessService.IsDoctorBusy(doctorsUsername, choosenDate);
        }



        public List<Appointment> GetAllAppointmentsForDoctorUser(Doctor doctor)
        {
            return organisingDoctorAppointmentsService.GetAllAppointmentsForDoctorUser(doctor);

        }
    

        public List<Appointment> AddFreeTerminsDayPriority(DateTime choosenDate, List<Room> rooms, List<Doctor> doctors, String patientsUsername) 
        {
            return organisingPatientAppointmentService.AddFreeTerminsDayPriority(choosenDate,rooms,doctors,patientsUsername);
        }

        public List<Appointment> AddFreeTerminDoctorPriority(List<DateTime> termins, List<Room> rooms, String doctorsUsername, String patientsUsername)
        {
            return organisingPatientAppointmentService.AddFreeTerminDoctorPriority(termins, rooms, doctorsUsername, patientsUsername);
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


        public Boolean IsRoomAvailable(Appointment appointment)
        {
            return checkingAppointmentAvailibilityForRenovationService.IsRoomAvailable(appointment);
        }
        //treba upravniku



    }
}