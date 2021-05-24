using Projekat.Repository;
using System;
using System.Collections.Generic;
using System.Text;

using Repository;
using System;
using System.Collections.Generic;
using Projekat.Model;

namespace Service
{
    class MedicinesService


    {
        public MedicinesRepository medicinesRepository = new MedicinesRepository();
        public void Save(Medicines newMedicines)
        {
            medicinesRepository.Save(newMedicines);
        }

        public Medicines GetOne(int id)
        {
            return medicinesRepository.GetOne(id);
        }

        public List<Medicines> GetAll()
        {

            return medicinesRepository.GetAll();
        }

        public void UpdateMedicines(Medicines newMedicines)
        {
           medicinesRepository.UpdateMedicines(newMedicines);
            
        }

        public void DeleteMedicines(int id)
        {
            medicinesRepository.DeleteMedicines(id);
            
        }

        public int GenerateNewId()
        {
            return medicinesRepository.GenerateNewId();

        }
    }
}
