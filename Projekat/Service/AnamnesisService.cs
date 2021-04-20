/***********************************************************************
 * Module:  Anamnesis.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.Anamnesis
 ***********************************************************************/

using System;

namespace Service
{
   public class AnamnesisService
   {
      public AnamnesisService CreateAnamnesis(AnamnesisService newAnamnesis)
      {
         // TODO: implement
         return null;
      }
      
      public AnamnesisService UpdateAnamnesis()
      {
         // TODO: implement
         return null;
      }
   
      public System.Collections.ArrayList anamnesisRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAnamnesisRepository()
      {
         if (anamnesisRepository == null)
            anamnesisRepository = new System.Collections.ArrayList();
         return anamnesisRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAnamnesisRepository(System.Collections.ArrayList newAnamnesisRepository)
      {
         RemoveAllAnamnesisRepository();
         foreach (Repository.AnamnesisRepository oAnamnesisRepository in newAnamnesisRepository)
            AddAnamnesisRepository(oAnamnesisRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAnamnesisRepository(Repository.AnamnesisRepository newAnamnesisRepository)
      {
         if (newAnamnesisRepository == null)
            return;
         if (this.anamnesisRepository == null)
            this.anamnesisRepository = new System.Collections.ArrayList();
         if (!this.anamnesisRepository.Contains(newAnamnesisRepository))
            this.anamnesisRepository.Add(newAnamnesisRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAnamnesisRepository(Repository.AnamnesisRepository oldAnamnesisRepository)
      {
         if (oldAnamnesisRepository == null)
            return;
         if (this.anamnesisRepository != null)
            if (this.anamnesisRepository.Contains(oldAnamnesisRepository))
               this.anamnesisRepository.Remove(oldAnamnesisRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAnamnesisRepository()
      {
         if (anamnesisRepository != null)
            anamnesisRepository.Clear();
      }
   
   }
}