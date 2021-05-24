/***********************************************************************
 * Module:  PrescriptionFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.PrescriptionFileStorage
 ***********************************************************************/
using Model;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class PrescriptionRepository
   {
        public PrescriptionRepository()
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
                    prescriptions = JsonConvert.DeserializeObject<List<Prescription>>(json);
                }

            }
        }

        public int GenerateNewId()
        {
            try
            {
                int maxId = prescriptions.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(prescriptions);
            File.WriteAllText(FileLocation, json);
        }


        public List<Prescription> GetAllPrescriptionsByPatientsUsername(String patientsUsername)
        {
            List<Prescription> prescriptionsForPatient = new List<Prescription>();

            for (int i = 0; i < prescriptions.Count; i++)
            {
                Prescription p = prescriptions[i];
                if (p.patient.Username == patientsUsername)
                {
                    prescriptionsForPatient.Add(p);
                }
            }
            return prescriptionsForPatient;
        }

        public void CreatePrescription(Prescription newPrescription)
      {
            prescriptions.Add(newPrescription);
            WriteToJson();
        }
      


      public void UpdatePrescription(Prescription newPrescription)
      {
            int index = prescriptions.FindIndex(obj => obj.id == newPrescription.id);
            prescriptions[index] = newPrescription;
            WriteToJson();
        }
      
     
      public Prescription GetPrescription(Prescription newPrescription)
      {
            return prescriptions.Find(obj => obj.id == newPrescription.id);
        }
      
      public List<Prescription> GetAll()
      {
            return prescriptions;
        }

        public string FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\prescriptions.json";
        public List<Prescription> prescriptions = new List<Prescription>();

    }
}