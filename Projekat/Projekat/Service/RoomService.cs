/***********************************************************************
 * Module:  RoomFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class RoomFileStorage
 ***********************************************************************/

using Model;
using Repository;
using System;
using System.Collections.Generic;


namespace Service
{
   public class RoomService
   {
        public RoomRepository roomRepository = new RoomRepository();
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
      
      public void MoveStaticEquipment(DateTime date)
      {
         // TODO: implement
      }
      
      public void MoveDynamicEquipment(Model.StaticEquipment quantity, Model.StaticEquipment name)
      {
         // TODO: implement
      }
      
      public void Save(Room newRoom)
      {
            roomRepository.Save(newRoom);
      }
      
      public Room GetRoom(int id)
      {
            return roomRepository.GetRoom(id);
      }
      
      public List<Room> GetAllRooms()
      {
           
           return roomRepository.GetAllRooms();
      }
      
      public Boolean UpdateRoom(Room newRoom)
      {
         roomRepository.UpdateRoom(newRoom);
         return true;
      }
      
      public Boolean DeleteRoom(int id)
      {
         roomRepository.DeleteRoom(id);
         return true;
      }

        public int GenerateNewId()
        {
            return roomRepository.GenerateNewId();

        }



    }
}