/***********************************************************************
 * Module:  RoomFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class RoomFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;


namespace Service
{
   public class RoomService
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
   
      public System.Collections.ArrayList roomRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRoomRepository()
      {
         if (roomRepository == null)
            roomRepository = new System.Collections.ArrayList();
         return roomRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRoomRepository(System.Collections.ArrayList newRoomRepository)
      {
         RemoveAllRoomRepository();
         foreach (Repository.RoomRepository oRoomRepository in newRoomRepository)
            AddRoomRepository(oRoomRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRoomRepository(Repository.RoomRepository newRoomRepository)
      {
         if (newRoomRepository == null)
            return;
         if (this.roomRepository == null)
            this.roomRepository = new System.Collections.ArrayList();
         if (!this.roomRepository.Contains(newRoomRepository))
            this.roomRepository.Add(newRoomRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRoomRepository(Repository.RoomRepository oldRoomRepository)
      {
         if (oldRoomRepository == null)
            return;
         if (this.roomRepository != null)
            if (this.roomRepository.Contains(oldRoomRepository))
               this.roomRepository.Remove(oldRoomRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRoomRepository()
      {
         if (roomRepository != null)
            roomRepository.Clear();
      }
   
   }
}