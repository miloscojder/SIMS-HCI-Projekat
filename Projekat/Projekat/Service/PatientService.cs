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
   
      public System.Collections.ArrayList patientRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetPatientRepository()
      {
         if (patientRepository == null)
            patientRepository = new System.Collections.ArrayList();
         return patientRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetPatientRepository(System.Collections.ArrayList newPatientRepository)
      {
         RemoveAllPatientRepository();
         foreach (Repository.PatientRepository oPatientRepository in newPatientRepository)
            AddPatientRepository(oPatientRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddPatientRepository(Repository.PatientRepository newPatientRepository)
      {
         if (newPatientRepository == null)
            return;
         if (this.patientRepository == null)
            this.patientRepository = new System.Collections.ArrayList();
         if (!this.patientRepository.Contains(newPatientRepository))
            this.patientRepository.Add(newPatientRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemovePatientRepository(Repository.PatientRepository oldPatientRepository)
      {
         if (oldPatientRepository == null)
            return;
         if (this.patientRepository != null)
            if (this.patientRepository.Contains(oldPatientRepository))
               this.patientRepository.Remove(oldPatientRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllPatientRepository()
      {
         if (patientRepository != null)
            patientRepository.Clear();
      }
   
   }
}