/***********************************************************************
 * Module:  Doctor.cs
 * Author:  kriss
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;

namespace Model
{
    public class Doctor : Employee
    {
        public String Specialty { get; set; }
        public Appointment Appointments;
        public Boolean Free { get; set; }
        public Doctor doctor { get; set; }
        public List<Doctor> doctors { get; set; }
        public System.Collections.ArrayList request;
        public System.Collections.ArrayList appointment;
        public Employee Employee { get; set; }
        public User User;


        public Doctor() { }
        public Doctor(string specialty, Boolean free)
        {
            Specialty = specialty;
            Free = free;
        }

        public Employee employee
        {
            get { return Employee; }
            set { Employee = value; }
        }

        public string specialty
        {
            get { return Specialty; }
            set { Specialty = value; }
        }

        public Boolean free
        {
            get { return Free; }
            set { Free = value; }
        }
        public Doctor GetDoctor(string id)
        {
            return doctor;
        }
        public void SetDoctor(Doctor doctor) => this.doctor = doctor;

        public List<Doctor> GetAllDoctors()
        {
            return doctors;
        }
        public void SetDoctors(List<Doctor> doctors) => this.doctors = doctors;
        public List<Doctor> GetSpecialty(string specialty)
        {
            return doctors;
        }
        public void SetDoctorsSpecialty(List<Doctor> specialty) => specialty = doctors;


        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetRequest()
        {
            if (request == null)
                request = new System.Collections.ArrayList();
            return request;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetRequest(System.Collections.ArrayList newRequest)
        {
            RemoveAllRequest();
            foreach (Request oRequest in newRequest)
                AddRequest(oRequest);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddRequest(Request newRequest)
        {
            if (newRequest == null)
                return;
            if (this.request == null)
                this.request = new System.Collections.ArrayList();
            if (!this.request.Contains(newRequest))
            {
                this.request.Add(newRequest);
                newRequest.SetDoctor(this);
            }
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveRequest(Request oldRequest)
        {
            if (oldRequest == null)
                return;
            if (this.request != null)
                if (this.request.Contains(oldRequest))
                {
                    this.request.Remove(oldRequest);
                    oldRequest.SetDoctor((Doctor)null);
                }
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllRequest()
        {
            if (request != null)
            {
                System.Collections.ArrayList tmpRequest = new System.Collections.ArrayList();
                foreach (Request oldRequest in request)
                    tmpRequest.Add(oldRequest);
                request.Clear();
                foreach (Request oldRequest in tmpRequest)
                    oldRequest.SetDoctor((Doctor)null);
                tmpRequest.Clear();
            }
        }


        public System.Collections.ArrayList GetAppointment()
        {
            if (appointment == null)
                appointment = new System.Collections.ArrayList();
            return appointment;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetAppointment(System.Collections.ArrayList newAppointment)
        {
            RemoveAllAppointment();
            foreach (Appointment oAppointment in newAppointment)
                AddAppointment(oAppointment);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddAppointment(Appointment newAppointment)
        {
            if (newAppointment == null)
                return;
            if (this.appointment == null)
                this.appointment = new System.Collections.ArrayList();
            if (!this.appointment.Contains(newAppointment))
            {
                this.appointment.Add(newAppointment);
                newAppointment.SetDoctor(this);
            }
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveAppointment(Appointment oldAppointment)
        {
            if (oldAppointment == null)
                return;
            if (this.appointment != null)
                if (this.appointment.Contains(oldAppointment))
                {
                    this.appointment.Remove(oldAppointment);
                    oldAppointment.SetDoctor((Doctor)null);
                }
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllAppointment()
        {
            if (appointment != null)
            {
                System.Collections.ArrayList tmpAppointment = new System.Collections.ArrayList();
                foreach (Appointment oldAppointment in appointment)
                    tmpAppointment.Add(oldAppointment);
                appointment.Clear();
                foreach (Appointment oldAppointment in tmpAppointment)
                    oldAppointment.SetDoctor((Doctor)null);
                tmpAppointment.Clear();
            }
        }
    }
}