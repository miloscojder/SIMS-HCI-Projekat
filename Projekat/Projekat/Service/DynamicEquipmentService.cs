
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Service
{
   public class DynamicEquipmentService
   {
        public DynamicEquipmentRepository dynamicEquipmentRepository = new DynamicEquipmentRepository();
        private List<DynamicEquipment> dynamicEquipments = new List<DynamicEquipment>();
        private readonly string _spisakDinamickeOpreme = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\dynamicTransfer.txt";


        public void MoveDynamicEquipment(DynamicEquipment dynamicEquipment)
        {
            dynamicEquipmentRepository.MoveDynamicEquipment(dynamicEquipment);
            ExtractEquipment(dynamicEquipment);
        }

        public void ExtractEquipment(DynamicEquipment dynamicEquipment)
        {
            //nova fja koja se poziva u moveEq
            string lines = "Extracted dynamic equipment: " + Convert.ToString(dynamicEquipment.Quantity) + " " + dynamicEquipment.Name + "\n";
            File.AppendAllText(_spisakDinamickeOpreme, lines);
        }


        public void Save(DynamicEquipment newEquipment)
      {
            
            dynamicEquipmentRepository.Save(newEquipment);
            
      }
      
      public List<DynamicEquipment> GetAll()
      {
         
         return dynamicEquipmentRepository.GetAll();
      }
      
      public Boolean UpdateEquipment(DynamicEquipment dynamicEquipment)
      {
         
         dynamicEquipmentRepository.UpdateEquipment(dynamicEquipment);
         return true;
      }
      
      public Boolean DeleteEquipment(int id)
      {
            dynamicEquipmentRepository.DeleteEquipment(id);
            return true;
        }
        public int GenerateNewId()
        {
            return dynamicEquipmentRepository.GenerateNewId();
        }


    }
}