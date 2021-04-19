/***********************************************************************
 * Module:  MedicalRecordFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.MedicalRecordFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class MedicalRecordController
   {
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
   
      public System.Collections.ArrayList medicalRecordService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetMedicalRecordService()
      {
         if (medicalRecordService == null)
            medicalRecordService = new System.Collections.ArrayList();
         return medicalRecordService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetMedicalRecordService(System.Collections.ArrayList newMedicalRecordService)
      {
         RemoveAllMedicalRecordService();
         foreach (Service.MedicalRecordService oMedicalRecordService in newMedicalRecordService)
            AddMedicalRecordService(oMedicalRecordService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddMedicalRecordService(Service.MedicalRecordService newMedicalRecordService)
      {
         if (newMedicalRecordService == null)
            return;
         if (this.medicalRecordService == null)
            this.medicalRecordService = new System.Collections.ArrayList();
         if (!this.medicalRecordService.Contains(newMedicalRecordService))
            this.medicalRecordService.Add(newMedicalRecordService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveMedicalRecordService(Service.MedicalRecordService oldMedicalRecordService)
      {
         if (oldMedicalRecordService == null)
            return;
         if (this.medicalRecordService != null)
            if (this.medicalRecordService.Contains(oldMedicalRecordService))
               this.medicalRecordService.Remove(oldMedicalRecordService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllMedicalRecordService()
      {
         if (medicalRecordService != null)
            medicalRecordService.Clear();
      }
   
   }
}