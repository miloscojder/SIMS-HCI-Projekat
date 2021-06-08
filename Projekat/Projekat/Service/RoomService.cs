

using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
   public class RoomService
   {
        public RoomRepository roomRepository = new RoomRepository();
        public readonly AppointmentService appointmentService = new AppointmentService();
        public StaticEquipmentRepository staticRepository = new Repository.StaticEquipmentRepository();
     

        public Boolean ClassicRenovation(int roomId, DateTime renovationDate, double duration)
      {
            Appointment appointment = new Appointment(renovationDate, duration, roomId);
            if (appointmentService.IsRoomAvailable(appointment))
            {
                appointmentService.SaveRenovation(appointment);
                return true;
            }
            else
            {
                return false;
            }
        }
      
      public Boolean AdvancedRenovation(Room room)
      {
         // TODO: implement
         return false;
      }

        public void MoveStaticEquipment(int staticId, int toRoom)
        {

                StaticEquipment staticEquipment = staticRepository.GetOne(staticId);
                Room room = GetRoom(staticEquipment.RoomId);
                room.StaticEquipments.Remove(staticEquipment);
                Room room2 = GetRoom(toRoom);
                staticEquipment.RoomId = room2.Id;
                room2.StaticEquipments.Add(staticEquipment);
                staticRepository.UpdateEquipment(staticEquipment);

                UpdateRoom(room);
                UpdateRoom(room2);

        }

 
      
      public void Save(Room newRoom)
      {
            roomRepository.Save(newRoom);
      }
      
      public Room GetRoom(int id)
      {
            return roomRepository.GetRoom(id);
      }

        public Room GetByName(String name)
        {
            return roomRepository.GetByName(name);
        }

        public List<Room> GetAllRooms()
      {
           
           return roomRepository.GetAllRooms();
      }
      
      public Boolean UpdateRoom(Room newRoom)
      {
         roomRepository.UpdateRoom(newRoom);
         return true;
      }
      
      public Boolean DeleteRoom(int id)
      {
         roomRepository.DeleteRoom(id);
         return true;
      }

        public void AttachRooms(int roomAId, int roomBId)
        {
            Room roomA = GetRoom(roomAId);
            Room roomB = GetRoom(roomBId);


            ExtractEquipment(roomB, roomA);
            roomA.Name = roomA.Name + "/" + roomB.Name;

            UpdateRoom(roomA);
            DeleteRoom(roomBId);
        }

        private void ExtractEquipment(Room fromRoom, Room toRoom)
        {
            foreach (StaticEquipment staticEquipment in fromRoom.StaticEquipments)
                toRoom.StaticEquipments.Add(staticEquipment);
        }

        public void DettachRooms(int roomId)
        {
            Room roomA = GetRoom(roomId);
            Room room = new Room(GenerateNewId(),roomA.Name + "-" + roomA.Name + "1", roomA.RoomType, roomA.Floor, roomA.Detail);
            Save(room);
            
        }

        public int GenerateNewId()
        {
            return roomRepository.GenerateNewId();
        }



    }
}