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
        public String Id { get; set; }
        public String Date { get; set; }
        public DateTime StartTime { get; set; }
        public String TimeStart { get; set; }
        public string Duration { get; set; }
        //public Boolean Finished;
        public String EndTime { get; set; }
        public TypeOfAppointment AppointmentType { get; set; }
        //public MedicalRecord MedicalRecord { get; set; }


        public Room room { get; set; }
        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
        public Anamnesis anamnesis { get; set; }

        public Appointment() { }
        public Appointment(string id, String date, string start, string duration, string end, Room r, Patient p, TypeOfAppointment type)
        {
            Id = id;
            Date = date;
            TimeStart = start;
            Duration = duration;
            EndTime = end;
            room = r;
            patient = p;
            AppointmentType = type;
        }

        public Appointment(string id,  String date, string start, string duration, string end, Room r, Patient p)
        {
            Id = id;
            Date = date;
            TimeStart = start;
            Duration = duration;
            EndTime = end;

        }

        public Appointment(DateTime date, string DoctorsName, string room)
        {
            StartTime = date;
            roomName = room;
            doctorUsername = DoctorsName;
        }

        public Appointment(Room r, Doctor d) { }

        public string roomName { get; set; }
        public string doctorUsername { get; set; }


    }
}