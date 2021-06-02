

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

        //public Room Room { get; set; }
       // public Patient Patient { get; set; }
      //  public Doctor doctor { get; set; }
        public Anamnesis Anamnesis { get; set; }

        public Appointment() { }

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

        public Appointment(DateTime date, string doctorName, string roomName)
        {
           StartTime = date;
           RoomName = roomName;
           DoctorUsername = doctorName;
        }

        public Appointment(Room r, Doctor d) { }

        public string RoomName { get; set; }
        public string DoctorUsername { get; set; }
        public string PatientUsername { get; set; }


    }
}