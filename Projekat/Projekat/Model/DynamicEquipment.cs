/***********************************************************************
 * Module:  StaticEquipment.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.StaticEquipment
 ***********************************************************************/

using System;

namespace Model
{
   public class DynamicEquipment
   {
      public int Id { get; set; }
      public String Name { get; set; }
        public EquipmentType Type { get; set; }
        public int Quantity { get; set; }

        public DynamicEquipment(int id, string name, EquipmentType type, int quantity)
        {
            Id = id;
            Name = name;
            Type = type;
            Quantity = quantity;


        }
    }
}