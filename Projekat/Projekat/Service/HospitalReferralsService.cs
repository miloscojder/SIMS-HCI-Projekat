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
   public class HospitalReferralsService
    {
        public HospitalReferralsRepository hospitalReferralsRepository = new HospitalReferralsRepository();
        public List<HospitalReferrals> hospitalReferrals;

        public void CreateReferral(HospitalReferrals newReferral)
      {
            hospitalReferralsRepository.CreateReferral(newReferral);
      }

        public int GenerateNewId()
        {
            return hospitalReferralsRepository.GenerateNewId();

        }

        public void Update(HospitalReferrals ana)
        {
            hospitalReferralsRepository.Update(ana);
        }

        public List<HospitalReferrals> GetAllHospitalRefferalsByPatientsUsername(String loggedUsername)
        {
            hospitalReferrals = hospitalReferralsRepository.GetAllHospitalRefferalsByPatientsUsername(loggedUsername);
            return hospitalReferrals;
        }

        public List<HospitalReferrals> GetAll()
        {
            return hospitalReferralsRepository.GetAll();
        }

        public HospitalReferrals GetReferral(HospitalReferrals newReferral)
        {
            return hospitalReferralsRepository.GetReferral(newReferral);
        }



    }
}