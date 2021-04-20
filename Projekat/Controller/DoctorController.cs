/***********************************************************************
 * Module:  Doctor.cs
 * Author:  kriss
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class DoctorController
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
   
      public System.Collections.ArrayList doctorService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDoctorService()
      {
         if (doctorService == null)
            doctorService = new System.Collections.ArrayList();
         return doctorService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDoctorService(System.Collections.ArrayList newDoctorService)
      {
         RemoveAllDoctorService();
         foreach (Service.DoctorService oDoctorService in newDoctorService)
            AddDoctorService(oDoctorService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDoctorService(Service.DoctorService newDoctorService)
      {
         if (newDoctorService == null)
            return;
         if (this.doctorService == null)
            this.doctorService = new System.Collections.ArrayList();
         if (!this.doctorService.Contains(newDoctorService))
            this.doctorService.Add(newDoctorService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDoctorService(Service.DoctorService oldDoctorService)
      {
         if (oldDoctorService == null)
            return;
         if (this.doctorService != null)
            if (this.doctorService.Contains(oldDoctorService))
               this.doctorService.Remove(oldDoctorService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDoctorService()
      {
         if (doctorService != null)
            doctorService.Clear();
      }
   
   }
}