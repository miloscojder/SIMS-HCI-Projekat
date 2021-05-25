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
      
      public Boolean AcceptingRequestForDinamycEquipment(int id, Model.StatusType newStatus, String explanation)
      {
         return requestForDinamicEquipmentService.AcceptingRequestForDinamycEquipment(id, newStatus, explanation);
      }

        public List<RequestForDinamicEquipment> GetAll()
        {
        return requestForDinamicEquipmentService.GetAll();
        }

        public int generateNextId() {
            return requestForDinamicEquipmentService.generateNextId();
        }


        public List<RequestForDinamicEquipment> FilterByName(String name)
        {
            // TODO: implement
            return null;
        }

        public List<RequestForDinamicEquipment> FilterByStatus(Model.StatusType status)
        {
            // TODO: implement
            return null;
        }

        public List<RequestForDinamicEquipment> SortByDateOfCreation()
        {
            // TODO: implement
            return null;
        }

    }
}