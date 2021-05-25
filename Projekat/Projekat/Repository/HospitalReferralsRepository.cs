/***********************************************************************
 * Module:  ReferralPatientRepository.cs
 * Author:  kriss
 * Purpose: Definition of the Class Repository.ReferralPatientRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Model;
using Newtonsoft.Json;

namespace Repository
{
   public class HospitalReferralsRepository
   {
        public HospitalReferralsRepository()
        {
            if (!File.Exists(FileLocation))
            {
                File.Create(FileLocation).Close();
            }
            using (StreamReader r = new StreamReader(FileLocation))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    referrals = JsonConvert.DeserializeObject<List<HospitalReferrals>>(json);
                }

            }
        }
        public int GenerateNewId()
        {
            try
            {
                int maxId = referrals.Max(obj => obj.Id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }
        public void Update(HospitalReferrals ana)
        {
            int index = referrals.FindIndex(obj => obj.Id == ana.Id);
            referrals[index] = ana;
            WriteToJson();
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(referrals);
            File.WriteAllText(FileLocation, json);
        }

        public List<HospitalReferrals> GetAllHospitalRefferalsByPatientsUsername(String loggedUsername)
        {
            List<HospitalReferrals> patientsHospitalReferrals = new List<HospitalReferrals>();
            for (int i = 0; i < referrals.Count; i++) {
                HospitalReferrals hr = referrals[i];
                if (hr.Patient.Username == loggedUsername)
                {
                    patientsHospitalReferrals.Add(hr);
                }
            }

            return patientsHospitalReferrals;
        }

        public void CreateReferral(HospitalReferrals newReferral)
      {
            referrals.Add(newReferral);
            WriteToJson();
      }

        public HospitalReferrals GetReferral(HospitalReferrals refr)
        {
            return referrals.Find(obj => obj.Id == refr.Id);
        }

        public List<HospitalReferrals> GetAll()
        {
            return referrals;
        }


        public string FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\hospitalreferrals.json";
        public List<HospitalReferrals> referrals = new List<HospitalReferrals>();
    }
}