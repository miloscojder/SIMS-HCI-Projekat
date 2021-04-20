/***********************************************************************
 * Module:  Appointment.cs
 * Author:  kriss
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using System;

namespace Model
{
   public class Appointment
   {
      public String Id;
      public DateTime Date;
      public DateTime TimeStart;
      public double Duration;
      public Boolean Finished;
      public DateTime EndTime;
      public TypeOfAppointment AppointmentType;
      public MedicalRecord MedicalRecord;
      
      public Room room;
      public Patient patient;
      public Doctor doctor;
      public Anamnesis anamnesis;
   
   }
}