/***********************************************************************
 * Module:  RequestFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestFileStorage
 ***********************************************************************/

using Model;
using Repository;
using System;
using System.Collections.Generic;


namespace Service
{
   public class RequestService
   {

      public RequestRepository requestRepository = new RequestRepository();


        public Model.Request ReadRequest(int id)
      {
         return requestRepository.ReadRequest(id);
      }
      
      public void UpdateRequest(int id, String newDescription, DateTime newDateOfVacation, int newDurationOfVacation)
      {
            RequestUpdated(id, newDescription, newDateOfVacation, newDurationOfVacation);
      }
      
        public void RequestUpdated(int id, String newDescription, DateTime newDateOfVacation, int newDurationOfVacation) 
        { 
            Request r = requestRepository.GetRequestById(id);
            
            r.Description = newDescription;
            r.DateOfVacation = newDateOfVacation;
            r.DurationOfVacation = newDurationOfVacation;
            requestRepository.updateList(id, r);
        }

      public Boolean DeleteRequest(int id)
      {
           return requestRepository.DeleteRequest(id);
      }
     
      public void Save(Model.Request newRequest)
      {
            requestRepository.requestss.Add(newRequest);
            requestRepository.WriteToJson();
      }
      
      public List<Request> GetAll()
      {
         return requestRepository.requestss;
      }

      public int GenerateNextId()
        {
            return requestRepository.GenerateNextId();
        }
      public Boolean AcceptingRequest(int id, Model.StatusType newStatus, String explanation)
      {
       
         return requestRepository.AcceptingRequest(id, newStatus, explanation);
      }
   }
}