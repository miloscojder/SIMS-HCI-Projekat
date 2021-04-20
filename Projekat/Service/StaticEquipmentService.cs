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
   public class StaticEquipmentService
   {
      public void Save(Model.StaticEquipment newEquipment)
      {
         // TODO: implement
      }
      
      public List<StaticEquipment> GetAll()
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
      
      public StaticEquipment CreateEquipment2()
      {
         // TODO: implement
         return null;
      }
   
      public System.Collections.ArrayList staticEquipmentRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetStaticEquipmentRepository()
      {
         if (staticEquipmentRepository == null)
            staticEquipmentRepository = new System.Collections.ArrayList();
         return staticEquipmentRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetStaticEquipmentRepository(System.Collections.ArrayList newStaticEquipmentRepository)
      {
         RemoveAllStaticEquipmentRepository();
         foreach (Repository.StaticEquipmentRepository oStaticEquipmentRepository in newStaticEquipmentRepository)
            AddStaticEquipmentRepository(oStaticEquipmentRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddStaticEquipmentRepository(Repository.StaticEquipmentRepository newStaticEquipmentRepository)
      {
         if (newStaticEquipmentRepository == null)
            return;
         if (this.staticEquipmentRepository == null)
            this.staticEquipmentRepository = new System.Collections.ArrayList();
         if (!this.staticEquipmentRepository.Contains(newStaticEquipmentRepository))
            this.staticEquipmentRepository.Add(newStaticEquipmentRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveStaticEquipmentRepository(Repository.StaticEquipmentRepository oldStaticEquipmentRepository)
      {
         if (oldStaticEquipmentRepository == null)
            return;
         if (this.staticEquipmentRepository != null)
            if (this.staticEquipmentRepository.Contains(oldStaticEquipmentRepository))
               this.staticEquipmentRepository.Remove(oldStaticEquipmentRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllStaticEquipmentRepository()
      {
         if (staticEquipmentRepository != null)
            staticEquipmentRepository.Clear();
      }
   
   }
}