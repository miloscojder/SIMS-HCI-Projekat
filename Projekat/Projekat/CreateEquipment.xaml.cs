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
    /// Interaction logic for CreateEquipment.xaml
    /// </summary>
    public partial class CreateEquipment : Window
    {
        private StaticEquipmentController staticEquipmentController = new StaticEquipmentController();
        public CreateEquipment()
        {
            InitializeComponent();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            int ind = staticEquipmentController.GenerateNewId();
            string eqname = name.Text;
            int eqquantity = Int32.Parse(quantity.Text);
            Enum.TryParse(type.Text, out EquipmentType myStatus);
            StaticEquipment sequipment = new StaticEquipment(ind, eqname, myStatus, eqquantity);
            staticEquipmentController.Save(sequipment);

            ViewEquipment ve = new ViewEquipment();
            ve.Show();
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow de = new DirectorWindow();
            de.Show();
            Close();
        }
    }
}
