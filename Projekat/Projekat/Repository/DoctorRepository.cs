/***********************************************************************
 * Module:  Doctor.cs
 * Author:  kriss
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/
using Model;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class DoctorRepository
    {
        public string FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\doctors.json";
        public List<Doctor> doctors = new List<Doctor>();

        public DoctorRepository()
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
                    doctors = JsonConvert.DeserializeObject<List<Doctor>>(json);
                }

            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(doctors);
            File.WriteAllText(FileLocation, json);
        }

        public int GenerateNewId()
        {
            try
            {
                String maxId = doctors.Max(obj => obj.Id);
                return Int32.Parse(maxId) + 1;
            }
            catch
            {
                return 1;
            }
        }
        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
            WriteToJson();
        }

        public void Save(Doctor doctor)
        {
            doctors.Add(doctor);
            WriteToJson();
        }
        public List<Doctor> GetAllDoctorsSpecialist(String specialization)
        {
            return doctors.FindAll(obj => obj.Specialty == specialization);
        }

        public List<Doctor> GetAllDoctors()
        {
            return doctors;
        }
        public Doctor GetDoctor(String id)
        {
            return doctors.Find(obj => obj.Id == id);
        }


        public List<Operations> GetAllOperations()
        {
            // TODO: implement
            return null;
        }

        public List<Patient> GetPatients()
        {
            // TODO: implement
            return null;
        }

    }
}