/***********************************************************************
 * Module:  Request.cs
 * Author:  cojder
 * Purpose: Definition of the Class Request
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Model
{
    public class Request
    {
        public Request(String id, String description, String dateOfVacation, String dateOfCreateRequest, String durationOfVacation, String status)
        {
            Id = Int32.Parse(id); ;
            Description = description;
            DateOfVacation = DateTime.Parse(dateOfVacation);
            DateOfCreateRequest = DateTime.Parse(dateOfCreateRequest);
            DurationOfVacation = Int32.Parse(durationOfVacation);
            Status = (StatusType)Enum.Parse(typeof(StatusType), status);

            // TODO: implement
        }

        public Request(int id, String description, DateTime dateOfVacation, DateTime dateOfCreateRequest, int durationOfVacation, StatusType status)
        {
            Id = id;
            Description = description;
            DateOfVacation = dateOfVacation;
            DateOfCreateRequest = dateOfCreateRequest;
            DurationOfVacation = durationOfVacation;
            Status = status;
        }

        public Request(int id, string newDescription, DateTime newDateOfVacation, int newDurationOfVacation)
        {
            Id = id;
            this.newDescription = newDescription;
            this.newDateOfVacation = newDateOfVacation;
            this.newDurationOfVacation = newDurationOfVacation;
        }

        public void CreateRequest(String id, String description, String dateOfVacation, String dateOfCreateRequest, String durationOfVacation, String status)
        {
            Request request = new Request(id, description, dateOfVacation, dateOfCreateRequest, durationOfVacation, status);
            RequestFileStorage requestFileStorage = new RequestFileStorage();
            requestFileStorage.Save(request);
        }
        public Request ReadRequest(int id)
        {
            RequestFileStorage requestFileStorage = new RequestFileStorage();
            requestFileStorage.GetAll();
            foreach (Request request in requestFileStorage.requests)
            {
                if (request.Id == id) { return request; }
            }
            // TODO: implement
            return null;
        }

        public void UpdateRequest(int id, String newDescription, DateTime newDateOfVacation, int newDurationOfVacation)
        {
            //Request request = new Request(id, newDescription, newDateOfVacation, newDurationOfVacation);
            RequestFileStorage requestFileStorage = new RequestFileStorage();
            if (this.ReadRequest(id) is null)
            {
                Console.WriteLine("Nepostojeci zahtev sa ovim id-om");
            }
            else
            {
                Request request = this.ReadRequest(id);
                request.Description = newDescription;
                request.DateOfVacation = newDateOfVacation;
                request.DurationOfVacation = newDurationOfVacation;

                requestFileStorage.Save(request);
            }

            // TODO: implement
        }

        public Boolean DeleteRequest(int id)
        {
            RequestFileStorage requestFileStorage = new RequestFileStorage();
            Request request = this.ReadRequest(id);
            if (this.ReadRequest(id) is null)
            {
                Console.WriteLine("Nepostojeci zahtev sa ovim id-om");
                return false;
            }
            else
            {
                return requestFileStorage.requests.Remove(request);

            }

        }

        public int Id { get; set; }
        public String Description { get; set; }
        public DateTime DateOfVacation { get; set; }
        public DateTime DateOfCreateRequest { get; set; }
        public int DurationOfVacation { get; set; }
        public StatusType Status { get; set; }

        public Doctor doctor;
        private string newDescription;
        private DateTime newDateOfVacation;
        private int newDurationOfVacation;

        /// <pdGenerated>default parent getter</pdGenerated>
        public Doctor GetDoctor()
        {
            return doctor;
        }

        /// <pdGenerated>default parent setter</pdGenerated>
        /// <param>newDoctor</param>
          public void SetDoctor(Doctor newDoctor)
           {
              if (this.doctor != newDoctor)
              {
                 if (this.doctor != null)
                 {
                    Doctor oldDoctor = this.doctor;
                    this.doctor = null;
                    oldDoctor.RemoveRequest(this);
                 }
                 if (newDoctor != null)
                 {
                    this.doctor = newDoctor;
                    this.doctor.AddRequest(this);
                 }
              }
           }
        
    }
}
