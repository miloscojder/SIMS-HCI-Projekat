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
      
      public Appointment StartAppointment()
      {
         // TODO: implement
         return null;
      }
      
      public Appointment ScedulePatient(DateTime timeStart, DateTime endTime, Model.Doctor doctor, Model.Room room, String id)
      {
         // TODO: implement
         return null;
      }
      
      public void ReschedulePatient(DateTime tImeStart, DateTime timeEnd, Model.Doctor doctor, Model.Room room, String id)
      {
         // TODO: implement
      }
      
      public Appointment DatePriority(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Appointment DoctorPriority(Model.Doctor parameter1)
      {
         // TODO: implement
         return null;
      }
      
    
      
      public List<Appointment> GetAll()
      {
         return appointments;
      }
      


        public List<Doctor> GetAllDoctors()
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetSpecialty()
      {
         // TODO: implement
         return null;
      }
      
      public Appointment GetAppointment(int idd)
      {
         return appointments.Find(obj => obj.id == idd);
      }

      

        public string FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\appointments.json";
      public List<Appointment> appointments = new List<Appointment>();
        public Appointment appointment = new Appointment();
   
   }
}