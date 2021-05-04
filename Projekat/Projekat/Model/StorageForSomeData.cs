using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat.Model
{
    public class StorageForSomeData
    {
        public double hospitalCounter { get; set; }
        public double hospitalFinalGrade { get; set; }
        public double hospitalGradeSum { get; set; }
        public String hospitalFeedback { get; set; }

        public StorageForSomeData() { }

        public StorageForSomeData(double hc, double hfg, double hgs, String hf) {
            hospitalCounter = hc;
            hospitalFinalGrade = hfg;
            hospitalGradeSum = hgs;
            hospitalFeedback = hf;
        }
    }

}
