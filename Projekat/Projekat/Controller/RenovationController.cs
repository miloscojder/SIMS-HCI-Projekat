using Projekat.Model;
using Projekat.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat.Controller
{
    class RenovationController
    {
        public RenovationService renovationService = new RenovationService();

        public List<RenovationAppointment> GetAllRenovation()
        {
            return renovationService.GetAllRenovation();
        }

        public void Save(RenovationAppointment appointment)
        {
            renovationService.Save(appointment);
        }

        public void DeleteRenovation(int id)
        {
            renovationService.DeleteRenovation(id);
        }

        public void AttachRooms(int roomAId, int roomBId, DateTime dateTime, double duration)
        {
            renovationService.AttachRooms(roomAId,roomBId,dateTime,duration);
        }
        public void DettachRooms(int roomId, DateTime dateTime, double duration)
        {
            renovationService.DettachRooms(roomId, dateTime, duration);

        }
    }
}
