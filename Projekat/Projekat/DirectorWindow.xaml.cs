using Model;
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

namespace Projekat
{

    public partial class DirectorWindow : Window
        
    {
        User prenosilac = new User();

        public DirectorWindow(User loggedUser)
        {
            InitializeComponent();
            prenosilac = loggedUser;
        }

        public DirectorWindow()
        {
            InitializeComponent();
        }

        private void CreateRoom_Click(object sender, RoutedEventArgs e)
        {
            CreateRoom cr = new CreateRoom();
            cr.Show();
            Close();
            
        }

        private void CreateEquipment_Click(object sender, RoutedEventArgs e)
        {
            CreateEquipment ce = new CreateEquipment();
            ce.Show();
            
        }

        private void AddNewMedicine_Click(object sender, RoutedEventArgs e)
        {
            CreateMedicine cm = new CreateMedicine();
            cm.Show();
            
        }
        private void ViewMedicines_Click(object sender, RoutedEventArgs e)
        {
            ViewMedicines vm = new ViewMedicines();
            vm.Show();

        }
        private void UpdateMedicines_Click(object sender, RoutedEventArgs e)
        {
            UpdateMedicine um = new UpdateMedicine();
            um.Show();

        }

        private void DeleteMedicines_Click(object sender, RoutedEventArgs e)
        {
            

        }
        private void UpdateRoom_Click(object sender, RoutedEventArgs e)
        {
            UpdateRoom ur = new UpdateRoom();
            ur.Show();
            
        }
        private void ViewRoom_Click(object sender, RoutedEventArgs e)
        {
            ViewRooms vr = new ViewRooms();
            vr.Show();
            
        }
        private void ViewEquipment_Click(object sender, RoutedEventArgs e)
        {
            ViewEquipment ve = new ViewEquipment(1);
            ve.Show();
            
        }
        private void DeleteRoom_Click(object sender, RoutedEventArgs e)
        {
            ViewRooms vr = new ViewRooms();
            vr.Show();
            Close();
        }

        private void ScheduleClassicRenovation_Click(object sender, RoutedEventArgs e)
        {
            ScheduleClassicRenovation scr = new ScheduleClassicRenovation();
            scr.Show();
           
        }

        private void ScheduleAdvanceRenovation_Click(object sender, RoutedEventArgs e)
        {
            AdvanceRenovation ar = new AdvanceRenovation();
            ar.Show();

        }




        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
