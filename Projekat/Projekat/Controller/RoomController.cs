/***********************************************************************
 * Module:  RoomFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class RoomFileStorage
 ***********************************************************************/

using Model;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class RoomController
   {
        public RoomService roomService = new RoomService();
        public Boolean ClassicRenovation(Room room)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean AdvancedRenovation(Room room)
      {
         // TODO: implement
         return false;
      }

        public void MoveStaticEquipment(int staticId, int toRoom)
        {
            roomService.MoveStaticEquipment(staticId, toRoom);
        }

        public void MoveDynamicEquipment(Model.StaticEquipment quantity, Model.StaticEquipment name)
      {
         // TODO: implement
      }
      
      public void Save(Room newRoom)
      {
            // TODO: implement
            roomService.Save(newRoom);
      }
      
      public Room GetRoom(int id)
      {
         // TODO: implement
         return roomService.GetRoom(id);
      }
      
      public List<Room> GetAllRooms()
      {
         // TODO: implement
         return roomService.GetAllRooms();
      }
      
      public Boolean UpdateRoom(Room newRoom)
      {
            // TODO: implement
         roomService.UpdateRoom(newRoom);
         return true;
      }
      
      public Boolean DeleteRoom(int id)
      {
            // TODO: implement
            roomService.DeleteRoom(id);
            return true;

      }
        public int GenerateNewId()
        {
            return roomService.GenerateNewId();

        }



    }
}