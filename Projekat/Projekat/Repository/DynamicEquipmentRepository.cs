/***********************************************************************
 * Module:  EquipmentFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.EquipmentFileStorage
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class DynamicEquipmentRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\dynamicEquipment.json";
        private List<DynamicEquipment> dynamicEquipments = new List<DynamicEquipment>();


        public DynamicEquipmentRepository()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }

            using StreamReader r = new StreamReader(fileLocation);
            string json = r.ReadToEnd();
            if (json != "")
            {
                dynamicEquipments = JsonConvert.DeserializeObject<List<DynamicEquipment>>(json);
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(dynamicEquipments);
            File.WriteAllText(fileLocation, json);
        }


        public DynamicEquipment CreateEquipment()
      {
         // TODO: implement
         return null;
      }
      
      public void Save(DynamicEquipment newEquipment)
      {
            // TODO: implement
            dynamicEquipments.Add(newEquipment);
            WriteToJson();
        }
      
      public List<DynamicEquipment> GetAll()
      {
            // TODO: implement
            return dynamicEquipments;
        }
      
      public Boolean UpdateEquipment(DynamicEquipment dynamicEquipment)
      {
            // TODO: implement
            int index = dynamicEquipments.FindIndex(obj => obj.Id == dynamicEquipment.Id);
            dynamicEquipments[index] = dynamicEquipment;
            WriteToJson();
            return true;
        }
      
      public Boolean DeleteEquipment(int id)
      {
            int index = dynamicEquipments.FindIndex(obj => obj.Id == id);
            dynamicEquipments.RemoveAt(index);
            WriteToJson();
            return true;
        }
        public int GenerateNewId()
        {
            try
            {
                int maxId = dynamicEquipments.Max(obj => obj.Id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }



    }
}