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
        public DoctorRepository doctorRepository = new DoctorRepository();

        public int GenerateNewId()
        {
            return doctorRepository.GenerateNewId();

        }
        public Doctor FindDoctorByUsernameAndPassword(String username, String password)
        {
           
            return doctorRepository.FindDoctorByUsernameAndPassword(username, password);

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

        public void DeleteDoctorById(int id)
        {
            doctorRepository.DeleteDoctorById(id);
        }
        
        public int AppointmentsWithThisDoctor(List<Appointment> appointments, Doctor doctor)
        {
            int brojac = 0;
            for (int i = 0; i < appointments.Count; i++)
            {
                Appointment app = appointments[i];
                if (app.DoctorUsername == doctor.Username)
                {
                    brojac++;
                }
            }
            return brojac;
        }

        public List<string> GetAllDoctorUsernames()
        {
            return doctorRepository.GetAllDoctorUsernames();
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