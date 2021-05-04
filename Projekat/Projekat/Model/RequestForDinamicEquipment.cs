using System;

namespace Model
{
   public class RequestForDinamicEquipment
   {
      public String Name { get; set; }
      public StatusType Status { get; set; } 
        public DateTime Date { get; set; }
        public int Id { get; set; }

        public RequestForDinamicEquipment() { }
        public RequestForDinamicEquipment(string name, StatusType status, DateTime date, int id)
        {
            Name = name;
            Status = status;
            Date = date;
            Id = id;
        }
    }
}