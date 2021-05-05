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
   public class ReferralPatientRepository
   {
        public ReferralPatientRepository()
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
                    referrals = JsonConvert.DeserializeObject<List<ReferralPatient>>(json);
                }

            }
        }
        public int GenerateNewId()
        {
            try
            {
                int maxId = referrals.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(referrals);
            File.WriteAllText(FileLocation, json);
        }
        public void CreateReferral(ReferralPatient newReferral)
      {
            referrals.Add(newReferral);
            WriteToJson();
      }

        public ReferralPatient GetReferral(ReferralPatient refr)
        {
            return referrals.Find(obj => obj.id == refr.id);
        }

        public List<ReferralPatient> GetAll()
        {
            return referrals;
        }


        public string FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\referrals.json";
        public List<ReferralPatient> referrals = new List<ReferralPatient>();
    }
}