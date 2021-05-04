/***********************************************************************
 * Module:  RequestForDinamicEquipment.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestForDinamicEquipment
 ***********************************************************************/

using Model;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class RequestForDinamicEquipmentController
   {
        private RequestForDinamicEquipmentService requestForDinamicEquipmentService = new RequestForDinamicEquipmentService();
      public Model.RequestForDinamicEquipment ReadRequest(int id)
      {
         return requestForDinamicEquipmentService.ReadRequest(id);
      }
      
      public void Update(int id, String name)
      {
            requestForDinamicEquipmentService.Update(id, name);
      }
      
      public Boolean Delete(int id)
      {
         return requestForDinamicEquipmentService.Delete(id);
      }
      
      public void Save(RequestForDinamicEquipment newRequestForDinamicEquipment)
      {
            requestForDinamicEquipmentService.Save(newRequestForDinamicEquipment);
      }
      
      public Boolean AcceptingRequestForDinamycEquipment(int id, Model.StatusType newStatus)
      {
         return requestForDinamicEquipmentService.AcceptingRequestForDinamycEquipment(id, newStatus);
      }

        public List<RequestForDinamicEquipment> GetAll()
        {
        return requestForDinamicEquipmentService.GetAll();
        }

        public int generateNextId() {
            return requestForDinamicEquipmentService.generateNextId();
        }
    }
}