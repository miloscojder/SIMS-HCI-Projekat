/***********************************************************************
 * Module:  AppointmentFileStorage.cs
 * Author:  Aleksa & kriss
 * Purpose: Definition of the Class AppointmentFileStorage
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class AppointmentFileStorage
    {
        public void Save(Appointment newAppointment)
        {
            // TODO: implement

        }

        public List<Appointment> GetAll()
        {
            char delimeter = ',';
            string fileToRead = "/Users/Ana_Marija/source/repos/Projekat/appointments.txt";
            string currentLine = string.Empty;
            List<Appointment> spisak = new List<Appointment>();


            using (StreamReader reader = new StreamReader(fileToRead))
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    Appointment temp = new Appointment();

                    string[] parths = currentLine.Split(delimeter);

                    temp.Id = parths[0];
                    temp.TimeStart = Convert.ToDateTime(parths[1]);
                    temp.Duration = Convert.ToDouble(parths[2]);
                    temp.Finished = Convert.ToBoolean(parths[3]);
                    temp.EndTime = Convert.ToDateTime(parths[4]);


                    //popraviti ovo
                    //    temp.room.Name= parths[5];    
                    //   temp.patient.user.Username = parths[6];
                    //  temp.doctor.user.Username = parths[7];

                    spisak.Add(temp);

                }
            }

            return spisak;
        }

        private String FileLocation;

    }
}
