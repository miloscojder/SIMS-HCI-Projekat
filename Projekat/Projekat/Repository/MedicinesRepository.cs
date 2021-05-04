using Newtonsoft.Json;
using Projekat.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Projekat.Repository
{
    class MedicinesRepository
    {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\medicines.json";
        private List<Medicines> medicines = new List<Medicines>();
    
        public MedicinesRepository()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }

            using StreamReader r = new StreamReader(fileLocation);
            string json = r.ReadToEnd();
            if (json != "")
            {
                medicines = JsonConvert.DeserializeObject<List<Medicines>>(json);
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(medicines);
            File.WriteAllText(fileLocation, json);
        }

        public List<Medicines> GetAll()
        {
            return medicines;
        }

        public Medicines GetOne(int id)
        {
            return medicines.Find(obj => obj.Id == id);
        }

        public void Save(Medicines newMedicines)
        {
            medicines.Add(newMedicines);
            WriteToJson();
        }

        public void DeleteMedicines(int id)
        {
            int index = medicines.FindIndex(obj => obj.Id == id);
            medicines.RemoveAt(index);
            WriteToJson();
        }

        public void UpdateMedicines(Medicines newMedicines)
        {
            int index = medicines.FindIndex(obj => obj.Id == newMedicines.Id);
            medicines[index] = newMedicines;
            WriteToJson();
        }

        public int GenerateNewId()
        {
            try
            {
                int maxId = medicines.Max(obj => obj.Id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }
    }
}
