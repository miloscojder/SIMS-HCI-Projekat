using Model;
using Projekat.Model;
using Projekat.Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat.Service
{
    class RenovationService
    {
        public RenovationRepository renovationRepository = new RenovationRepository();
        private readonly AppointmentService appointmentService = new AppointmentService();
        public CheckingAppointmentAvailabilityForRenovationService checkingAppointmentAvailibilityForRenovationService = new CheckingAppointmentAvailabilityForRenovationService();


        public List<RenovationAppointment> GetAllRenovation()
        {
            return renovationRepository.GetAllRenovation();
        }

        public void Save(RenovationAppointment appointment)
        {
            renovationRepository.Save(appointment);
        }

        public void DeleteRenovation(int id)
        {
            renovationRepository.DeleteRenovation(id);
        }
        public int GenerateNewId()
        {
            return renovationRepository.GenerateNewId();
        }

        public void AttachRooms(int roomAId, int roomBId, DateTime dateTime, double duration)
        {
            Appointment appointment1 = new Appointment(dateTime, duration, roomAId);
            Appointment appointment2 = new Appointment(dateTime, duration, roomBId);
            if (checkingAppointmentAvailibilityForRenovationService.IsRoomAvailable(appointment1) && checkingAppointmentAvailibilityForRenovationService.IsRoomAvailable(appointment2))
            {
                checkingAppointmentAvailibilityForRenovationService.SaveRenovation(appointment1);
                checkingAppointmentAvailibilityForRenovationService.SaveRenovation(appointment2);
                RenovationAppointment renovation = new RenovationAppointment(GenerateNewId(), dateTime, duration, roomAId, roomBId, "bla", 0);
                //renovation.type = "1";
                Save(renovation);
            }
        }
        public void DettachRooms(int roomId, DateTime dateTime, double duration)
        {
            Appointment appointment1 = new Appointment(dateTime, duration, roomId);
            if (checkingAppointmentAvailibilityForRenovationService.IsRoomAvailable(appointment1))
            {
                checkingAppointmentAvailibilityForRenovationService.SaveRenovation(appointment1);
                RenovationAppointment renovation = new RenovationAppointment(GenerateNewId(), dateTime, duration, roomId, 0, "bla", 1);
                //renovation.type = "1";
                Save(renovation);
            }

        }
    }
}
