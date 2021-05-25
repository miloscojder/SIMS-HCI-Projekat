using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Hospital 
    //StorageForSomeData
    {

        public String HospitalName { get; set; }
        public String HospitalAdress { get; set; }

        public List<String> hospitalFeedback { get; set; }

        public HospitalGrade gradesOfThisHospital { get; set; }
        public int activityCounter { get; set; }
       

        public Hospital() {}   
       
    }


}
