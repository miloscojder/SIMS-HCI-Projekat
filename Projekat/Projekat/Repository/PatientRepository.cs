/***********************************************************************
 * Module:  PatientFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.PatientFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Repository
{
   public class PatientRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\List_Of_Patients.json";
        private List<Patient> patients = new List<Patient>();


        public PatientRepository()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }

            using StreamReader r = new StreamReader(fileLocation);
            string json = r.ReadToEnd();
            if (json != "")
            {
                patients = JsonConvert.DeserializeObject<List<Patient>>(json);
                //patients = JsonConvert.DeserializeObject<List<Patient>>(jsonstring);
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(patients);
            File.WriteAllText(fileLocation, json);
        }

        public int GenerateNewId()
        {
            try
            {
                int maxId = patients.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }

        public Model.Patient GetById(int id)
      {
            return patients.Find(obj => obj.id == id);
        }
      
      public void Update(Model.Patient patient)
      {
         // TODO: implement
      }
      
      public void Delete(Model.Patient patient)
      {
            int index = patients.FindIndex(obj => obj.id == patient.id);
            patients.RemoveAt(index);
          //  patients.Remove(patient);
            WriteToJson();
      } 
      
      public void Save(Model.Patient newPatient)
      {
            patients.Add(newPatient);
            WriteToJson();
      }
      
      public List<Patient> GetAll()
      {
            // TODO: implement
            return patients;
      }
   
     // private String FileLocation;
       // private String jsonstring;
    }
}