/***********************************************************************
 * Module:  MedicalRecordFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.MedicalRecordFileStorage
 ***********************************************************************/


using Model;
using System;
using System.Collections.Generic;


namespace Service
{
   public class MedicalRecordService
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
   
      public System.Collections.ArrayList medicalRecordRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetMedicalRecordRepository()
      {
         if (medicalRecordRepository == null)
            medicalRecordRepository = new System.Collections.ArrayList();
         return medicalRecordRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetMedicalRecordRepository(System.Collections.ArrayList newMedicalRecordRepository)
      {
         RemoveAllMedicalRecordRepository();
         foreach (Repository.MedicalRecordRepository oMedicalRecordRepository in newMedicalRecordRepository)
            AddMedicalRecordRepository(oMedicalRecordRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddMedicalRecordRepository(Repository.MedicalRecordRepository newMedicalRecordRepository)
      {
         if (newMedicalRecordRepository == null)
            return;
         if (this.medicalRecordRepository == null)
            this.medicalRecordRepository = new System.Collections.ArrayList();
         if (!this.medicalRecordRepository.Contains(newMedicalRecordRepository))
            this.medicalRecordRepository.Add(newMedicalRecordRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveMedicalRecordRepository(Repository.MedicalRecordRepository oldMedicalRecordRepository)
      {
         if (oldMedicalRecordRepository == null)
            return;
         if (this.medicalRecordRepository != null)
            if (this.medicalRecordRepository.Contains(oldMedicalRecordRepository))
               this.medicalRecordRepository.Remove(oldMedicalRecordRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllMedicalRecordRepository()
      {
         if (medicalRecordRepository != null)
            medicalRecordRepository.Clear();
      }
   
   }
}