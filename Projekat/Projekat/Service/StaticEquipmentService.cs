


using Model;
using System;
using System.Collections.Generic;
using Repository;
using System.Linq;


namespace Service
{
   public class StaticEquipmentService
   {
        public StaticEquipmentRepository staticEquipmentRepository = new StaticEquipmentRepository();
        private List<StaticEquipment> staticEquipments = new List<StaticEquipment>();

        public void Save(StaticEquipment newEquipment)
      {
            staticEquipmentRepository.Save(newEquipment);
      }
      
      public List<StaticEquipment> GetAll()
      {
            
            return staticEquipmentRepository.GetAll();
      }
      
      public Boolean UpdateEquipment(StaticEquipment newStaticEquipment)
      {
         
         return staticEquipmentRepository.UpdateEquipment(newStaticEquipment);
      }

        public StaticEquipment GetOne(int id)
        {
            return staticEquipmentRepository.GetOne(id);
        }

        public Boolean DeleteEquipment(int id)
      {
         
         return staticEquipmentRepository.DeleteEquipment(id);
      }

        public List<StaticEquipment> GetEquipmentByRoomId(int id) {
            return staticEquipmentRepository.GetEquipmentByRoomId(id);
        }



        public int GenerateNewId()
        {
            return staticEquipmentRepository.GenerateNewId();
        }


    }
}