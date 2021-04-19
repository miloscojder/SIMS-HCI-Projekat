/***********************************************************************
 * Module:  PatientFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.PatientFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class PatientRepository
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
   
      private String FileLocation;
   
   }
}