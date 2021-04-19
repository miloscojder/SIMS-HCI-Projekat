using System;

namespace Model
{
   public class Prescription
   {
      public String Id;
      public String Medicine;
      public int Quantity;
      public String Instruction;
      public Patient Patient;
      
      public Doctor doctor;
   
   }
}