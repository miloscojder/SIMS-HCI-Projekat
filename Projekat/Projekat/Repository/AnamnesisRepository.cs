/***********************************************************************
 * Module:  Anamnesis.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.Anamnesis
 ***********************************************************************/


using Model;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System;
using System.Collections.Generic;
namespace Repository
{
   public class AnamnesisRepository
   {
        public AnamnesisRepository()
        {
            if (!File.Exists(FileLocation))
            {
                File.Create(FileLocation).Close();
            }
            using (StreamReader r = new StreamReader(FileLocation))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    anamneses = JsonConvert.DeserializeObject<List<Anamnesis>>(json);
                }

            }
        }
        public int GenerateNewId()
        {
            try
            {
                int maxId = anamneses.Max(obj => obj.Id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(anamneses);
            File.WriteAllText(FileLocation, json);
        }
        public void CreateAnamnesis(Anamnesis newAnamnesis)
      {
            anamneses.Add(newAnamnesis);
            WriteToJson();
        }
      
      public void UpdateAnamnesis(Anamnesis ana)
      {
            int index = anamneses.FindIndex(obj => obj.Id == ana.Id);
            anamneses[index] = ana;
            WriteToJson();
        }
        public Anamnesis GetAnamnesis(Anamnesis ana)
        {
            return anamneses.Find(obj => obj.Id == ana.Id);
        }

        public List<Anamnesis> GetAll()
        {
            return anamneses;
        }

        public string FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\anamnesis.json";
        public List<Anamnesis> anamneses = new List<Anamnesis>();

    }
}