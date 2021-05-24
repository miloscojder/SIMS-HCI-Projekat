/***********************************************************************
 * Module:  RequestFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestFileStorage
 ***********************************************************************/

using Model;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class RequestController
   {
        public RequestService requestService = new RequestService();
      public Model.Request ReadRequest(int id)
      {
         return requestService.ReadRequest(id);
      }
      
      public void UpdateRequest(int id, String newDescription, DateTime newDateOfVacation, int newDurationOfVacation)
      {
            requestService.UpdateRequest(id, newDescription, newDateOfVacation, newDurationOfVacation);
      }
      
      public Boolean DeleteRequest(int id)
      {
         return requestService.DeleteRequest(id);
      }
        public int GenerateNextId()
        {
            return requestService.GenerateNextId();
        }
        public void Save(Model.Request newRequest)
      {
            requestService.Save(newRequest);
      }
      
      public List<Request> GetAll()
      {
         return requestService.GetAll();
      }
      
      public Boolean AcceptingRequest(int id, Model.StatusType newStatus, String explanation)
      {
         return requestService.AcceptingRequest(id, newStatus, explanation);
      }
     
   }
}