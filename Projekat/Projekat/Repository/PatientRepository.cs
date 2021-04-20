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


        public Model.Patient GetById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public void Update(Model.Patient patient)
      {
         // TODO: implement
      }
      
      public void Delete(Model.Patient patient)
      {
            int index = patients.FindIndex(obj => obj.Id == patient.Id);
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
   
      private String FileLocation;
        private String jsonstring;
    }
}