using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Projekat.Interfaces
{
    public interface IEquipment<T>    
        where T: class
    { 
        void SaveEquipment(T instance);
        T GetOneEquipment(int id);
        List<T> GetAllEquipment();

        Boolean UpdateEquipment(T instance);
        Boolean DeleteEquipment(int id);
        
    }
}
