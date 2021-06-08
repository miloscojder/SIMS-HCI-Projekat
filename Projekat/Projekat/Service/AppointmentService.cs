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

 /*       public TypeOfAppointment GetTypes()
        {
            return appointmentRepository.GetTypes();
        }*/

        //treba upravniku
        public Boolean IsRoomAvailable(Appointment appointment)
        {
            List<Appointment> appointments = GetAll();
            List<Appointment> newAppointments = new List<Appointment>();
            foreach (Appointment a in appointments)
            {
                if (a.RoomId == appointment.RoomId)
                {
                    newAppointments.Add(a);
                }

            }
            return IsTimeSlotFree(appointment, newAppointments);
        }
        //treba upravniku
        public bool IsTimeSlotFree(Appointment appointmentToCheck, List<Appointment> appointments)
        {
            DateTime appointmentToCheckEndTime = appointmentToCheck.StartTime.AddMinutes(appointmentToCheck.DurationInMinutes);
            DateTime appointmentEndTime;
            foreach (Appointment appointment in appointments)
            {
                if (appointmentToCheck.id != appointment.id)
                {
                    appointmentEndTime = appointment.StartTime.AddMinutes(appointment.DurationInMinutes);

                    if (AreAppointmentsOverlapping(appointmentToCheck.StartTime, appointmentToCheckEndTime, appointment.StartTime, appointmentEndTime))
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        //treba upravniku
        private bool AreAppointmentsOverlapping(DateTime firstAppointmentStartTime, DateTime firstAppointmentEndTime, DateTime secondAppointmentStartTime, DateTime secondAppointmentEndTime)
        {
            if (IsDateTimeBetween(firstAppointmentStartTime, secondAppointmentStartTime, secondAppointmentEndTime) ||
                    IsDateTimeBetween(firstAppointmentEndTime, secondAppointmentStartTime, secondAppointmentEndTime))
            {
                return true;
            }
            return false;
        }
        //treba upravniku
        public bool IsDateTimeBetween(DateTime dateTimeToCheck, DateTime startTime, DateTime endTime)
        {
            return dateTimeToCheck.Ticks >= startTime.Ticks && dateTimeToCheck.Ticks < endTime.Ticks;
        }
        public void SaveRenovation(Appointment appointment)
        {
            appointment.id = GenerateNewId();
            appointmentRepository.ScheduleAppointment(appointment);
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
      
      

        public List<DateTime> GetDoctosBusyTimes(String doctorsUsername)
        {
            return appointmentRepository.GetDoctosBusyTimes(doctorsUsername);
        }

        public Boolean IsDoctorBusy(String doctorsUsername, DateTime choosenDate)
        {
            List<DateTime> doctorBusyDates = appointmentRepository.GetDoctosBusyTimes(doctorsUsername);
            int counter = 0;

            foreach(DateTime dt in doctorBusyDates)
            {
                if(dt.Date == choosenDate.Date && dt.Hour == choosenDate.Hour && dt.Minute == choosenDate.Minute)
                {
                    counter++;
                }
            }

            if(counter>0)
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }

     

        public List<Appointment> AddFreeTerminsDayPriority(DateTime choosnDate, List<Room> rooms, List<Doctor> doctors, String patientUsername)
        {
            List<Appointment> dayPriorityAppointments = new List<Appointment>();
            int id = GenerateNewId();
            for(int i = 0; i<3; i++)
            {
                Appointment a = new Appointment(id, choosnDate, TypeOfAppointment.Examination,rooms[i].Name, patientUsername, doctors[i].Username);
                dayPriorityAppointments.Add(a);
            }
            return dayPriorityAppointments;
        }

        public List<Appointment> AddFreeTerminDoctorPriority(List<DateTime> dateTimes, List<Room> rooms, String doctorsUsername, String patientsUsername)
        {
            List<Appointment> doctorPriorityAppointments = new List<Appointment>();
            int id = GenerateNewId();
            for(int i = 0; i <3; i++)
            {
                Appointment a = new Appointment(id, dateTimes[i], TypeOfAppointment.Examination, rooms[i].Name, patientsUsername, doctorsUsername);
                doctorPriorityAppointments.Add(a);
            }
            return doctorPriorityAppointments;
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

        public List<Appointment> GetAppointmentsByPatientsUsername(String username)
        {
            return appointmentRepository.GetAppointmentsByPatientsUsername(username);
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