/***********************************************************************
 * Module:  RoomFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class RoomFileStorage
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class RoomRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\rooms.json";
        private List<Room> rooms = new List<Room>();


        public RoomRepository()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }

            using StreamReader r = new StreamReader(fileLocation);
            string json = r.ReadToEnd();
            if (json != "")
            {
                rooms = JsonConvert.DeserializeObject<List<Room>>(json);
            }
        }


        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(rooms);
            File.WriteAllText(fileLocation, json);
        }

        public List<Room> GetAllRooms()
        {
            return rooms;
        }

        public Room GetRoom(int id)
        {
            return rooms.Find(obj => obj.Id == id);
        }

        public Room GetByName(String name)
        {
            return rooms.Find(obj => obj.Name == name);
        }

        public void Save(Room room)
        {
            rooms.Add(room);
            WriteToJson();
        }

        public void DeleteRoom(int id)
        {
            int index = rooms.FindIndex(obj => obj.Id == id);
            rooms.RemoveAt(index);
            WriteToJson();
        }

        public void UpdateRoom(Room room)
        {
            int index = rooms.FindIndex(obj => obj.Id == room.Id);
            rooms[index] = room;
            WriteToJson();
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

        public int GenerateNewId()
        {
            try
            {
                int maxId = rooms.Max(obj => obj.Id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }



    }
}