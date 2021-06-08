/***********************************************************************
 * Module:  Appointment.cs
 * Author:  kriss
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using System;

namespace Model
{
    public class Appointment
    {
        public int id { get; set; }
        public String Date { get; set; }
        public DateTime StartTime { get; set; }
        public String TimeStart { get; set; }
        public string Duration { get; set; }
       public String EndTime { get; set; }
        public TypeOfAppointment AppointmentType { get; set; }
 
        public string RoomName { get; set; }
        public string DoctorUsername { get; set; }
        public string PatientUsername { get; set; }

        //treba upravniku
        public double DurationInMinutes { get; set; }
        public int RoomId { get; set; }

        public Anamnesis Anamnesis { get; set; }

        public Appointment() { }


        public Appointment(int id, DateTime date, string duration, TypeOfAppointment appType, String roomName, String patientUsername, String docotrUsername)
        {
            this.id = id;
            this.StartTime = date;
            Duration = duration;
            this.AppointmentType = appType;
            this.RoomName = roomName;
            this.PatientUsername = patientUsername;
            this.DoctorUsername = docotrUsername;
        }

        public Appointment(int id, DateTime date, TypeOfAppointment appType, String roomName, String patientUsername, String docotrUsername)
        {
            this.id = id;
            this.StartTime = date;
        
            this.AppointmentType = appType;
            this.RoomName = roomName;
            this.PatientUsername = patientUsername;
            this.DoctorUsername = docotrUsername;
        }

        public Appointment(int id,  String date, String start, string d, String end, string roomName, string patientName, string doctorUsername, TypeOfAppointment type)
        {
            this.id = id;
            Date = date;
            TimeStart = start;
            Duration = d;
            EndTime = end;
            RoomName = roomName;
            PatientUsername = patientName;
            DoctorUsername = doctorUsername;
            AppointmentType = type;
        }

        //treba upravniku
        public Appointment(DateTime startTime, double durationInMinutes, int roomId)
        {
            StartTime = startTime;
            DurationInMinutes = durationInMinutes;
            RoomId = roomId;
            PatientUsername = null;
            DoctorUsername= null;
            AppointmentType = 0;

        }

        public Appointment(DateTime date, string DoctorsName, string room)
        {
           StartTime = date;
            RoomName = room;
            DoctorUsername = DoctorsName;
        }

        public Appointment(Room r, Doctor d) { }

    }
}