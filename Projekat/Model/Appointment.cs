using System;
using System.Collections.Generic;

namespace Model
{
    public class Appointment
    {



        public Appointment() { }

        public Appointment(DateTime timeStart, DateTime endTime, Doctor doctor, Room room, string id)
        {
            this.Id = Id;
            this.TimeStart = timeStart;
            this.EndTime = endTime;
            this.room = room;
            this.doctor = doctor;
        }

        public Appointment ScheduleDoctor(DateTime timeStart, DateTime endTime, Doctor doctor, Room room, String id)
        {
            Appointment novi = new Appointment(timeStart, endTime, doctor, room, id);
            return novi;
        }

        public void RescheduleDoctor(DateTime timeStart, DateTime endTime, Doctor doctor, Room room, String id)
        {
            this.TimeStart = timeStart;
            this.EndTime = endTime;
            this.doctor = doctor;
            this.room = room;
            this.Id = id;
        }


        public void Cancel(Appointment newAppointment)
        {
            doctor.RemoveAppointment(newAppointment);
            return;
        }


        public Appointment StartAppointment()
        {
            // TODO: implement
            return null;
        }

        public Appointment GetAppointment()
        {
            // TODO: implement
            return null;
        }

        public List<Appointment> GetAllAppointments()
        {
            // TODO: implement
            return null;
        }

        public Appointment ScedulePatient(DateTime timeStart, DateTime endTime, Doctor doctor, Room room, string id)
        {
            //treba da se doradi da se podaci ucitaju sa text boxova

            Appointment novi = new Appointment(timeStart, endTime, doctor, room, id);
            return novi;
        }

        public void ReschedulePatient(DateTime tImeStart, DateTime timeEnd, Doctor doctor, Room room, string id)
        {
            //treba da se doradi da se podaci ucitaju sa text boxova
            //treba da se uformatira da broj kolona bude isti ovde i u ListView-u

            this.TimeStart = tImeStart;
            this.EndTime = timeEnd;
            this.doctor = doctor;
            this.room = room;
            this.Id = id;
        }

        public String Id { get; set; }
        public DateTime TimeStart { get; set; }
        public double Duration { get; set; }
        public Boolean Finished { get; set; }
        public DateTime EndTime { get; set; }
        public TypeOfAppointment AppointmentType { get; set; }

        public Room room;
        public Patient patient;
        public Doctor doctor;
        public System.Collections.ArrayList appointment;
        public Doctor GetDoctor(string id)
        {
            return doctor;
        }
        public void SetDoctor(Doctor newDoctor)
        {
            if (this.doctor != newDoctor)
            {
                if (this.doctor != null)
                {
                    Doctor oldDoctor = this.doctor;
                    this.doctor = null;
                    oldDoctor.RemoveAppointment(this);
                }
                if (newDoctor != null)
                {
                    this.doctor = newDoctor;
                    this.doctor.AddAppointment(this);
                }
            }
        }

        public Patient GetPatient(string id)
        {
            return patient;
        }
        public void SetPatient(Patient newPatient)
        {
            if (this.patient != newPatient)
            {
                if (this.patient != null)
                {
                    Patient oldPatient = this.patient;
                    this.patient = null;
                    // oldPatient.RemoveAppointment(this);
                }
                if (newPatient != null)
                {
                    this.patient = newPatient;
                    // this.patient.AddAppointment(this);
                }
            }
        }

    }
}