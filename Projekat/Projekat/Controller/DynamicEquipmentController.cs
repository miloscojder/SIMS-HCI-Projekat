/***********************************************************************
 * Module:  EquipmentFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.EquipmentFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class DynamicEquipmentController
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
   
      public System.Collections.ArrayList dynamicEquipmentService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDynamicEquipmentService()
      {
         if (dynamicEquipmentService == null)
            dynamicEquipmentService = new System.Collections.ArrayList();
         return dynamicEquipmentService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDynamicEquipmentService(System.Collections.ArrayList newDynamicEquipmentService)
      {
         RemoveAllDynamicEquipmentService();
         foreach (Service.DynamicEquipmentService oDynamicEquipmentService in newDynamicEquipmentService)
            AddDynamicEquipmentService(oDynamicEquipmentService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDynamicEquipmentService(Service.DynamicEquipmentService newDynamicEquipmentService)
      {
         if (newDynamicEquipmentService == null)
            return;
         if (this.dynamicEquipmentService == null)
            this.dynamicEquipmentService = new System.Collections.ArrayList();
         if (!this.dynamicEquipmentService.Contains(newDynamicEquipmentService))
            this.dynamicEquipmentService.Add(newDynamicEquipmentService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDynamicEquipmentService(Service.DynamicEquipmentService oldDynamicEquipmentService)
      {
         if (oldDynamicEquipmentService == null)
            return;
         if (this.dynamicEquipmentService != null)
            if (this.dynamicEquipmentService.Contains(oldDynamicEquipmentService))
               this.dynamicEquipmentService.Remove(oldDynamicEquipmentService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDynamicEquipmentService()
      {
         if (dynamicEquipmentService != null)
            dynamicEquipmentService.Clear();
      }
   
   }
}