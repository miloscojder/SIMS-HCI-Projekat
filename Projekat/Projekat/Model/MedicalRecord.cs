using System;

namespace Model
{
   public class MedicalRecord
   {
        public int RecordNumber;
    //  public Patient Patient;
        public String Allergen { get; set; }      
        public Appointment appointment;   
        public MedicalRecord() { }   
   }
}