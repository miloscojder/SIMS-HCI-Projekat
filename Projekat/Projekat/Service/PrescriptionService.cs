/***********************************************************************
 * Module:  Anamnesis.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.Anamnesis
 ***********************************************************************/

using System;
using Model;
using Repository;
using System.Collections.Generic;

namespace Service
{
   public class PrescriptionService
   {
        public PrescriptionRepository prescriptionRepository = new PrescriptionRepository();
        public void CreatePrescription(Prescription newPrescription)
      {
            prescriptionRepository.CreatePrescription(newPrescription);
        }

        public int GenerateNewId()
        {
            return prescriptionRepository.GenerateNewId();

        }

        public void UpdatePrescription(Prescription newPrescription)
      {
            prescriptionRepository.UpdatePrescription(newPrescription);
        }
        public List<Prescription> GetAll()
        {
            return prescriptionRepository.GetAll();
        }

        public Prescription GetPrescription(Prescription newPrescription)
        {
            return prescriptionRepository.GetPrescription(newPrescription);
        }




    }
}