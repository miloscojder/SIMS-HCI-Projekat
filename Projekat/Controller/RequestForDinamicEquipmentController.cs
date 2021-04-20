/***********************************************************************
 * Module:  RequestForDinamicEquipment.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestForDinamicEquipment
 ***********************************************************************/

using System;

namespace Controller
{
   public class RequestForDinamicEquipmentController
   {
      public Model.RequestForDinamicEquipment ReadRequest(int id)
      {
         // TODO: implement
         return null;
      }
      
      public void Update(int id, String name)
      {
         // TODO: implement
      }
      
      public Boolean Delete(int id)
      {
         // TODO: implement
         return false;
      }
      
      public void Save(int id)
      {
         // TODO: implement
      }
      
      public int AcceptingRequestForDinamycEquipment(int id, Model.StatusType newStatus, String explanation)
      {
         // TODO: implement
         return 0;
      }
   
      public System.Collections.ArrayList requestForDinamicEquipmentService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRequestForDinamicEquipmentService()
      {
         if (requestForDinamicEquipmentService == null)
            requestForDinamicEquipmentService = new System.Collections.ArrayList();
         return requestForDinamicEquipmentService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRequestForDinamicEquipmentService(System.Collections.ArrayList newRequestForDinamicEquipmentService)
      {
         RemoveAllRequestForDinamicEquipmentService();
         foreach (Service.RequestForDinamicEquipmentService oRequestForDinamicEquipmentService in newRequestForDinamicEquipmentService)
            AddRequestForDinamicEquipmentService(oRequestForDinamicEquipmentService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRequestForDinamicEquipmentService(Service.RequestForDinamicEquipmentService newRequestForDinamicEquipmentService)
      {
         if (newRequestForDinamicEquipmentService == null)
            return;
         if (this.requestForDinamicEquipmentService == null)
            this.requestForDinamicEquipmentService = new System.Collections.ArrayList();
         if (!this.requestForDinamicEquipmentService.Contains(newRequestForDinamicEquipmentService))
            this.requestForDinamicEquipmentService.Add(newRequestForDinamicEquipmentService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRequestForDinamicEquipmentService(Service.RequestForDinamicEquipmentService oldRequestForDinamicEquipmentService)
      {
         if (oldRequestForDinamicEquipmentService == null)
            return;
         if (this.requestForDinamicEquipmentService != null)
            if (this.requestForDinamicEquipmentService.Contains(oldRequestForDinamicEquipmentService))
               this.requestForDinamicEquipmentService.Remove(oldRequestForDinamicEquipmentService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRequestForDinamicEquipmentService()
      {
         if (requestForDinamicEquipmentService != null)
            requestForDinamicEquipmentService.Clear();
      }
   
   }
}