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
        //public Boolean Finished;
        public String EndTime { get; set; }
        public TypeOfAppointment AppointmentType { get; set; }
        //public MedicalRecord MedicalRecord { get; set; }

        public Room Room { get; set; }
        public Patient Patient { get; set; }
      //  public Doctor doctor { get; set; }
        public Anamnesis Anamnesis { get; set; }

        public Appointment() { }
       /* public Appointment(int id, DateTime start, string duration, String end, Room r, Patient p, TypeOfAppointment type)
        {
            this.id = id;
            StartTime = start;
            this.Duration = duration;
            EndTime = end;
            Room = r;
            Patient = p;
            AppointmentType = type;
        } */

        public Appointment(int id,  String date, String start, string d, String end, Room R, Patient p, TypeOfAppointment type)
        {
            this.id = id;
            Date = date;
            TimeStart = start;
            Duration = d;
            EndTime = end;
            Room = R;
            Patient = p;
            AppointmentType = type;
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