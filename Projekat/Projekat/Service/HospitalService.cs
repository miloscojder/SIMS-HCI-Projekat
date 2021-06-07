using Model;
using System;
using System.Collections.Generic;
using Repository;


namespace Service
{
    public class HospitalService
    {
        public HospitalRepository hospitalRepository = new HospitalRepository();
        public Hospital hospital = new Hospital();

        public Hospital GetAllHospitalsData()
        {
            hospital = hospitalRepository.GetAllHospitalsData();
            return hospital;
        }

        public void WriteHospitalToJason(Hospital hospital)
        {
            hospitalRepository.WriteHospitalToJason(hospital);
        }

       

    }
}
