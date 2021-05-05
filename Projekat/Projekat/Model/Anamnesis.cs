using System;

namespace Model
{
   public class Anamnesis
   {
      public String anamnesy { get; set; }
        public int id { get; set; }
        public Patient patient { get; set; }

        public Anamnesis() { }
        public Anamnesis(int id, string anam)
        {
            this.id = id;
            anamnesy = anam;
        }

        public Anamnesis(int id, string anam, Patient pat)
        {
            this.id = id;
            anamnesy = anam;
            patient = pat;
        }

       
   }
}