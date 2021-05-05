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
        public String timeStart { get; set; }
        public string duration { get; set; }
        //public Boolean Finished;
        public String endTime { get; set; }
        public TypeOfAppointment appointmentType { get; set; }
        //public MedicalRecord MedicalRecord { get; set; }

        public Room room { get; set; }
        public Patient patient { get; set; }
      //  public Doctor doctor { get; set; }
        public Anamnesis anamnesis { get; set; }

        public Appointment() { }
       /* public Appointment(int id, DateTime start, string duration, String end, Room r, Patient p, TypeOfAppointment type)
        {
            this.id = id;
            startTime = start;
            this.duration = duration;
            endTime = end;
            room = r;
            patient = p;
            appointmentType = type;
        }*/

        public Appointment(int id,  String date, String start, string d, String end, Room R, Patient p)
        {
            this.id = id;
            Date = date;
            timeStart = start;
            duration = d;
            endTime = end;
            room = R;
            patient = p;

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