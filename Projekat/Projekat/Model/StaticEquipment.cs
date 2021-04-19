using System;

namespace Model
{
   public class StaticEquipment
   {
      public int Id;
      public String Name;
      public EquipmentType Type;
      public int Quantity;
      
      public System.Collections.ArrayList order;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetOrder()
      {
         if (order == null)
            order = new System.Collections.ArrayList();
         return order;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetOrder(System.Collections.ArrayList newOrder)
      {
         RemoveAllOrder();
         foreach (Order oOrder in newOrder)
            AddOrder(oOrder);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddOrder(Order newOrder)
      {
         if (newOrder == null)
            return;
         if (this.order == null)
            this.order = new System.Collections.ArrayList();
         if (!this.order.Contains(newOrder))
            this.order.Add(newOrder);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveOrder(Order oldOrder)
      {
         if (oldOrder == null)
            return;
         if (this.order != null)
            if (this.order.Contains(oldOrder))
               this.order.Remove(oldOrder);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllOrder()
      {
         if (order != null)
            order.Clear();
      }
   
   }
}