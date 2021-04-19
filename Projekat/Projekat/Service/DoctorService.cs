/***********************************************************************
 * Module:  Doctor.cs
 * Author:  kriss
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;


namespace Service
{
   public class DoctorService
   {
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
   
      public System.Collections.ArrayList doctorRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDoctorRepository()
      {
         if (doctorRepository == null)
            doctorRepository = new System.Collections.ArrayList();
         return doctorRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDoctorRepository(System.Collections.ArrayList newDoctorRepository)
      {
         RemoveAllDoctorRepository();
         foreach (Repository.DoctorRepository oDoctorRepository in newDoctorRepository)
            AddDoctorRepository(oDoctorRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDoctorRepository(Repository.DoctorRepository newDoctorRepository)
      {
         if (newDoctorRepository == null)
            return;
         if (this.doctorRepository == null)
            this.doctorRepository = new System.Collections.ArrayList();
         if (!this.doctorRepository.Contains(newDoctorRepository))
            this.doctorRepository.Add(newDoctorRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDoctorRepository(Repository.DoctorRepository oldDoctorRepository)
      {
         if (oldDoctorRepository == null)
            return;
         if (this.doctorRepository != null)
            if (this.doctorRepository.Contains(oldDoctorRepository))
               this.doctorRepository.Remove(oldDoctorRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDoctorRepository()
      {
         if (doctorRepository != null)
            doctorRepository.Clear();
      }
   
   }
}