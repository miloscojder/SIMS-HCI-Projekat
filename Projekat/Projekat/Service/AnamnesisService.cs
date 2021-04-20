/***********************************************************************
 * Module:  Anamnesis.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.Anamnesis
 ***********************************************************************/

using System;
using Model;
using Repository;
using System.Collections.Generic;

namespace Service
{
   public class AnamnesisService
   {
        public AnamnesisRepository anamnesisRepository = new AnamnesisRepository();
        public void CreateAnamnesis(Anamnesis newAnamnesis)
      {
            anamnesisRepository.CreateAnamnesis(newAnamnesis);
        }
      
      public void UpdateAnamnesis(Anamnesis anam)
      {
            anamnesisRepository.UpdateAnamnesis(anam);
        }
        public List<Anamnesis> GetAll()
        {
            return anamnesisRepository.GetAll();
        }

        public Anamnesis GetAnamnesis(Anamnesis newAnamnesis)
        {
            return anamnesisRepository.GetAnamnesis(newAnamnesis);
        }




    }
}