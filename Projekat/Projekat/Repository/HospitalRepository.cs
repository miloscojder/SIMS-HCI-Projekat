using Model;
using Newtonsoft.Json;
using Projekat.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace Repository
{
    public class HospitalRepository
    {
        public string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\hospitalData.json";
        public Hospital hospital = new Hospital();

        public HospitalRepository()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }
            using StreamReader r = new StreamReader(fileLocation);

            string allData = r.ReadToEnd();
            if (allData != "")
            {
                hospital = JsonConvert.DeserializeObject<Hospital>(allData);
            }
        }

        public Hospital GetAllHospitalsData()
        {
            hospital = JsonConvert.DeserializeObject<Hospital>(File.ReadAllText(fileLocation));
            return hospital;
        }

        public void WriteHospitalToJason(Hospital newhHospitalData)
        {
            string json = JsonConvert.SerializeObject(newhHospitalData);
            File.WriteAllText(fileLocation, json);
        }

   

        public void Save(Model.MedicalRecord newMedRecord)
        {
            // TODO: implement
        }

        public Model.MedicalRecord GetMedRecord()
        {
            // TODO: implement
            return null;
        }

        public List<MedicalRecord> GetAll()
        {
            // TODO: implement
            return null;
        }

        public String UpdateAllergen(String allergen)
        {
            // TODO: implement
            return null;
        }

        public String CreateAllergen(String alergen)
        {
            // TODO: implement
            return null;
        }

        public void DeleteAllergen(String allergen)
        {
            // TODO: implement
        }

       

    }
}
