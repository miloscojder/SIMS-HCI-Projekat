/***********************************************************************
 * Module:  Doctor.cs
 * Author:  kriss
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/


using Model;
using Repository;
using System;
using System.Collections.Generic;


namespace Service
{
   public class DoctorService
   {
        public  DoctorRepository doctorRepository = new DoctorRepository();

        public int GenerateNewId()
        {
            return doctorRepository.GenerateNewId();

        }

        public void AddDoctor(Doctor doctor)
        {
            doctorRepository.AddDoctor(doctor);
        }

        public void Save(Doctor doctor)
        {
            doctorRepository.Save(doctor);
        }

        public List<Doctor> GetAllDoctorsSpecialist(String specialization)
        {
            return doctorRepository.GetAllDoctorsSpecialist(specialization);
        }

        public List<Doctor> GetAllDoctors()
        {
            return doctorRepository.GetAllDoctors();
        }
        public Doctor GetDoctor(int id)
        {
            return doctorRepository.GetDoctor(id);
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