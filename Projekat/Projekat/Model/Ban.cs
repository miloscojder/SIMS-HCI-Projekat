/***********************************************************************
 * Module:  Patient.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.Patient
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Model
{
    public class Ban
    {
        public Boolean isBaned  {get; set; }
        public int ActivitiyCounter { get; set; }
        public List<DateTime> TimeOfActivities { get; set; }

    }
}