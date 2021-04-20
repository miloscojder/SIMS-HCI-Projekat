/***********************************************************************
 * Module:  EquipmentFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.EquipmentFileStorage
 ***********************************************************************/

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