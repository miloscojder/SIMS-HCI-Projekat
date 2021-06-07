/***********************************************************************
 * Module:  PatientFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.PatientFileStorage
 ***********************************************************************/

using Model;
using System;
using Service;
using System.Collections.Generic;

namespace Controller
{
   public class PatientController
   {
      public PatientService patientService = new PatientService();       
      public Model.Patient GetById(int id)
      {

         return patientService.GetById(id);
      }
      
        public List<DateTime> GetActivityTimesByPatientUsername(String username)
        {
            return patientService.GetActivityTimesByPatientUsername(username);
        }

        public void AddPatientActivities(String username)
        {
            patientService.AddPatientActivities(username);
        }

      public void Update(Model.Patient patient)
      {
         // TODO: implement
      }
        public int GenerateNewId()
        {
            return patientService.GenerateNewId();

        }
        public void Delete(Model.Patient patient)
      {

            patientService.Delete(patient);
      }
      
      public void Save(Model.Patient newPatient)
      {
            patientService.Save(newPatient);
      }
      
      public List<Patient> GetAll()
      {
            // TODO: implement
            return patientService.GetAll();
      }


        public Patient FindPatientByUsernameAndPassword(String username, String password)
        {
            return patientService.FindPatientByUsernameAndPassword(username, password);
        }

        public void BanPatient(String username)
        {
            patientService.BanPatient(username);
        }

        public Boolean IsPatientBanned(String username)
        {
            return patientService.IsPatientBanned(username);
        }


   
   }
}