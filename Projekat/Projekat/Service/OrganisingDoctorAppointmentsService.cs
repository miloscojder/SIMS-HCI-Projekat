using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class OrganisingDoctorAppointmentsService
    {
        public AppointmentRepository appointmentRepository = new AppointmentRepository();

        public void RescheduleDoctor(Appointment newAppointment)
        {
            appointmentRepository.RescheduleDoctor(newAppointment);

        }

        public List<Appointment> GetAllAppointmentsForDoctorUser(Doctor doctor)
        {
            return appointmentRepository.GetAllAppointmentsForDoctorUser(doctor);

        }
    }
}
