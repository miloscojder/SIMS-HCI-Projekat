/***********************************************************************
 * Module:  Anamnesis.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.Anamnesis
 ***********************************************************************/
using Model;
using System;
using Service;
using System.Collections.Generic;

namespace Controller
{
   public class AnamnesisController
   {
        public AnamnesisService anamnesisService = new AnamnesisService();
        public void CreateAnamnesis(Anamnesis newAnamnesis)
      {
            anamnesisService.CreateAnamnesis(newAnamnesis);
        }
      
      public void UpdateAnamnesis(Anamnesis anam)
      {
            anamnesisService.UpdateAnamnesis(anam);
      }

        public List<Anamnesis> GetAll()
        {
            return anamnesisService.GetAll();
        }

        public Anamnesis GetAnamnesis(Anamnesis anam)
        {
            return anamnesisService.GetAnamnesis(anam);
        }

    }
}