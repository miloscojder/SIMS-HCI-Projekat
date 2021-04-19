/***********************************************************************
 * Module:  EquipmentFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.EquipmentFileStorage
 ***********************************************************************/


using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class DynamicEquipmentService
   {
      public DynamicEquipment CreateEquipment()
      {
         // TODO: implement
         return null;
      }
      
      public void Save(Model.StaticEquipment newEquipment)
      {
         // TODO: implement
      }
      
      public List<DynamicEquipment> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Boolean UpdateEquipment()
      {
         // TODO: implement
         return false;
      }
      
      public Boolean DeleteEquipment()
      {
         // TODO: implement
         return false;
      }
   
      public System.Collections.ArrayList dynamicEquipmentRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDynamicEquipmentRepository()
      {
         if (dynamicEquipmentRepository == null)
            dynamicEquipmentRepository = new System.Collections.ArrayList();
         return dynamicEquipmentRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDynamicEquipmentRepository(System.Collections.ArrayList newDynamicEquipmentRepository)
      {
         RemoveAllDynamicEquipmentRepository();
         foreach (Repository.DynamicEquipmentRepository oDynamicEquipmentRepository in newDynamicEquipmentRepository)
            AddDynamicEquipmentRepository(oDynamicEquipmentRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDynamicEquipmentRepository(Repository.DynamicEquipmentRepository newDynamicEquipmentRepository)
      {
         if (newDynamicEquipmentRepository == null)
            return;
         if (this.dynamicEquipmentRepository == null)
            this.dynamicEquipmentRepository = new System.Collections.ArrayList();
         if (!this.dynamicEquipmentRepository.Contains(newDynamicEquipmentRepository))
            this.dynamicEquipmentRepository.Add(newDynamicEquipmentRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDynamicEquipmentRepository(Repository.DynamicEquipmentRepository oldDynamicEquipmentRepository)
      {
         if (oldDynamicEquipmentRepository == null)
            return;
         if (this.dynamicEquipmentRepository != null)
            if (this.dynamicEquipmentRepository.Contains(oldDynamicEquipmentRepository))
               this.dynamicEquipmentRepository.Remove(oldDynamicEquipmentRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDynamicEquipmentRepository()
      {
         if (dynamicEquipmentRepository != null)
            dynamicEquipmentRepository.Clear();
      }
   
   }
}