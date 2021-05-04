/***********************************************************************
 * Module:  OperationFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.OperationFileStorage
 ***********************************************************************/


using Model;
using System;
using System.Collections.Generic;
using Repository;

namespace Service
{
   public class OperationService
   {
        public OperationRepository operationRepository = new OperationRepository();
        public void ScheduleOperation(Operations newO)
        {
            operationRepository.ScheduleOperation(newO);
        }

        public void RescheduleDoctor(Operations operations)
        {
            operationRepository.RescheduleOperation(operations);

        }

        public void Cancel(Operations op)
        {
            operationRepository.CancelOperation(op);
            
        }

      public Operations GetOperation(Operations op)
      {
        
         return operationRepository.GetOperation(op);
      }
      
      public List<Operations> GetAll()
      {
            return operationRepository.GetAll();
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
   
    
   }
}