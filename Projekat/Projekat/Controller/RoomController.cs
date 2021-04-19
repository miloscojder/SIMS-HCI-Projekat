/***********************************************************************
 * Module:  RoomFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class RoomFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class RoomController
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
   
      public System.Collections.ArrayList roomService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRoomService()
      {
         if (roomService == null)
            roomService = new System.Collections.ArrayList();
         return roomService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRoomService(System.Collections.ArrayList newRoomService)
      {
         RemoveAllRoomService();
         foreach (Service.RoomService oRoomService in newRoomService)
            AddRoomService(oRoomService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRoomService(Service.RoomService newRoomService)
      {
         if (newRoomService == null)
            return;
         if (this.roomService == null)
            this.roomService = new System.Collections.ArrayList();
         if (!this.roomService.Contains(newRoomService))
            this.roomService.Add(newRoomService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRoomService(Service.RoomService oldRoomService)
      {
         if (oldRoomService == null)
            return;
         if (this.roomService != null)
            if (this.roomService.Contains(oldRoomService))
               this.roomService.Remove(oldRoomService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRoomService()
      {
         if (roomService != null)
            roomService.Clear();
      }
   
   }
}