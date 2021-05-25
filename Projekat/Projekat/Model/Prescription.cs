using System;

namespace Model
{
   public class Prescription
   {
      public int Id { get; set; }
        public String Medicine { get; set; }
        public String Quantity { get; set; }
        public String Instruction { get; set; }
        public Patient Patient { get; set; }

      //  public Doctor doctor { get; set; }

        public Prescription() { }
        public Prescription(int id, string med, string q, string inst)
        {
            this.Id = id;
            Medicine = med;
            Quantity = q;
            Instruction = inst;
        }
        public Prescription(int id, string med, string q, string inst, Patient p)
        {
            this.Id = id;
            Medicine = med;
            Quantity = q;
            Instruction = inst;
            Patient = p;
        }

    }
}