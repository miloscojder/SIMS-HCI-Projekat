/***********************************************************************
 * Module:  Employee.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Employee
 ***********************************************************************/

using System;

namespace Model
{
   public class Employee : User
   {
      public double Salary;
      public TimeSpan VacationTime;
      public TimeSpan WorkingHours;
      public int WorkingExperince;
   
   }
}