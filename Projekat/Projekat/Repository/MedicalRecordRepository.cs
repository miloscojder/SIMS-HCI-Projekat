/***********************************************************************
 * Module:  MedicalRecordFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.MedicalRecordFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class MedicalRecordRepository
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
   
      public String FileLocation;
   
   }
}