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
   public class StaticEquipmentController
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
   
      public System.Collections.ArrayList staticEquipmentService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetStaticEquipmentService()
      {
         if (staticEquipmentService == null)
            staticEquipmentService = new System.Collections.ArrayList();
         return staticEquipmentService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetStaticEquipmentService(System.Collections.ArrayList newStaticEquipmentService)
      {
         RemoveAllStaticEquipmentService();
         foreach (Service.StaticEquipmentService oStaticEquipmentService in newStaticEquipmentService)
            AddStaticEquipmentService(oStaticEquipmentService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddStaticEquipmentService(Service.StaticEquipmentService newStaticEquipmentService)
      {
         if (newStaticEquipmentService == null)
            return;
         if (this.staticEquipmentService == null)
            this.staticEquipmentService = new System.Collections.ArrayList();
         if (!this.staticEquipmentService.Contains(newStaticEquipmentService))
            this.staticEquipmentService.Add(newStaticEquipmentService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveStaticEquipmentService(Service.StaticEquipmentService oldStaticEquipmentService)
      {
         if (oldStaticEquipmentService == null)
            return;
         if (this.staticEquipmentService != null)
            if (this.staticEquipmentService.Contains(oldStaticEquipmentService))
               this.staticEquipmentService.Remove(oldStaticEquipmentService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllStaticEquipmentService()
      {
         if (staticEquipmentService != null)
            staticEquipmentService.Clear();
      }
   
   }
}