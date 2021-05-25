namespace Model
{
    public class HospitalGrade
    {
        public double hospitalGradeCounter { get; set; }
        public double hospitalFinalGrade { get; set; }
        public double hospitalGradeSum { get; set; }

        public HospitalGrade(double hgc, double hfg, double hgs)
        {  
            hospitalGradeCounter = hgc;
            hospitalFinalGrade = hfg;
            hospitalGradeSum = hgs;
        }

        public HospitalGrade() { }


    }
}