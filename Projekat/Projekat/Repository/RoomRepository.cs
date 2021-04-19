/***********************************************************************
 * Module:  RoomFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class RoomFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class RoomRepository
   {
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
      
      public void Save(Model.Room newRoom)
      {
         // TODO: implement
      }
      
      public Model.Room GetRoom(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Room> GetAllRooms()
      {
         // TODO: implement
         return null;
      }
      
      public Boolean UpdateRoom(Model.Room newRoom)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean DeleteRoom(String id)
      {
         // TODO: implement
         return false;
      }
   
      public String FileLocation;
   
   }
}