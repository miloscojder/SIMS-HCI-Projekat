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
     /* public void CreateRequest(String description, DateTime dateOfVacation, int durationOfVacation)
      {
         // TODO: implement
      }*/
      
      public Model.Request ReadRequest(int id)
      {
         return requestRepository.ReadRequest(id);
      }
      
      public void UpdateRequest(int id, String newDescription, DateTime newDateOfVacation, int newDurationOfVacation)
      {
            requestRepository.UpdateRequest(id, newDescription, newDateOfVacation, newDurationOfVacation);
      }
      
      public Boolean DeleteRequest(int id)
      {
         
         return requestRepository.DeleteRequest(id);
      }
      
      public void Save(Model.Request newRequest)
      {
            requestRepository.Save(newRequest);
      }
      
      public List<Request> GetAll()
      {
         return requestRepository.GetAll();
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