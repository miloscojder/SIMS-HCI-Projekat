using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class CheckingAppointmentAvailabilityForRenovationService
    {
        public AppointmentRepository appointmentRepository = new AppointmentRepository();
        //treba upravniku
        public Boolean IsRoomAvailable(Appointment appointment)
        {
            List<Appointment> appointments = appointmentRepository.GetAll();
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
            appointment.id = appointmentRepository.GenerateNewId();
            appointmentRepository.ScheduleDoctor(appointment);
        }
    }
}
