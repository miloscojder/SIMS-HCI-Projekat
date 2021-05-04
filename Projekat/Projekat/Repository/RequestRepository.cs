/***********************************************************************
 * Module:  RequestFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.RequestFileStorage
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
    public class RequestRepository
    {

        public String FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\Requests.json";
        public List<Request> requestss = new List<Request>();

        public RequestRepository()
        {

            if (!File.Exists(FileLocation))
            {
                File.Create(FileLocation).Close();
            }
            using StreamReader r = new StreamReader(FileLocation);
            
                string allData = r.ReadToEnd();
                if (allData != "")
                {
                    requestss = JsonConvert.DeserializeObject<List<Request>>(allData);

            }
            
        }

        public void WriteToJson() {

            string data = JsonConvert.SerializeObject(requestss);
            File.WriteAllText(FileLocation, data);
        
        }


        public int GenerateNextId()
        {
            try
            {
                int maxId = requestss.Max(obj => obj.Id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }

      /*public void CreateRequest(String description, DateTime dateOfVacation, int durationOfVacation)
      {
            Request request = new Request(GenerateNextId(), description, dateOfVacation, DateTime.Now, durationOfVacation, StatusType.Waiting, "", this.doctor);

         // TODO: implement
      }
      */
      public Model.Request ReadRequest(int id)
      {
        Request request = new Request();
        int index = requestss.FindIndex(obj => obj.Id == id);
        request = requestss[index];
        return request;
      }
      
      public void UpdateRequest(int id, String newDescription, DateTime newDateOfVacation, int newDurationOfVacation)
      {
            int index = requestss.FindIndex(obj => obj.Id == id);
            Request r = new Request();
            requestss[index].Description = newDescription;
            requestss[index].DateOfVacation = newDateOfVacation;
            requestss[index].DurationOfVacation = newDurationOfVacation;
            WriteToJson();
      }
      
      public Boolean DeleteRequest(int id)
      {
            int index = requestss.FindIndex(obj => obj.Id == id);
            if (index == -1) {
                return false;
            }
            requestss.RemoveAt(index);
            WriteToJson();
            return true;
      }
      
      public void Save(Model.Request newRequest)
      {
            requestss.Add(newRequest);
            WriteToJson();
      }
      
      public List<Request> GetAll()
      {
         return requestss;
      }

        public Boolean AcceptingRequest(int id, Model.StatusType newStatus, String explanation)
        {
            int index = requestss.FindIndex(obj => obj.Id == id);
            requestss[index].Status = newStatus;
            requestss[index].Explanation = explanation;
            WriteToJson();
            if (requestss[index].Status == StatusType.Accepted)
            {
                return true;
            }

            return false;
        }

   }
}