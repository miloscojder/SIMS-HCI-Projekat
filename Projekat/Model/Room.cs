/***********************************************************************
 * Module:  Room.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Room
 ***********************************************************************/

using System;

namespace Model
{
    public class Room
    {
        public Boolean CreateRoom(Room newRoom)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public void UpdateRoom(Room room)
        {
            // TODO: implement
        }

        public Boolean DeleteRoom(String id)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Boolean ClassicRenovation(Room room)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Boolean AdvancedRenovation(Room room)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public String Id { get; set; }
        public String Name { get; set; }
        public int Floor { get; set; }
        public RoomStatus Status { get; set; }
        public String Detail { get; set; }
        public String RoomType { get; set; }

        public Appointment[] appointment;

    }
}