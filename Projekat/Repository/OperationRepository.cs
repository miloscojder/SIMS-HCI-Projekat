/***********************************************************************
 * Module:  OperationFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.OperationFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class OperationRepository
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
   
      public String FileLocation;
   
   }
}