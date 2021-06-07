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

        public Doctor FindDoctorByUsernameAndPassword(String username, String password)
        {

            return doctorService.FindDoctorByUsernameAndPassword(username, password);

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
        public Doctor GetDoctor(int id)
        {
            return doctorService.GetDoctor(id);
        }



 /*       public Doctor FindDoctorByUsernameAndPassword(String username, String password) {

            return doctorService.FindDoctorByUsernameAndPassword(username, password);
        }*/

public Doctor FindDoctorByUsernameAndPassword(String username, String password) {

            return doctorService.FindDoctorByUsernameAndPassword(username, password);
        }


 /*       public int AppointmentsWithThisDoctor(List<Appointment> appointments,Doctor doctor)
       {
=======

        public int AppointmentsWithThisDoctor(List<Appointment> appointments,Doctor doctor)
        {

            return doctorService.AppointmentsWithThisDoctor(appointments, doctor);
        }

        public List<string> GetAllDoctorUsernames()
        {
            return doctorService.GetAllDoctorUsernames();
        }
 */

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