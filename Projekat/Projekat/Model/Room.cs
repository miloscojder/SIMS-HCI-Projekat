

using System;

namespace Model
{
    public class Room
    {
        
        public Room() { }
        public Room(int id, string name, String roomType, int floor, string detail)
        {
            Id = id;
            Name = name;
            RoomType = roomType;
            Floor = floor;
            Detail = detail;
            StaticEquipments = new System.Collections.Generic.List<StaticEquipment>();
        }

        public Room(int id, string name, string roomType, int floor, string detail, int size) {
            Id = id;
            Name = name;
            RoomType = roomType;
            Floor = floor;
            Detail = detail;
            Size = size;
        }



        public int Size { get; set; }

        public int Id
        {
            get
            ;
            set
            ;
        }

        public String Name
        {
            get
            ;
            set
            ;
        }

        public String RoomType
        {
            get
            ;
            set
            ;
        }
        public RoomStatus RoomStatus
        {
            get
            ;
            set
            ;
        }

        public int Floor
        {
            get
            ;
            set
            ;
        }

        public String Detail
        {
            get
            ;
            set
            ;
        }

        public System.Collections.Generic.List<StaticEquipment> StaticEquipments { get; set; }
    }
}