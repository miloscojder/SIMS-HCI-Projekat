/***********************************************************************
 * Module:  EquipmentFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.EquipmentFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class StaticEquipmentRepository
   {
      public void Save(Model.StaticEquipment newEquipment)
      {
         // TODO: implement
      }
      
      public Model.StaticEquipment GetOne(int id)
      {
         // TODO: implement
         return null;
      }
      
      public List<StaticEquipment> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Boolean UpdateEquipment()
      {
         // TODO: implement
         return false;
      }
      
      public Boolean DeleteEquipment()
      {
         // TODO: implement
         return false;
      }
      
      public StaticEquipment CreateEquipment()
      {
         // TODO: implement
         return null;
      }
   
      public String FileLocation;
   
   }
}