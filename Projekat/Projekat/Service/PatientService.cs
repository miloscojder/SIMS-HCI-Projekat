

using Model;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class PatientService
   {
        public PatientRepository patientRepository = new PatientRepository();
        public List<Patient> patients = new List<Patient>();

      public Model.Patient GetById(int id)
      {
         return patientRepository.GetById(id);
      }

        public List<DateTime> GetActivityTimesByPatientUsername(String username)
        {
            return patientRepository.GetActivityTimesByPatientUsername(username);
        }

        public int GenerateNewId()
        {
            return patientRepository.GenerateNewId();

        }

        public void AddPatientActivities(String username)
        {
            patientRepository.AddPatientActivities(username);
            
        }

        public void Update(Model.Patient patient)
      {
         // TODO: implement
      }
      
      public void Delete(Model.Patient patient)
      {

            patientRepository.Delete(patient);
      }
      
      public void Save(Model.Patient newPatient)
      {
            patientRepository.Save(newPatient);
      }
      
      public List<Patient> GetAll()
      {
            return patientRepository.GetAll();
      }

        public Patient FindPatientByUsernameAndPassword(String username, String password)
        {

            return patientRepository.FindPatientByUsernameAndPassword(username, password);
        }

        public void BanPatient(String username)
        {
            patientRepository.BanPatient(username);
        }

        public Boolean IsPatientBanned(String username)
        {
            return patientRepository.IsPatientBanned(username);
        }

    }
}