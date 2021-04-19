/***********************************************************************
 * Module:  RequestForDinamicEquipment.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestForDinamicEquipment
 ***********************************************************************/

using System;

namespace Repository
{
   public class RequestForDinamicEquipmentRepository
   {
      public Model.RequestForDinamicEquipment ReadRequest(int id)
      {
         // TODO: implement
         return null;
      }
      
      public void Update(int id, String name)
      {
         // TODO: implement
      }
      
      public Boolean Delete(int id)
      {
         // TODO: implement
         return false;
      }
      
      public void Save(int id)
      {
         // TODO: implement
      }
      
      public int AcceptingRequestForDinamycEquipment(int id, Model.StatusType newStatus, String explanation)
      {
         // TODO: implement
         return 0;
      }
   
      private String FileLocation;
   
   }
}