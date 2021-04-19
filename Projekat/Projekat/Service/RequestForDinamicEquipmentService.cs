/***********************************************************************
 * Module:  RequestForDinamicEquipment.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestForDinamicEquipment
 ***********************************************************************/

using System;

namespace Service
{
   public class RequestForDinamicEquipmentService
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
   
      public System.Collections.ArrayList requestForDinamicEquipmentRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRequestForDinamicEquipmentRepository()
      {
         if (requestForDinamicEquipmentRepository == null)
            requestForDinamicEquipmentRepository = new System.Collections.ArrayList();
         return requestForDinamicEquipmentRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRequestForDinamicEquipmentRepository(System.Collections.ArrayList newRequestForDinamicEquipmentRepository)
      {
         RemoveAllRequestForDinamicEquipmentRepository();
         foreach (Repository.RequestForDinamicEquipmentRepository oRequestForDinamicEquipmentRepository in newRequestForDinamicEquipmentRepository)
            AddRequestForDinamicEquipmentRepository(oRequestForDinamicEquipmentRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRequestForDinamicEquipmentRepository(Repository.RequestForDinamicEquipmentRepository newRequestForDinamicEquipmentRepository)
      {
         if (newRequestForDinamicEquipmentRepository == null)
            return;
         if (this.requestForDinamicEquipmentRepository == null)
            this.requestForDinamicEquipmentRepository = new System.Collections.ArrayList();
         if (!this.requestForDinamicEquipmentRepository.Contains(newRequestForDinamicEquipmentRepository))
            this.requestForDinamicEquipmentRepository.Add(newRequestForDinamicEquipmentRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRequestForDinamicEquipmentRepository(Repository.RequestForDinamicEquipmentRepository oldRequestForDinamicEquipmentRepository)
      {
         if (oldRequestForDinamicEquipmentRepository == null)
            return;
         if (this.requestForDinamicEquipmentRepository != null)
            if (this.requestForDinamicEquipmentRepository.Contains(oldRequestForDinamicEquipmentRepository))
               this.requestForDinamicEquipmentRepository.Remove(oldRequestForDinamicEquipmentRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRequestForDinamicEquipmentRepository()
      {
         if (requestForDinamicEquipmentRepository != null)
            requestForDinamicEquipmentRepository.Clear();
      }
   
   }
}