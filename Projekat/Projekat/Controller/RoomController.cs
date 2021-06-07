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
        public Boolean ClassicRenovation(int roomId, DateTime renovationDate, double duration)
      { 
         return roomService.ClassicRenovation(roomId,renovationDate,duration);
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
        public Room GetByName(String name)
        {
            return roomService.GetByName(name);
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

        public void AttachRooms(int roomAId, int roomBId)
        {
            roomService.AttachRooms(roomAId, roomBId);
        }


        public void DettachRooms(int roomId)
        {
            roomService.DettachRooms(roomId);
        }
        public int GenerateNewId()
        {
            return roomService.GenerateNewId();

        }



    }
}