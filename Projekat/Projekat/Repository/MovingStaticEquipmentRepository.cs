using Model;
using Newtonsoft.Json;
using Projekat.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Projekat.Repository
{
    class MovingStaticEquipmentRepository
    {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\movingStaticEquipment.json";
        private List<MovingStaticEquipment> staticEquipments = new List<MovingStaticEquipment>();

        public MovingStaticEquipmentRepository()
        {
            ReadJson();
        }

        public void ReadJson()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }

            using StreamReader r = new StreamReader(fileLocation);
            string json = r.ReadToEnd();
            if (json != "")
            {
                staticEquipments = JsonConvert.DeserializeObject<List<MovingStaticEquipment>>(json);
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(staticEquipments);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(MovingStaticEquipment newEquipment)
        {
            staticEquipments.Add(newEquipment);
            WriteToJson();
        }

        public List<MovingStaticEquipment> GetAll()
        {
            ReadJson();
            return staticEquipments;
        }

        public void DeleteEquipment(int id)
        {
            int index = staticEquipments.FindIndex(obj => obj.Id == id);
            staticEquipments.RemoveAt(index);
            WriteToJson();
            
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
