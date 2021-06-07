

using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
    
    public class StaticEquipmentRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\staticEquipment.json";
        private List<StaticEquipment> staticEquipments = new List<StaticEquipment>();

        public StaticEquipmentRepository()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }

            using StreamReader r = new StreamReader(fileLocation);
            string json = r.ReadToEnd();
            if (json != "")
            {
                staticEquipments = JsonConvert.DeserializeObject<List<StaticEquipment>>(json);
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(staticEquipments);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(StaticEquipment newEquipment)
      {
            staticEquipments.Add(newEquipment);
            WriteToJson();
        }
      
      public StaticEquipment GetOne(int id)
      {
            return staticEquipments.Find(obj => obj.Id == id);
        }
      
      public List<StaticEquipment> GetAll()
      {
            return staticEquipments;
      }
      
      public Boolean UpdateEquipment(StaticEquipment staticEquipment)
      {
            int index = staticEquipments.FindIndex(obj => obj.Id == staticEquipment.Id);
            staticEquipments[index] = staticEquipment;
            WriteToJson();
            return true;
        }
      
      public Boolean DeleteEquipment(int id)
      {
            int index = staticEquipments.FindIndex(obj => obj.Id == id);
            staticEquipments.RemoveAt(index);
            WriteToJson();
            return true;
        }

        public List<StaticEquipment> GetEquipmentByRoomId(int id)
        {
            return staticEquipments.FindAll(obj => obj.RoomId == id);
        }

        public StaticEquipment CreateEquipment()
      {
         
         return null;
      }

        public int GenerateNewId()
        {
            try
            {
                int maxId = staticEquipments.Max(obj => obj.Id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }

    }
}