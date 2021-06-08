using System;

namespace Model
{
   public class StaticEquipment
   {
      public int Id { get; set; }
      public String Name { get; set; }
      public EquipmentType Type { get; set; }
      public int Quantity { get; set; }
        public int RoomId { get; set; }
        public Room room { get; set; }
        public int AvailableBeds { get; set; }


        public StaticEquipment() { }
        public StaticEquipment(int id, string name, int roomId, EquipmentType type, int quantity)
        {
            Id = id;
            Name = name;
            Type = type;
            RoomId = roomId;
            Quantity = quantity;
           
           
        }
        public StaticEquipment(int id, string name, EquipmentType type, int quantity, Room r, int beds)
        {
            Id = id;
            Name = name;
            Type = type;
            Quantity = quantity;
            room = r;
            AvailableBeds = beds;
        }



    }
}