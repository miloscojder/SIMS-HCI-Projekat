using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    class OrderForDynamicEquipmentController
    {
        public Service.OrderForDynamicEquipmentService orderForDynamicEquipmentService;


        public void Create(int id)
        {
            // TODO: implement
        }

        public Model.OrderForDynamicEquipment Reed(int id)
        {
            // TODO: implement
            return null;
        }

        public void Update(int id, int newName, int newQuantity)
        {
            // TODO: implement
        }

        public Boolean Delete(int id)
        {
            // TODO: implement
            return false;
        }

        public List<OrderForDynamicEquipment> FilterByName(String name)
        {
            // TODO: implement
            return null;
        }

        public List<OrderForDynamicEquipment> FilterByStatus(Model.OrderType status)
        {
            // TODO: implement
            return null;
        }

        public List<OrderForDynamicEquipment> SortByDateOfCreation()
        {
            // TODO: implement
            return null;
        }

        public List<OrderForDynamicEquipment> GetAll()
        {
            // TODO: implement
            return null;
        }

  
    }
}
