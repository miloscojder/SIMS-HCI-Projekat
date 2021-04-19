/***********************************************************************
 * Module:  PatientFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.PatientFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class PatientController
   {
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
         // TODO: implement
      }
      
      public void Save(Model.Patient newPatient)
      {
         // TODO: implement
      }
      
      public List<Patient> GetAll()
      {
         // TODO: implement
         return null;
      }
   
      public System.Collections.ArrayList patientService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetPatientService()
      {
         if (patientService == null)
            patientService = new System.Collections.ArrayList();
         return patientService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetPatientService(System.Collections.ArrayList newPatientService)
      {
         RemoveAllPatientService();
         foreach (Service.PatientService oPatientService in newPatientService)
            AddPatientService(oPatientService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddPatientService(Service.PatientService newPatientService)
      {
         if (newPatientService == null)
            return;
         if (this.patientService == null)
            this.patientService = new System.Collections.ArrayList();
         if (!this.patientService.Contains(newPatientService))
            this.patientService.Add(newPatientService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemovePatientService(Service.PatientService oldPatientService)
      {
         if (oldPatientService == null)
            return;
         if (this.patientService != null)
            if (this.patientService.Contains(oldPatientService))
               this.patientService.Remove(oldPatientService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllPatientService()
      {
         if (patientService != null)
            patientService.Clear();
      }
   
   }
}