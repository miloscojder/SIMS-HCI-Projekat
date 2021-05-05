/***********************************************************************
 * Module:  ReferralPatientRepository.cs
 * Author:  kriss
 * Purpose: Definition of the Class Repository.ReferralPatientRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;
using Repository;

namespace Service
{
   public class ReferralPatientService
   {
        public ReferralPatientRepository referralPatientRepository = new ReferralPatientRepository();
        public void CreateReferral(ReferralPatient newReferral)
      {
            referralPatientRepository.CreateReferral(newReferral);
      }

        public int GenerateNewId()
        {
            return referralPatientRepository.GenerateNewId();

        }

       
        public List<ReferralPatient> GetAll()
        {
            return referralPatientRepository.GetAll();
        }

        public ReferralPatient GetReferral(ReferralPatient newReferral)
        {
            return referralPatientRepository.GetReferral(newReferral);
        }



    }
}