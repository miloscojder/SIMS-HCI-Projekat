using Newtonsoft.Json;
using Projekat.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Projekat.Repository
{
    class RenovationRepository
    {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\renovation.json";
        private List<RenovationAppointment> renovations = new List<RenovationAppointment>();

        public RenovationRepository()
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
                renovations = JsonConvert.DeserializeObject<List<RenovationAppointment>>(json);
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(renovations);
            File.WriteAllText(fileLocation, json);
        }

        public List<RenovationAppointment> GetAllRenovation()
        {
            return renovations;
        }

        public void Save(RenovationAppointment appointment)
        {
            renovations.Add(appointment);
            WriteToJson();
        }

        public void DeleteRenovation(int id)
        {
            int index = renovations.FindIndex(obj => obj.id == id);
            renovations.RemoveAt(index);
            WriteToJson();
        }
        public int GenerateNewId()
        {
            try
            {
                int maxId = renovations.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }

    }
}
