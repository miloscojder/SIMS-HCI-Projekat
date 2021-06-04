using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Controller;
using Model;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for CreateDynamicEquipment.xaml
    /// </summary>
    public partial class CreateDynamicEquipment : Window
    {
        private DynamicEquipmentController dynamicEquipmentController = new DynamicEquipmentController();
        public CreateDynamicEquipment()
        {
            InitializeComponent();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            int ind = dynamicEquipmentController.GenerateNewId();
            string eqname = name.Text;
            int eqquantity = Int32.Parse(quantity.Text);
            Enum.TryParse(type.Text, out EquipmentType myStatus);
            DynamicEquipment dequipment = new DynamicEquipment(ind, eqname, myStatus, eqquantity);
            dynamicEquipmentController.Save(dequipment);

            
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow de = new DirectorWindow();
            de.Show();
            Close();
        }
    }
}
