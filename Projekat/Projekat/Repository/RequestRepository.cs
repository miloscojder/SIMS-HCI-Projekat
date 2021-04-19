/***********************************************************************
 * Module:  RequestFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class RequestRepository
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
   
      public String FileLocation;
   
   }
}