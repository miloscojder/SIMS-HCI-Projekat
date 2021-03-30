/***********************************************************************
 * Module:  RequestFileStorage.cs
 * Author:  cojder
 * Purpose: Definition of the Class Model.RequestFileStorage
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class RequestFileStorage
    {
        private String FileLocation = @"E:\programiranje\Milosv\Specifikacija_i_modelovanje_softvera\Lekar_proba";
        public List<Request> requests = new List<Request>();

        public RequestFileStorage() { }
        public void Save(Request newRequest)
        {
            // String[] lines = System.IO.File.ReadAllLines(this.FileLocation);
            //String

            //newRequest.Id.get;

            // TODO: implement
            String id = "";
            String description = "";
            String dateOfVacation = "";
            String dateOfCreateRequest = "";
            String durationOfVacation = "";
            String status = "";
            Request newRequest1 = new Request(id = "0", description = "Godisnji Odmor0", dateOfVacation = "05/29/2015", dateOfCreateRequest = "03/29/2015", durationOfVacation = "3", status = "Waiting");

            this.requests.Add(newRequest1);

            string[] lines = { "0", "Godisnji Odmor", "05/29/2015", "03/29/2015", "2", "Waiting" };

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(FileLocation, "Requests1.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }


        }


        public List<Request> GetAll()
        {
            string[] lines = System.IO.File.ReadAllLines(this.FileLocation);
            string[] one_request;
            this.requests = new List<Request>();

            foreach (string line in lines)
            {
                one_request = line.Split(',');
                int i = 0;
                String id = "";
                String description = "";
                String dateOfVacation = "";
                String dateOfCreateRequest = "";
                String durationOfVacation = "";
                String status = "";

                foreach (String attr in one_request)
                {
                    Console.WriteLine("\t" + attr);
                    if (i == 0) { id = attr; }
                    if (i == 1) { description = attr; }
                    if (i == 2) { dateOfVacation = attr; }
                    if (i == 3) { dateOfCreateRequest = attr; }
                    if (i == 4) { durationOfVacation = attr; }
                    if (i == 5) { status = attr; }
                    i++;
                }


                Request new_request = new Request(id, description, dateOfVacation, dateOfCreateRequest, durationOfVacation, status);
                requests.Add(new_request);

            }

            return this.requests;
        }

    }
}
