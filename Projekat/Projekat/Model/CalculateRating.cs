/***********************************************************************
 * Module:  Doctor.cs
 * Author:  kriss
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/


using System;
using System.Collections.Generic;

namespace Model
{
    public class CalculateRating
    {
        public double doctorCounter { get; set; }           
        public double doctorGradeSum { get; set; }         
              
        public List<String> doctorFeedbacks { get; set; }

        public CalculateRating() { }

    }
}