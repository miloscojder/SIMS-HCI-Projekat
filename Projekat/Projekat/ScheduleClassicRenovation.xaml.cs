using Controller;
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
        private readonly RoomController roomController = new RoomController();
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
            try
            {
                Room room = (Room)classicRenovationDataGrid.SelectedItems[0];
                DateTime renovationDate = SelectedDate();
                //roomController.Renovation(room.Id, renovationDate, Double.Parse(duration.Text));
            }
            catch
            {
                MessageBox.Show("Ponovo zauzmite datum");
            }
        }
        private DateTime SelectedDate()
        {
            DateTime pickedDate = date.SelectedDate.Value;
            int hours = Int32.Parse(startTime.Text.Split(':')[0]);
            int minutes = Int32.Parse(startTime.Text.Split(':')[1]);
            DateTime renovationDateTime = new DateTime(pickedDate.Year, pickedDate.Month, pickedDate.Day, hours, minutes, 00);
            return renovationDateTime;
        }

    }
}
