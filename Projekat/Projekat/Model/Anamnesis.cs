using System;

namespace Model
{
   public class Anamnesis
   {
      public String Anamnesy { get; set; }
        public string Id { get; set; }
        public Patient patient { get; set; }

        public Anamnesis() { }
        public Anamnesis(string id, string anam)
        {
            Id = id;
            Anamnesy = anam;
        }

        public Anamnesis(string id, string anam, Patient pat)
        {
            Id = id;
            Anamnesy = anam;
            patient = pat;
        }
   
   }
}