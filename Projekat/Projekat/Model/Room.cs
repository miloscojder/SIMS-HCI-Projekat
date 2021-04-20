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
        public Room() { }
        public Room(int id, string name, String roomType, int floor, string detail)
        {
            Id = id;
            Name = name;
            RoomType = roomType;
            Floor = floor;
            Detail = detail;
        }

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
    }
}