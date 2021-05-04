using Projekat.Model;
using Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat.Controller
{
    class MedicinesController
    {
        public MedicinesService medicinesService = new MedicinesService();
        public void Save(Medicines newMedicines)
        {
            medicinesService.Save(newMedicines);
        }

        public Medicines GetOne(int id)
        {
            return medicinesService.GetOne(id);
        }

        public List<Medicines> GetAll()
        {

            return medicinesService.GetAll();
        }

        public void UpdateMedicines(Medicines newMedicines)
        {
            medicinesService.UpdateMedicines(newMedicines);

        }

        public void DeleteMedicines(int id)
        {
            medicinesService.DeleteMedicines(id);

        }

        public int GenerateNewId()
        {
            return medicinesService.GenerateNewId();

        }
    }
}
