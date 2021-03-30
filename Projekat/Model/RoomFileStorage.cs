/***********************************************************************
 * Module:  RoomFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class RoomFileStorage
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Model
{
   public class RoomFileStorage
   {
      public void Save(Room newRoom)
      {
            // TODO: implement
            rooms.Add(newRoom);
        }
      
      public Room GetRoom(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Room> GetAllRooms()
      {
            // TODO: implement
            return rooms;
      }
   
      private String FileLocation;
      private List<Room> rooms;

        public RoomFileStorage() {
            rooms = new List<Room>();
            var room1 = new Room { Id = "1", Name = "A", Floor = 3, Detail = "Room for patients in critical condition.", RoomType = "Intensive care"  };
            var room2 = new Room { Id = "4", Name = "B", Floor = 1, Detail = "Room for examination.", RoomType = "Ordination" };
            var room3 = new Room { Id = "2", Name = "C", Floor = 2, Detail = "Separate room for doctor", RoomType = "Office" };
            var room4 = new Room { Id = "3", Name = "A", Floor = 2, Detail = "Place for operations", RoomType = "Operating room" };

            rooms.Add(room1);
            rooms.Add(room2);
            rooms.Add(room3);
            rooms.Add(room4);


        }

    }
}