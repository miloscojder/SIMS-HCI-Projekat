using Projekat.Model;
using Projekat.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat.Service
{
    class MovingStaticEquipmentService
    {
        public MovingStaticEquipmentRepository staticEquipmentRepository = new MovingStaticEquipmentRepository();
        private List<MovingStaticEquipment> staticEquipments = new List<MovingStaticEquipment>();

        public void Save(MovingStaticEquipment newEquipment)
        {
            staticEquipmentRepository.Save(newEquipment);
        }

        public List<MovingStaticEquipment> GetAll()
        {

            return staticEquipmentRepository.GetAll();
        }

        public void DeleteEquipment(int id)
        {

             staticEquipmentRepository.DeleteEquipment(id);
        }
        public int GenerateNewId()
        {
            return staticEquipmentRepository.GenerateNewId();
        }
    }
}
