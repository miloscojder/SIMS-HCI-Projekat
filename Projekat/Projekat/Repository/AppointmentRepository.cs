/***********************************************************************
 * Module:  AppointmentFileStorage.cs
 * Author:  kriss
 * Purpose: Definition of the Class AppointmentFileStorage
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class AppointmentRepository
   {

        public string FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\appointments.json";
        public List<Appointment> appointments = new List<Appointment>();

        public AppointmentRepository()
        {
            if(!File.Exists(FileLocation))
            {
                File.Create(FileLocation).Close();
            }
            using (StreamReader r = new StreamReader(FileLocation))
            {
                string json = r.ReadToEnd();
                if(json!="")
                {
                    appointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
                }

            }
        }
        public int GenerateNewId()
        {
            try
            {
                int maxId = appointments.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }
        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(appointments);
            File.WriteAllText(FileLocation, json);
        }
      public void ScheduleDoctor(Appointment appointment)
      {
          appointments.Add(appointment);
            WriteToJson();
        }
      
      public void RescheduleDoctor(Appointment appointment)
      {
            int index = appointments.FindIndex(obj => obj.id == appointment.id);
            appointments[index] = appointment;
            WriteToJson();
      }
      
      public void Cancel(Appointment newAppointemnt)
      {
            int index = appointments.FindIndex(obj => obj.id == newAppointemnt.id);
            appointments.RemoveAt(index);
            WriteToJson();
           // return false;
      }

       public List<Appointment> GetAppointmentsByPatientsUsername(String username)
        {
            List<Appointment> patientsAppointment = new List<Appointment>();
            foreach (Appointment a in appointments)
            {
                if(a.PatientUsername == username)
                {
                    patientsAppointment.Add(a);
                }
            }

            return patientsAppointment;
        }

        public void SaveAppointment(Appointment newAppointment)
        {
            appointments.Add(newAppointment);
            WriteToJson();
        }

        public List<DateTime> GetDoctosBusyTimes(String doctrsUsername)
        {
            List<DateTime> doctorsBusyTimes = new List<DateTime>();
            for (int i = 0; i < appointments.Count; i++)
            {
                Appointment a = appointments[i];
                if (a.DoctorUsername==doctrsUsername)
                {
                    doctorsBusyTimes.Add(a.StartTime);
                }
            }
            return doctorsBusyTimes;
        }

        public void DeleteAppointmentById(int id)
        {
            for (int i = 0; i < appointments.Count; i++)
            {
                Appointment a = appointments[i];
                if (a.id == id)
                {
                    appointments.Remove(a);
                }
            }
            WriteToJson();
        }

  
   
    
      
      public List<Appointment> GetAll()
      {
         return appointments;
      }

        public List<Appointment> GetAllForUser(Doctor doctor)
        {
            return appointments.FindAll(obj => obj.DoctorUsername == doctor.Username); 
       
        }


      
      public Appointment GetAppointment(int idd)
      {
         return appointments.Find(obj => obj.id == idd);
      }

      


   }
}