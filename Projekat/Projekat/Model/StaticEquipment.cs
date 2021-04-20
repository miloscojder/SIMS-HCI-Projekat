using System;

namespace Model
{
   public class StaticEquipment
   {
      public int Id { get; set; }
      public String Name { get; set; }
      public EquipmentType Type { get; set; }
      public int Quantity { get; set; }

        public StaticEquipment(int id, string name, EquipmentType type, int quantity)
        {
            Id = id;
            Name = name;
            Type = type;
            Quantity = quantity;
           
           
        }



    }
}