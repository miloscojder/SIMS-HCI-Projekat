/***********************************************************************
 * Module:  Anamnesis.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.Anamnesis
 ***********************************************************************/
using Model;
using System;
using Service;
using System.Collections.Generic;

namespace Controller
{
   public class PrescriptionController
   {
        public PrescriptionService prescriptionService = new PrescriptionService();
        public List<Prescription> patientsPrescriptions;

        public List<Prescription> GetAllPrescriptionsByPatientsUsername(String patientsUsername)
        {
            patientsPrescriptions = prescriptionService.GetAllPrescriptionsByPatientsUsername(patientsUsername);
            return patientsPrescriptions;
        }

        public void CreatePrescription(Prescription newPrescription)
      {
            prescriptionService.CreatePrescription(newPrescription);
        }

        public int GenerateNewId()
        {
            return prescriptionService.GenerateNewId();

        }

        public void UpdatePrescription(Prescription newPrescription)
      {
            prescriptionService.UpdatePrescription(newPrescription);
      }

        public List<Prescription> GetAll()
        {
            return prescriptionService.GetAll();
        }

        public Prescription GetAnamnesis(Prescription newPrescription)
        {
            return prescriptionService.GetPrescription(newPrescription);
        }

    }
}