/***********************************************************************
 * Module:  PatientFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.PatientFileStorage
 ***********************************************************************/

using Model;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class PatientService
   {
        public PatientRepository patient_repository = new PatientRepository();
      public Model.Patient GetById(int id)
      {
         return patient_repository.GetById(id);
      }

        public int GenerateNewId()
        {
            return patient_repository.GenerateNewId();

        }

        public void Update(Model.Patient patient)
      {
         // TODO: implement
      }
      
      public void Delete(Model.Patient patient)
      {
             
            patient_repository.Delete(patient);
      }
      
      public void Save(Model.Patient newPatient)
      {
            patient_repository.Save(newPatient);
      }
      
      public List<Patient> GetAll()
      {
            return patient_repository.GetAll();
      }
   
    
   
   }
}