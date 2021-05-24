using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class OrderForDynamicEquipment
    {
    
        public String Name { get; set; }
        public int Quantity { get; set; }
        public int Id { get; set; }
        public OrderType Status { get; set; }
        public DateTime DateOfCreate { get; set; }
        public String Answer { get; set; }
        public DateTime DateOfDelivery { get; set; }

        public OrderForDynamicEquipment(string name, int quantity, int id, OrderType status, DateTime dateOfCreate, string answer, DateTime dateOfDelivery)
        {
            Name = name;
            Quantity = quantity;
            Id = id;
            Status = status;
            DateOfCreate = dateOfCreate;
            Answer = answer;
            DateOfDelivery = dateOfDelivery;
        }
    }
}
