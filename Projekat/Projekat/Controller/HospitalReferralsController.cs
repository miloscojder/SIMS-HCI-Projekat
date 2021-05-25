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
   public class HospitalReferralsController
    {
        public HospitalReferralsService hospitalReferralsService = new HospitalReferralsService();
        public void CreateReferral(HospitalReferrals newReferral)
        {
            hospitalReferralsService.CreateReferral(newReferral);
        }

        public int GenerateNewId()
        {
            return hospitalReferralsService.GenerateNewId();

        }
        public void Update(HospitalReferrals ana)
        {
            hospitalReferralsService.Update(ana);
        }



        public List<HospitalReferrals> GetAll()
        {
            return hospitalReferralsService.GetAll();
        }

        public HospitalReferrals GetReferral(HospitalReferrals newReferral)
        {
            return hospitalReferralsService.GetReferral(newReferral);
        }

    }
}