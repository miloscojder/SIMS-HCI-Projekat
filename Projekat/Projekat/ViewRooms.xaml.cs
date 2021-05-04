using Model;
using Repository;
using Controller;
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

    public partial class ViewRooms : Window
    {
        private RoomController roomController = new RoomController();
        private StaticEquipmentController staticEquipmentController = new StaticEquipmentController();
        private DynamicEquipmentController dynamicEquipmentController = new DynamicEquipmentController();

        public List<Room> room { get; set; }
        public List<StaticEquipment> StaticEquipment { get; set; }
        public ViewRooms()
        {
            InitializeComponent();
            RoomRepository roomRepository = new RoomRepository();
            List<Room> rooms = roomRepository.GetAllRooms();
            dataGridSobe.ItemsSource = rooms;


        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow director = new DirectorWindow();
            director.Show();
            Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Room room = (Room)dataGridSobe.SelectedItems[0];
                roomController.DeleteRoom(room.Id);
            }
            catch
            {
                MessageBox.Show("You have to select a room to delete!");
            }
        }
        private void ViewRoomEquipment_Click(object sender, RoutedEventArgs e)
        {
           // StaticEquipment staticEquipment = (StaticEquipment)dataGridSobe.SelectedItems[0];
           // staticEquipmentController.GetOne(staticEquipment.Id);

            ViewEquipment equipment = new ViewEquipment();
            equipment.Show();
            Close();
        }
    }
}
