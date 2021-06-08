

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
        public readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\List_Of_Patients.json";
        public List<Patient> patients = new List<Patient>();


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

        public List<Patient> GetAllName(string name, string surname)
        {
            return patients.FindAll(obj => (obj.firstName == name || obj.lastName == surname));

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
      

        public List<DateTime> GetActivityTimesByPatientUsername(String username)
        {
            List<DateTime> activityTimes = new List<DateTime>();
            foreach(Patient p in patients)
            {
                if (p.Username == username)
                {
                    activityTimes = p.isPatientBaned.TimeOfActivities;
                    UpdateActivityTimes(activityTimes,p);
                }
            }
            return activityTimes;
        }

        public void UpdateActivityTimes(List<DateTime> dateTimes, Patient loggedPatient)
        {
            TimeSpan ValidTimeActivities = new TimeSpan(7, 0, 0, 0, 0);

            try
            {
                for (int i = 0; i < dateTimes.Count; i++)
                {
                    DateTime dt = dateTimes[i];
                    if ((DateTime.Now.Date - dt.Date) > ValidTimeActivities)
                    {
                        dateTimes.Remove(dt);
                        loggedPatient.isPatientBaned.ActivitiyCounter--;
                        loggedPatient.isPatientBaned.TimeOfActivities = dateTimes;
                        Update(loggedPatient);
                    }
                }
            }
            catch(NullReferenceException e)
            {
                return;
            }
        }    

        public void AddPatientActivities(String username)
        {
            foreach(Patient p in patients)
            {
                if(p.Username==username)
                {
                    p.isPatientBaned.ActivitiyCounter+=1;
                    p.isPatientBaned.TimeOfActivities.Add(DateTime.Now);
                }
            }

            WriteToJson();
        }

      public void Update(Patient loggedPatient)
      {
         foreach(Patient p in patients)
         {
                if(p.id == loggedPatient.id)
                {
                    patients.Remove(p);
                }
         }
         patients.Add(loggedPatient);
         WriteToJson();
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
            return patients;
      }

        public Patient FindPatientByUsernameAndPassword(String username, String password)
        {

            Patient loginPatient = new Patient();
            foreach (Patient p in patients)
            {
                if (username == p.Username & password == p.Password)
                    loginPatient = p;
            }
            return loginPatient;
        }

        public void BanPatient(String username)
        {
            foreach (Patient p in patients)
            {
                if(p.Username==username)
                {
                    p.isPatientBaned.isBaned = true;
                }
            }
            WriteToJson();
        }

        public Boolean IsPatientBanned(String username)
        {
            Patient storege = new Patient();
            foreach(Patient p in patients)
            {
                if(p.Username == username)
                {
                    storege = p;
                    
                }                
            }

            return storege.isPatientBaned.isBaned;
        }
    }
}