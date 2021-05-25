using System;
using Service;
using Model;
using System.IO;
using System.Collections.Generic;
using Repository;

namespace Controller
{
    public class HospitalController
    {
        public HospitalService hospitalService = new HospitalService();
        public Hospital hospital;

        public Hospital GetAllHospitalsData()
        {
            hospital = hospitalService.GetAllHospitalsData();
            return hospital;
        }

        public void WriteHospitalToJason(Hospital hospital)
        {
            hospitalService.WriteHospitalToJason(hospital);
        }
        
        public void DeleteOutDatedActivities(List<DateTime> timesOfActivities,  TimeSpan timeSpanOfReset)
        {
            hospitalService.DeleteOutDatedActivities(timesOfActivities,  timeSpanOfReset);
        }

    }
}
