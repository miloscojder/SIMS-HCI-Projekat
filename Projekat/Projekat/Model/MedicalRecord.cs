using System;

namespace Model
{
   public class MedicalRecord
   {

        public int RecordNumber { get; set; }
    //  public Patient Patient 
        public String Allergen { get; set; }      
        public Appointment appointment { get; set; }
        public DateTime timeOfAppointment { get; set; }
        public Anamnesis anamnesis { get; set; }
        public String doctorsName { get; set; }
        public String patientsUsername { get; set; }
               
        public MedicalRecord() { }   

   }
}