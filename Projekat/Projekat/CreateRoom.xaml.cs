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
using Model;
using Controller;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for CreateRoom.xaml
    /// </summary>
    public partial class CreateRoom : Window
    {
        private RoomController roomController = new RoomController();
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            int ind = roomController.GenerateNewId();
            string roomname = name.Text;
            int roomfloor = Int32.Parse(floor.Text);
            string roomdetail = detail.Text;
            string type = roomType.Text;
            Room room = new Room(ind, roomname, type, roomfloor, roomdetail);
            roomController.Save(room);

            ViewRooms vr = new ViewRooms();
            vr.Show();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow dr = new DirectorWindow();
            dr.Show();
        }
    }
}
