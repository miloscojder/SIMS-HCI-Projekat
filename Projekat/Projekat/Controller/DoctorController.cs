/***********************************************************************
 * Module:  Doctor.cs
 * Author:  kriss
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/


using Model;
using System;
using Service;
using System.Collections.Generic;

namespace Controller
{
    public class DoctorController
    {
        public DoctorService doctorService = new DoctorService();

        public int GenerateNewId()
        {
            return doctorService.GenerateNewId();

        }

        public void AddDoctor(Doctor doctor)
        {
            doctorService.AddDoctor(doctor);
        }

        public void Save(Doctor doctor)
        {
            doctorService.Save(doctor);
        }

        public List<Doctor> GetAllDoctorsSpecialist(String specialization)
        {
            return doctorService.GetAllDoctorsSpecialist(specialization);
        }

        public List<Doctor> GetAllDoctors()
        {
            return doctorService.GetAllDoctors();
        }
        public Doctor GetDoctor(string id)
        {
            return doctorService.GetDoctor(id);
        }


        public List<Appointment> GetAllAppointments()
        {
            // TODO: implement
            return null;
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