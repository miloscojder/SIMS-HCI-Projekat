/***********************************************************************
 * Module:  OperationFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.OperationFileStorage
 ***********************************************************************/


using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class OperationService
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
   
      public System.Collections.ArrayList operationRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetOperationRepository()
      {
         if (operationRepository == null)
            operationRepository = new System.Collections.ArrayList();
         return operationRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetOperationRepository(System.Collections.ArrayList newOperationRepository)
      {
         RemoveAllOperationRepository();
         foreach (Repository.OperationRepository oOperationRepository in newOperationRepository)
            AddOperationRepository(oOperationRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddOperationRepository(Repository.OperationRepository newOperationRepository)
      {
         if (newOperationRepository == null)
            return;
         if (this.operationRepository == null)
            this.operationRepository = new System.Collections.ArrayList();
         if (!this.operationRepository.Contains(newOperationRepository))
            this.operationRepository.Add(newOperationRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveOperationRepository(Repository.OperationRepository oldOperationRepository)
      {
         if (oldOperationRepository == null)
            return;
         if (this.operationRepository != null)
            if (this.operationRepository.Contains(oldOperationRepository))
               this.operationRepository.Remove(oldOperationRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllOperationRepository()
      {
         if (operationRepository != null)
            operationRepository.Clear();
      }
   
   }
}