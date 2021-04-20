/***********************************************************************
 * Module:  OperationFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.OperationFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class OperationController
   {
      public Boolean ScheduleOperation()
      {
         // TODO: implement
         return false;
      }
      
      public Boolean RescheduleOperation(DateTime date, double durations)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean CancelOperation()
      {
         // TODO: implement
         return false;
      }
      
      public Model.Operations ReadOperation()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Operations UpdateOperation()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Operations DeleteOperation()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Operations Save(Model.Operations newOperation)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Operations GetOperation()
      {
         // TODO: implement
         return null;
      }
      
      public List<Operations> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Operations DatePriority(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Operations DoctorPriority(Model.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
   
      public System.Collections.ArrayList operationService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetOperationService()
      {
         if (operationService == null)
            operationService = new System.Collections.ArrayList();
         return operationService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetOperationService(System.Collections.ArrayList newOperationService)
      {
         RemoveAllOperationService();
         foreach (Service.OperationService oOperationService in newOperationService)
            AddOperationService(oOperationService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddOperationService(Service.OperationService newOperationService)
      {
         if (newOperationService == null)
            return;
         if (this.operationService == null)
            this.operationService = new System.Collections.ArrayList();
         if (!this.operationService.Contains(newOperationService))
            this.operationService.Add(newOperationService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveOperationService(Service.OperationService oldOperationService)
      {
         if (oldOperationService == null)
            return;
         if (this.operationService != null)
            if (this.operationService.Contains(oldOperationService))
               this.operationService.Remove(oldOperationService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllOperationService()
      {
         if (operationService != null)
            operationService.Clear();
      }
   
   }
}