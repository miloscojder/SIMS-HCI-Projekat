/***********************************************************************
 * Module:  OperationFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.OperationFileStorage
 ***********************************************************************/
using Model;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class OperationRepository
   {
        public OperationRepository()
        {
            if (!File.Exists(FileLocation))
            {
                File.Create(FileLocation).Close();
            }
            using (StreamReader r = new StreamReader(FileLocation))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    operations = JsonConvert.DeserializeObject<List<Operations>>(json);
                }

            }
        }

        public int GenerateNewId()
        {
            try
            {
                int maxId = operations.Max(obj => obj.Id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(operations);
            File.WriteAllText(FileLocation, json);
        }
        public void ScheduleOperation(Operations op)
      {
            operations.Add(op);
            WriteToJson();
        }
      
      public void RescheduleOperation(Operations op)
      {
            int index = operations.FindIndex(obj => obj.Id == op.Id);
            operations[index] = op;
            WriteToJson();
        }
      
      public void CancelOperation(Operations op)
      {
            int index = operations.FindIndex(obj => obj.Id == op.Id);
            operations.RemoveAt(index);
            WriteToJson();
        }
      
     
      
    
      
      public Operations GetOperation(Operations newOperations)
      {
         return operations.Find(obj => obj.Id == newOperations.Id);
        }
      
      public List<Operations> GetAll()
      {
    
         return operations;
      }
      
      public Model.Operations DatePriority(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Operations DoctorPriority(Model.Doctor doctor)
      {
         // TODO: implement
         return null;
      }

        public string FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\operations.json";
        public List<Operations> operations = new List<Operations>();

    }
}