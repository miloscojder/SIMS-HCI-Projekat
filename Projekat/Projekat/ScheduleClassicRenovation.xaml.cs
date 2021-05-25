using Model;
using Repository;
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

    public partial class ScheduleClassicRenovation : Window
    {
        public ScheduleClassicRenovation()
        {
            InitializeComponent();
            RoomRepository roomRepository = new RoomRepository();
            List<Room> rooms = roomRepository.GetAllRooms();
            classicRenovationDataGrid.ItemsSource = rooms;
        }

        private void ViewClassicRenovation_Click(object sender, RoutedEventArgs e)
        {
            ViewClassicRenovation vcr = new ViewClassicRenovation();
            vcr.Show();
            Close();
        }

        private void ScheduleRenovation_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
