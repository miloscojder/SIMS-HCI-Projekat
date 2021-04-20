/***********************************************************************
 * Module:  EquipmentFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.EquipmentFileStorage
 ***********************************************************************/


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
            // TODO: implement
            return staticEquipmentRepository.GetAll();
      }
      
      public Boolean UpdateEquipment(StaticEquipment newStaticEquipment)
      {
         // TODO: implement
         return staticEquipmentRepository.UpdateEquipment(newStaticEquipment);
      }
      
      public Boolean DeleteEquipment(int id)
      {
         // TODO: implement
         return staticEquipmentRepository.DeleteEquipment(id);
      }
      
      public StaticEquipment CreateEquipment2()
      {
         // TODO: implement
         return null;
      }
        public int GenerateNewId()
        {
            try
            {
                int maxId = staticEquipments.Max(obj => obj.Id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }


    }
}