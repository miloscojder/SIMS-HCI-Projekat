/***********************************************************************
 * Module:  MedicalRecordFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.MedicalRecordFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;
using Service;

namespace Controller
{
   public class MedicalRecordController
   {
       public MedicalRecordService medicalRecordService = new MedicalRecordService();
        public List<MedicalRecord> patientsRecords;

        public List<MedicalRecord> GetAllRecordsByPatientsUsername(String patientsUsername)
        {
            patientsRecords = medicalRecordService.GetAllRecordsByPatientsUsername(patientsUsername);
            return patientsRecords;
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
   
     
   }
}