using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class OrganisingPatientAppointmentsService
    {
        public AppointmentRepository appointmentRepository = new AppointmentRepository();

        public List<Appointment> GetAppointmentsByPatientsUsername(String username)
        {
            return appointmentRepository.GetAppointmentsByPatientsUsername(username);
        }

        public List<Appointment> AddFreeTerminsDayPriority(DateTime choosnDate, List<Room> rooms, List<Doctor> doctors, String patientUsername)
        {
            List<Appointment> dayPriorityAppointments = new List<Appointment>();
            int id = appointmentRepository.GenerateNewId();
            for (int i = 0; i < 3; i++)
            {
                Appointment a = new Appointment(id, choosnDate, TypeOfAppointment.Examination, rooms[i].Name, patientUsername, doctors[i].Username);
                dayPriorityAppointments.Add(a);
            }
            return dayPriorityAppointments;
        }

        public List<Appointment> AddFreeTerminDoctorPriority(List<DateTime> dateTimes, List<Room> rooms, String doctorsUsername, String patientsUsername)
        {
            List<Appointment> doctorPriorityAppointments = new List<Appointment>();
            int id = appointmentRepository.GenerateNewId();
            for (int i = 0; i < 3; i++)
            {
                Appointment a = new Appointment(id, dateTimes[i], TypeOfAppointment.Examination, rooms[i].Name, patientsUsername, doctorsUsername);
                doctorPriorityAppointments.Add(a);
            }
            return doctorPriorityAppointments;
        }
    }
}
