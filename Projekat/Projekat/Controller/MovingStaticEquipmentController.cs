using Projekat.Model;
using Projekat.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat.Controller
{
    class MovingStaticEquipmentController
    {
        public MovingStaticEquipmentService staticEquipmentService = new MovingStaticEquipmentService();
        private List<MovingStaticEquipment> staticEquipments = new List<MovingStaticEquipment>();

        public void Save(MovingStaticEquipment newEquipment)
        {
            staticEquipmentService.Save(newEquipment);
        }

        public List<MovingStaticEquipment> GetAll()
        {
            // TODO: implement
            return staticEquipmentService.GetAll();
        }

        public Boolean DeleteEquipment(int id)
        {
            // TODO: implement
            return staticEquipmentService.DeleteEquipment(id);
        }

        public int GenerateNewId()
        {
            return staticEquipmentService.GenerateNewId();
        }
    }
}
