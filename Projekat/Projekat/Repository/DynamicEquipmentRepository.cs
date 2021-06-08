
using Model;
using Newtonsoft.Json;
using Projekat.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class DynamicEquipmentRepository : IEquipment<DynamicEquipment>
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\dynamicEquipment.json";
        private readonly string _spisakDinamickeOpreme = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\dynamicTransfer.txt";
        private List<DynamicEquipment> dynamicEquipments = new List<DynamicEquipment>();

        public DynamicEquipmentRepository()
        {
            ReadJson();
        }

        public  void ReadJson()
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
            string json = JsonConvert.SerializeObject(dynamicEquipments, Formatting.Indented);
            File.WriteAllText(fileLocation, json);
        }

      
      public Boolean UpdateEquipment(DynamicEquipment dynamicEquipment)
      {
            
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
        public void MoveDynamicEquipment(DynamicEquipment dynamicEquipment)
        {
            int index = dynamicEquipments.FindIndex(obj => obj.Id == dynamicEquipment.Id);
            DynamicEquipment dynamic = dynamicEquipments[index];
            dynamic.Quantity -= dynamicEquipment.Quantity;
            //UpdateEquipment(dynamic);
            WriteToJson();
           
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

        public void SaveEquipment(DynamicEquipment instance)
        {
            dynamicEquipments.Add(instance);
            WriteToJson();
        }

        public DynamicEquipment GetOneEquipment(int id)
        {
            throw new NotImplementedException();
        }

        public List<DynamicEquipment> GetAllEquipment()
        {
            return dynamicEquipments;
        }
    }
}