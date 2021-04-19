/***********************************************************************
 * Module:  RequestFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;


namespace Service
{
   public class RequestService
   {
      public void CreateRequest(String description, DateTime dateOfVacation, int durationOfVacation)
      {
         // TODO: implement
      }
      
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
   
      public System.Collections.ArrayList requestRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRequestRepository()
      {
         if (requestRepository == null)
            requestRepository = new System.Collections.ArrayList();
         return requestRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRequestRepository(System.Collections.ArrayList newRequestRepository)
      {
         RemoveAllRequestRepository();
         foreach (Repository.RequestRepository oRequestRepository in newRequestRepository)
            AddRequestRepository(oRequestRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRequestRepository(Repository.RequestRepository newRequestRepository)
      {
         if (newRequestRepository == null)
            return;
         if (this.requestRepository == null)
            this.requestRepository = new System.Collections.ArrayList();
         if (!this.requestRepository.Contains(newRequestRepository))
            this.requestRepository.Add(newRequestRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRequestRepository(Repository.RequestRepository oldRequestRepository)
      {
         if (oldRequestRepository == null)
            return;
         if (this.requestRepository != null)
            if (this.requestRepository.Contains(oldRequestRepository))
               this.requestRepository.Remove(oldRequestRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRequestRepository()
      {
         if (requestRepository != null)
            requestRepository.Clear();
      }
   
   }
}