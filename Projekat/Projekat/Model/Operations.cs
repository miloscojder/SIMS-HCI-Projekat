using System;

namespace Model
{
   public class Operations
   {
        public int id { get; set; }
        public String Date { get; set; }
        public String TimeStart { get; set; }
        public string Duration { get; set; }
        //public Boolean Finished;
        public String EndTime { get; set; }
        public TypeOfAppointment AppointmentType { get; set; }
        //public MedicalRecord MedicalRecord { get; set; }

        public Room room { get; set; }
        public Patient patient { get; set; }
        //  public Doctor doctor { get; set; }
        public Anamnesis anamnesis { get; set; }

        public Operations() { }
        public Operations(int id, String date, string start, string duration, string end, Room r, Patient p, TypeOfAppointment type)
        {
            this.id = id;
            Date = date;
            TimeStart = start;
            Duration = duration;
            EndTime = end;
            room = r;
            patient = p;
            AppointmentType = type;
        }

        public Operations(int id, String date, string start, string duration, string end, Room r, Patient p)
        {
            this.id = id;
            Date = date;
            TimeStart = start;
            Duration = duration;
            EndTime = end;
            room = r;
            patient = p;

        }

    }
}