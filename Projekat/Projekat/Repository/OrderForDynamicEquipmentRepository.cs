using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
    class OrderForDynamicEquipmentRepository
    {

        public String FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\OrdersForDynamicEquipment.json";

        public void Create(int id)
        {
            // TODO: implement
        }

        public OrderForDynamicEquipment Reed(int id)
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
