/***********************************************************************
 * Module:  Room.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Room
 ***********************************************************************/

using System;

namespace Model
{
   public class Room
   {
      public String Id;
      public String Name;
      public int Floor;
      public RoomStatus Status;
      public String Detail;
      public String RoomType;
      
      public System.Collections.ArrayList dynamicEquipment;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDynamicEquipment()
      {
         if (dynamicEquipment == null)
            dynamicEquipment = new System.Collections.ArrayList();
         return dynamicEquipment;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDynamicEquipment(System.Collections.ArrayList newDynamicEquipment)
      {
         RemoveAllDynamicEquipment();
         foreach (DynamicEquipment oDynamicEquipment in newDynamicEquipment)
            AddDynamicEquipment(oDynamicEquipment);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDynamicEquipment(DynamicEquipment newDynamicEquipment)
      {
         if (newDynamicEquipment == null)
            return;
         if (this.dynamicEquipment == null)
            this.dynamicEquipment = new System.Collections.ArrayList();
         if (!this.dynamicEquipment.Contains(newDynamicEquipment))
            this.dynamicEquipment.Add(newDynamicEquipment);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDynamicEquipment(DynamicEquipment oldDynamicEquipment)
      {
         if (oldDynamicEquipment == null)
            return;
         if (this.dynamicEquipment != null)
            if (this.dynamicEquipment.Contains(oldDynamicEquipment))
               this.dynamicEquipment.Remove(oldDynamicEquipment);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDynamicEquipment()
      {
         if (dynamicEquipment != null)
            dynamicEquipment.Clear();
      }
      public System.Collections.ArrayList staticEquipment;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetStaticEquipment()
      {
         if (staticEquipment == null)
            staticEquipment = new System.Collections.ArrayList();
         return staticEquipment;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetStaticEquipment(System.Collections.ArrayList newStaticEquipment)
      {
         RemoveAllStaticEquipment();
         foreach (StaticEquipment oStaticEquipment in newStaticEquipment)
            AddStaticEquipment(oStaticEquipment);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddStaticEquipment(StaticEquipment newStaticEquipment)
      {
         if (newStaticEquipment == null)
            return;
         if (this.staticEquipment == null)
            this.staticEquipment = new System.Collections.ArrayList();
         if (!this.staticEquipment.Contains(newStaticEquipment))
            this.staticEquipment.Add(newStaticEquipment);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveStaticEquipment(StaticEquipment oldStaticEquipment)
      {
         if (oldStaticEquipment == null)
            return;
         if (this.staticEquipment != null)
            if (this.staticEquipment.Contains(oldStaticEquipment))
               this.staticEquipment.Remove(oldStaticEquipment);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllStaticEquipment()
      {
         if (staticEquipment != null)
            staticEquipment.Clear();
      }
      public Appointment[] appointment;
   
   }
}