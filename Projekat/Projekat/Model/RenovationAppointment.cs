using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat.Model
{
    class RenovationAppointment : Appointment
    {
        public RenovationAppointment(int id, DateTime startTime, Double durationInMinutes, int roomAId, int roomBId, string description, int type) : base( startTime, durationInMinutes, roomAId)
        {
            Description = description;
            RoomBId = roomBId;
            Type = type;
        }

        public string Description { get; set; }
        public int RoomBId { get; set; }
        public int Type { get; set; }
    }
}
