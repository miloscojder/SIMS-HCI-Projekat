/***********************************************************************
 * Module:  RequestForDinamicEquipment.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestForDinamicEquipment
 ***********************************************************************/


using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class RequestForDinamicEquipmentRepository
   {

        private String FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\RequestsForDynamicEquipment.json";
        private List<RequestForDinamicEquipment> requestsForDinamicEquipment = new List<RequestForDinamicEquipment>();

        public RequestForDinamicEquipmentRepository()
        {

            if (!File.Exists(FileLocation))
            {
                File.Create(FileLocation).Close();
            }
            using StreamReader r = new StreamReader(FileLocation);

            string allData = r.ReadToEnd();
            if (allData != "")
            {
                requestsForDinamicEquipment = JsonConvert.DeserializeObject<List<RequestForDinamicEquipment>>(allData);

            }

        }

        public void WriteToJson()
        {

            string data = JsonConvert.SerializeObject(requestsForDinamicEquipment);
            File.WriteAllText(FileLocation, data);

        }

        public int GenerateNextId()
        {
            try
            {
                int maxId = requestsForDinamicEquipment.Max(obj => obj.Id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }
        public Model.RequestForDinamicEquipment ReadRequest(int id)
      {
            RequestForDinamicEquipment requestForDinamicEquipment = new RequestForDinamicEquipment();
            int index = requestsForDinamicEquipment.FindIndex(obj => obj.Id == id);
            requestForDinamicEquipment = requestsForDinamicEquipment[index];
            return requestForDinamicEquipment;
        }
      
      public void Update(int id, String name)
      {
            int index = requestsForDinamicEquipment.FindIndex(obj => obj.Id == id);
            RequestForDinamicEquipment r = new RequestForDinamicEquipment();
            requestsForDinamicEquipment[index].Name = name;
            WriteToJson();
        }
      
      public Boolean Delete(int id)
      {
            int index = requestsForDinamicEquipment.FindIndex(obj => obj.Id == id);
            if (index == -1)
            {
                return false;
            }
            requestsForDinamicEquipment.RemoveAt(index);
            WriteToJson();
            return true;
        }
      
      public void Save(RequestForDinamicEquipment newRequestForDinamicEquipment)
      {
            requestsForDinamicEquipment.Add(newRequestForDinamicEquipment);
            WriteToJson();
        }
      
      public Boolean AcceptingRequestForDinamycEquipment(int id, Model.StatusType newStatus)
      {
            int index = requestsForDinamicEquipment.FindIndex(obj => obj.Id == id);
            requestsForDinamicEquipment[index].Status = newStatus;
            WriteToJson();
            if (requestsForDinamicEquipment[index].Status == StatusType.Accepted)
            {
                return true;
            }

            return false;
      }

      public List<RequestForDinamicEquipment> GetAll()
      {
          return requestsForDinamicEquipment;
      }

    }
}