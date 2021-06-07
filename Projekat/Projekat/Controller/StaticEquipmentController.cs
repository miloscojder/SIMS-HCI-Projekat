

using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Service;

namespace Controller
{
   public class StaticEquipmentController
   {
        public StaticEquipmentService staticEquipmentService = new StaticEquipmentService();
        private List<StaticEquipment> staticEquipments = new List<StaticEquipment>();

        public void Save(StaticEquipment newEquipment)
      {
         staticEquipmentService.Save(newEquipment);
      }
      
      public List<StaticEquipment> GetAll()
      {
         // TODO: implement
         return staticEquipmentService.GetAll();
      }

        public StaticEquipment GetOne(int id)
        {
            return staticEquipmentService.GetOne(id);
        }

        public Boolean UpdateEquipment(StaticEquipment newStaticEquipment)
      {
         // TODO: implement
         return staticEquipmentService.UpdateEquipment(newStaticEquipment);
      }
      
      public Boolean DeleteEquipment(int id)
      {
         // TODO: implement
         return staticEquipmentService.DeleteEquipment(id);
      }

        public List<StaticEquipment> GetEquipmentByRoomId(int id)
        {
            return staticEquipmentService.GetEquipmentByRoomId(id);
        }

        public StaticEquipment CreateEquipment2()
      {
         // TODO: implement
         return null;
      }
        public int GenerateNewId()
        {
            return staticEquipmentService.GenerateNewId();
        }


    }
}