/***********************************************************************
 * Module:  EquipmentFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.EquipmentFileStorage
 ***********************************************************************/

using Model;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class DynamicEquipmentController
   {

        public DynamicEquipmentService dynamicEquipmentService = new DynamicEquipmentService();
        private List<DynamicEquipment> dynamicEquipments = new List<DynamicEquipment>();

      
      public void Save(DynamicEquipment newEquipment)
      {
            // TODO: implement
            dynamicEquipmentService.Save(newEquipment);
      }
      
      public List<DynamicEquipment> GetAll()
      {
         // TODO: implement
         return dynamicEquipmentService.GetAll();
      }
      
      public Boolean UpdateEquipment(DynamicEquipment dynamicEquipment)
      {
            // TODO: implement
            dynamicEquipmentService.UpdateEquipment(dynamicEquipment);
         return true;
      }
      
      public Boolean DeleteEquipment(int id)
      {
            dynamicEquipmentService.DeleteEquipment(id);
            return true;
        }
        public int GenerateNewId()
        {
            return dynamicEquipmentService.GenerateNewId();
        }


    }
}