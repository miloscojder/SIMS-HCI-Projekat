/***********************************************************************
 * Module:  Anamnesis.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.Anamnesis
 ***********************************************************************/

using System;

namespace Controller
{
   public class AnamnesisController
   {
      public AnamnesisController CreateAnamnesis(AnamnesisController newAnamnesis)
      {
         // TODO: implement
         return null;
      }
      
      public AnamnesisController UpdateAnamnesis()
      {
         // TODO: implement
         return null;
      }
   
      public System.Collections.ArrayList anamnesisService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAnamnesisService()
      {
         if (anamnesisService == null)
            anamnesisService = new System.Collections.ArrayList();
         return anamnesisService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAnamnesisService(System.Collections.ArrayList newAnamnesisService)
      {
         RemoveAllAnamnesisService();
         foreach (Service.AnamnesisService oAnamnesisService in newAnamnesisService)
            AddAnamnesisService(oAnamnesisService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAnamnesisService(Service.AnamnesisService newAnamnesisService)
      {
         if (newAnamnesisService == null)
            return;
         if (this.anamnesisService == null)
            this.anamnesisService = new System.Collections.ArrayList();
         if (!this.anamnesisService.Contains(newAnamnesisService))
            this.anamnesisService.Add(newAnamnesisService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAnamnesisService(Service.AnamnesisService oldAnamnesisService)
      {
         if (oldAnamnesisService == null)
            return;
         if (this.anamnesisService != null)
            if (this.anamnesisService.Contains(oldAnamnesisService))
               this.anamnesisService.Remove(oldAnamnesisService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAnamnesisService()
      {
         if (anamnesisService != null)
            anamnesisService.Clear();
      }
   
   }
}