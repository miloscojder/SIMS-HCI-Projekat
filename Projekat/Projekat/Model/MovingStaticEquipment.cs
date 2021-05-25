using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat.Model
{
    class MovingStaticEquipment
    {
        public MovingStaticEquipment(int id, int staticId, int roomId, DateTime dateTime)
        {
            Id = id;
            StaticId = staticId;
            RoomId = roomId;
            DateTime = dateTime;


        }
        public int StaticId { get; set; }

        public int Id { get; set; }
        public int RoomId { get; set; }
        public DateTime DateTime { get; set; }

    
}
}
