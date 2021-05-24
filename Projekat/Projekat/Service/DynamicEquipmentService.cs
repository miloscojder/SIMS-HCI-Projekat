/***********************************************************************
 * Module:  EquipmentFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.EquipmentFileStorage
 ***********************************************************************/


using Model;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class DynamicEquipmentService
   {
        public DynamicEquipmentRepository dynamicEquipmentRepository = new DynamicEquipmentRepository();
        private List<DynamicEquipment> dynamicEquipments = new List<DynamicEquipment>();

        public void MoveDynamicEquipment(DynamicEquipment dynamicEquipment)
        {
            dynamicEquipmentRepository.MoveDynamicEquipment(dynamicEquipment);
        }


        public void Save(DynamicEquipment newEquipment)
      {
            // TODO: implement
            dynamicEquipmentRepository.Save(newEquipment);
      }
      
      public List<DynamicEquipment> GetAll()
      {
         // TODO: implement
         return dynamicEquipmentRepository.GetAll();
      }
      
      public Boolean UpdateEquipment(DynamicEquipment dynamicEquipment)
      {
         // TODO: implement
         dynamicEquipmentRepository.UpdateEquipment(dynamicEquipment);
         return true;
      }
      
      public Boolean DeleteEquipment(int id)
      {
            dynamicEquipmentRepository.DeleteEquipment(id);
            return true;
        }
        public int GenerateNewId()
        {
            return dynamicEquipmentRepository.GenerateNewId();
        }


    }
}