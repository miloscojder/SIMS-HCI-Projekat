/***********************************************************************
 * Module:  RequestForDinamicEquipment.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestForDinamicEquipment
 ***********************************************************************/

using Model;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
    public class RequestForDinamicEquipmentService
    {
        private RequestForDinamicEquipmentRepository requestForDinamicEquipmentRepository = new RequestForDinamicEquipmentRepository();
        public RequestForDinamicEquipment ReadRequest(int id)
        {
            return requestForDinamicEquipmentRepository.ReadRequest(id);
        }

        public void Update(int id, String name)
        {
            requestForDinamicEquipmentRepository.Update(id, name);
        }

        public Boolean Delete(int id)
        {
            return requestForDinamicEquipmentRepository.Delete(id);
        }

        public void Save(RequestForDinamicEquipment newRequestForDinamicEquipment)
        {
            requestForDinamicEquipmentRepository.Save(newRequestForDinamicEquipment);
        }

        public Boolean AcceptingRequestForDinamycEquipment(int id, Model.StatusType newStatus)
        {
            return requestForDinamicEquipmentRepository.AcceptingRequestForDinamycEquipment(id, newStatus);
        }
        public List<RequestForDinamicEquipment> GetAll()
        {
            return requestForDinamicEquipmentRepository.GetAll();
        }

        public int generateNextId() {
            return requestForDinamicEquipmentRepository.GenerateNextId();
        }
    }
}