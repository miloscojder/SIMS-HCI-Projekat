/***********************************************************************
 * Module:  Doctor.cs
 * Author:  kriss
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/

using System;

namespace Model
{
   public class Doctor : Employee
   {
        public String Specialty { get; set; }
        public Boolean Free { get; set; }
        public double Grade { get; set; }
        public double doctorCounter { get; set; }           //za sad ce biti ovako ovo ce da se menja
        public double doctorGradeSum { get; set; }          //za sad ce biti ovako ovo ce da se menja
        public String doctorFeedback { get; set; }          //za sad ce biti ovako ovo ce da se menja



        public System.Collections.ArrayList requestForDinamicEquipment;

        public Doctor() { }

      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRequestForDinamicEquipment()
      {
         if (requestForDinamicEquipment == null)
            requestForDinamicEquipment = new System.Collections.ArrayList();
         return requestForDinamicEquipment;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRequestForDinamicEquipment(System.Collections.ArrayList newRequestForDinamicEquipment)
      {
         RemoveAllRequestForDinamicEquipment();
         foreach (RequestForDinamicEquipment oRequestForDinamicEquipment in newRequestForDinamicEquipment)
            AddRequestForDinamicEquipment(oRequestForDinamicEquipment);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRequestForDinamicEquipment(RequestForDinamicEquipment newRequestForDinamicEquipment)
      {
         if (newRequestForDinamicEquipment == null)
            return;
         if (this.requestForDinamicEquipment == null)
            this.requestForDinamicEquipment = new System.Collections.ArrayList();
         if (!this.requestForDinamicEquipment.Contains(newRequestForDinamicEquipment))
            this.requestForDinamicEquipment.Add(newRequestForDinamicEquipment);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRequestForDinamicEquipment(RequestForDinamicEquipment oldRequestForDinamicEquipment)
      {
         if (oldRequestForDinamicEquipment == null)
            return;
         if (this.requestForDinamicEquipment != null)
            if (this.requestForDinamicEquipment.Contains(oldRequestForDinamicEquipment))
               this.requestForDinamicEquipment.Remove(oldRequestForDinamicEquipment);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRequestForDinamicEquipment()
      {
         if (requestForDinamicEquipment != null)
            requestForDinamicEquipment.Clear();
      }
      public System.Collections.ArrayList request;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRequest()
      {
         if (request == null)
            request = new System.Collections.ArrayList();
         return request;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRequest(System.Collections.ArrayList newRequest)
      {
         RemoveAllRequest();
         foreach (Request oRequest in newRequest)
            AddRequest(oRequest);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRequest(Request newRequest)
      {
         if (newRequest == null)
            return;
         if (this.request == null)
            this.request = new System.Collections.ArrayList();
         if (!this.request.Contains(newRequest))
         {
            this.request.Add(newRequest);
            newRequest.SetDoctor(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRequest(Request oldRequest)
      {
         if (oldRequest == null)
            return;
         if (this.request != null)
            if (this.request.Contains(oldRequest))
            {
               this.request.Remove(oldRequest);
               oldRequest.SetDoctor((Doctor)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRequest()
      {
         if (request != null)
         {
            System.Collections.ArrayList tmpRequest = new System.Collections.ArrayList();
            foreach (Request oldRequest in request)
               tmpRequest.Add(oldRequest);
            request.Clear();
            foreach (Request oldRequest in tmpRequest)
               oldRequest.SetDoctor((Doctor)null);
            tmpRequest.Clear();
         }
      }
      public Appointment[] appointment;
      public Operations[] operations;
      public Prescription[] prescription;
   
   }
}