using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Projekat.Interfaces
{
    public interface IRequestForDynamicEquipmentRepository
    {

        RequestForDinamicEquipment ReadRequest(int id);
        void Update(int id, String name);
        Boolean Delete(int id);
        void Save(RequestForDinamicEquipment newRequestForDinamicEquipment);
        Boolean AcceptingRequestForDinamycEquipment(int id, StatusType newStatus, String explanation);
        List<RequestForDinamicEquipment> FilterByName(String name);
        List<RequestForDinamicEquipment> FilterByStatus(StatusType status);
        List<RequestForDinamicEquipment> SortByDateOfCreation();
        int GenerateNextId();
   
    }
}
