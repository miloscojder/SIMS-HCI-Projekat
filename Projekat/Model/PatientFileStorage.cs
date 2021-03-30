/***********************************************************************
 * Module:  PatientFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.PatientFileStorage
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Model
{
    public class PatientFileStorage
    {

            private string fileLocation = "C:/Users/Ana_Marija/source/repos/Projekat/pacijenti.txt";
            //private string fileLocation;
            private List<Patient> patients;

            public PatientFileStorage()
            {
                string[] lines = System.IO.File.ReadAllLines(fileLocation);
                string[] one_patient;
                patients = new List<Patient>();
                foreach (string line in lines)
                {
                    one_patient = line.Split(',');
                    int i = 0;
                    String Username = ""; String Password = ""; String FirstName = "";
                    String LastName = ""; String Id = ""; String us = "";
                    foreach (String attr in one_patient)
                    {
                        Console.WriteLine("\t" + attr);
                        if (i == 0) { Username = attr; }
                        if (i == 1) { Password = attr; }
                        if (i == 2) { FirstName = attr; }
                        if (i == 3) { LastName = attr; }
                        if (i == 4) { Id = attr; }
                        if (i == 5) { us = attr; }
                        i++;
                    }

                    Patient new_patient = new Patient(Username, Password, FirstName, LastName, Id);

                    patients.Add(new_patient);
                }


                var patient1 = new Patient("mara", "mara666", "Mara", "Milic", "#557");
                var patient2 = new Patient("milisav1", "777", "Milisav", "Zec", "#hhhh");
                var patient3 = new Patient("djoka23", "Kobra", "Djordje", "Djordjevic", "Djole798");

                patients.Add(patient1);
                patients.Add(patient2);
                patients.Add(patient3);



            }


            /*public string FirstName { get; }
            public string Username { get; }
            public string Password { get; }
            public string Id { get; }
            public string LastName { get; }*/

            public List<Patient> GetAll()
            {
                return this.patients;
            }

            public void Save(Patient newPatient)
            {
                patients.Add(newPatient);
            }




        }

    }
     