/***********************************************************************
 * Module:  RequestFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class RequestController
   {
      public Model.Request ReadRequest(int id)
      {
         // TODO: implement
         return null;
      }
      
      public void UpdateRequest(int id, String newDescription, DateTime newDateOfVacation, int newDurationOfVacation)
      {
         // TODO: implement
      }
      
      public Boolean DeleteRequest(int id)
      {
         // TODO: implement
         return false;
      }
      
      public void Save(Model.Request newRequest)
      {
         // TODO: implement
      }
      
      public List<Request> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Boolean AcceptingRequest(int id, Model.StatusType newStatus, String explanation)
      {
         // TODO: implement
         return false;
      }
      
      public void CreateRequest(String description, DateTime dateOfVacation, int durationOfVacation)
      {
         // TODO: implement
      }
   
      public System.Collections.ArrayList requestService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRequestService()
      {
         if (requestService == null)
            requestService = new System.Collections.ArrayList();
         return requestService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRequestService(System.Collections.ArrayList newRequestService)
      {
         RemoveAllRequestService();
         foreach (Service.RequestService oRequestService in newRequestService)
            AddRequestService(oRequestService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRequestService(Service.RequestService newRequestService)
      {
         if (newRequestService == null)
            return;
         if (this.requestService == null)
            this.requestService = new System.Collections.ArrayList();
         if (!this.requestService.Contains(newRequestService))
            this.requestService.Add(newRequestService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRequestService(Service.RequestService oldRequestService)
      {
         if (oldRequestService == null)
            return;
         if (this.requestService != null)
            if (this.requestService.Contains(oldRequestService))
               this.requestService.Remove(oldRequestService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRequestService()
      {
         if (requestService != null)
            requestService.Clear();
      }
   
   }
}