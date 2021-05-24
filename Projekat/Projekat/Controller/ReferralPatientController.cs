/***********************************************************************
 * Module:  ReferralPatientRepository.cs
 * Author:  kriss
 * Purpose: Definition of the Class Repository.ReferralPatientRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;
using Service;

namespace Controller
{
   public class ReferralPatientController
   {
        public ReferralPatientService referralPatientService = new ReferralPatientService();
        public void CreateReferral(ReferralPatient newReferral)
        {
            referralPatientService.CreateReferral(newReferral);
        }

        public int GenerateNewId()
        {
            return referralPatientService.GenerateNewId();

        }


        public List<ReferralPatient> GetAll()
        {
            return referralPatientService.GetAll();
        }

        public ReferralPatient GetReferral(ReferralPatient newReferral)
        {
            return referralPatientService.GetReferral(newReferral);
        }

    }
}