using System;

namespace Model
{
   public class Anamnesis
   {
      public String Anamnesy { get; set; }
        public int Id { get; set; }
        public Patient Patient { get; set; }

        public Anamnesis() { }
        public Anamnesis(int id, string anam)
        {
            this.Id = id;
            Anamnesy = anam;
        }

        public Anamnesis(int id, string anam, Patient pat)
        {
            this.Id = id;
            Anamnesy = anam;
            Patient = pat;
        }

       
   }
}