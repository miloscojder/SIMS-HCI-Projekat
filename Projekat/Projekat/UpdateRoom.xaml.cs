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
    /// <summary>
    /// Interaction logic for UpdateRoom.xaml
    /// </summary>
    public partial class UpdateRoom : Window
    {
        private RoomController roomController = new RoomController();
        int id;
        public UpdateRoom()
        {
            InitializeComponent();
            RoomRepository roomRepository = new RoomRepository();
            List<Room> rooms = roomRepository.GetAllRooms();
            dataGridUpdate.ItemsSource = rooms;
        }
        

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            
            string roomname = name.Text;
            int roomfloor = Int32.Parse(floor.Text);
            string roomdetail = detail.Text;
            string type = roomType.Text;

            Room room = new Room(id, roomname, type, roomfloor, roomdetail);
            roomController.UpdateRoom(room);
            id = -1;

            ViewRooms vr = new ViewRooms();
            vr.Show();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow dr = new DirectorWindow();
            dr.Show();
        }
        private void Select_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Room room = (Room)dataGridUpdate.SelectedItems[0];
                id = room.Id;



                name.Text = room.Name;
                floor.Text = room.Floor.ToString();
                detail.Text = room.Detail;
                roomType.Text = room.RoomType;


            }
            catch
            {
                MessageBox.Show("You have to fill in all input boxes!");
            }
        }
    }
}
