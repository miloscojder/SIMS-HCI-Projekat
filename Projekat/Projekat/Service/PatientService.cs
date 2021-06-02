

using Model;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class PatientService
   {
        public PatientRepository patientRepository = new PatientRepository();
      public Model.Patient GetById(int id)
      {
         return patientRepository.GetById(id);
      }

        public int GenerateNewId()
        {
            return patientRepository.GenerateNewId();

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



    }
}