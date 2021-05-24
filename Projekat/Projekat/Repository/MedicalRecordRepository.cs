/***********************************************************************
 * Module:  MedicalRecordFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.MedicalRecordFileStorage
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class MedicalRecordRepository
   {
        public string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\medicalrecordsak.json";
        public List<MedicalRecord> medicalRecords = new List<MedicalRecord>();

        public MedicalRecordRepository()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }
            using StreamReader r = new StreamReader(fileLocation);

            string allData = r.ReadToEnd();
            if (allData != "")
            {
                medicalRecords = JsonConvert.DeserializeObject<List<MedicalRecord>>(allData);
            }
        }

        public List<MedicalRecord> getAllMedicalRecords()
        {
            medicalRecords = JsonConvert.DeserializeObject<List<MedicalRecord>>(File.ReadAllText(fileLocation));
            return medicalRecords;
        }

        public void WriteMedicalRecordsToJason()
        {
            string json = JsonConvert.SerializeObject(medicalRecords);
            File.WriteAllText(fileLocation, json);
        }

        public List<MedicalRecord> GetAllRecordsByPatientsUsername(String patientsUsername)
        {
            List<MedicalRecord> medicalRecordsForPatient = new List<MedicalRecord>();

            for (int i = 0; i < medicalRecords.Count; i++)
            {
                MedicalRecord mr = medicalRecords[i];
                if (mr.patientsUsername == patientsUsername)
                {
                    medicalRecordsForPatient.Add(mr);
                }
            }
            return medicalRecordsForPatient;
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
   
      public String FileLocation;
   
   }
}