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
            requestRepository.WriteToJson();
      }
      
        public void RequestUpdated(int id, String newDescription, DateTime newDateOfVacation, int newDurationOfVacation) 
        {
            //getrequestById u repository
            int index = requestRepository.requestss.FindIndex(obj => obj.Id == id);
            Request r = new Request();
            
            requestRepository.requestss[index].Description = newDescription;
            requestRepository.requestss[index].DateOfVacation = newDateOfVacation;
            requestRepository.requestss[index].DurationOfVacation = newDurationOfVacation;

        }

      public Boolean DeleteRequest(int id)
      {
            DeletingRequest(id);
            requestRepository.WriteToJson();
            return true;
      }
      
        public Boolean DeletingRequest(int id)
        {
            //getrequestById u repository
            int index = requestRepository.requestss.FindIndex(obj => obj.Id == id);
            if (index == -1)
            {
                return false;
            }
            //u repository
            requestRepository.requestss.RemoveAt(index);
            return true;
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