/***********************************************************************
 * Module:  Patient.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.Patient
 ***********************************************************************/

using System;

namespace Model
{
   public class Patient : User
   {
      public Appointment[] appointment;
   
   }
}