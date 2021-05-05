using System;

namespace Model
{
   public class Prescription
   {
      public int id { get; set; }
        public String medicine { get; set; }
        public String quantity { get; set; }
        public String instruction { get; set; }
        public Patient patient { get; set; }

      //  public Doctor doctor { get; set; }

        public Prescription() { }
        public Prescription(int id, string med, string q, string inst)
        {
            this.id = id;
            medicine = med;
            quantity = q;
            instruction = inst;
        }
        public Prescription(int id, string med, string q, string inst, Patient p)
        {
            this.id = id;
            medicine = med;
            quantity = q;
            instruction = inst;
            patient = p;
        }

    }
}