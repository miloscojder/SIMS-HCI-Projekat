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
        public List<String> hospitalFeedback { get; set; }
        public double activityCounter { get; set; }

        public StorageForSomeData() { }

        public StorageForSomeData(double hc, double hfg, double hgs) {
            hospitalCounter = hc;
            hospitalFinalGrade = hfg;
            hospitalGradeSum = hgs;
        }
    }

}
