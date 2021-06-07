using Controller;
using Model;
using Projekat.Controller;
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
    /// Interaction logic for AdvanceRenovation.xaml
    /// </summary>
    public partial class AdvanceRenovation : Window
    {
        private readonly RoomController roomController = new RoomController();
        private readonly RenovationController renovationController = new RenovationController();
        private List<Room> rooms = new List<Room>();
        public AdvanceRenovation()
        {
            InitializeComponent();
            rooms = roomController.GetAllRooms();
            foreach (Room room in rooms)
            {
                roomA.Items.Add(room.Name);
                roomB.Items.Add(room.Name);
                dettachRoom.Items.Add(room.Name);
            }
        }
        private void AcceptRenovation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)attach.IsChecked)
                {
                    Attach(roomA.Text, roomB.Text);
                    MessageBox.Show("Uspešno ste spojili sobe!");
                }
                else
                {
                    Dettach(dettachRoom.Text);
                    MessageBox.Show("Uspešno ste razdvojili sobe!");
                }
                
            }
            catch
            {
                MessageBox.Show("Molim Vas da popunite sva polja");
            }
        }

            private void Attach(string roomAName, string roomBName)
            {
                Room roomA = roomController.GetByName(roomAName);
                Room roomB = roomController.GetByName(roomBName);

                DateTime renovationDateTime = SelectedDate();

                renovationController.AttachRooms(roomA.Id, roomB.Id, renovationDateTime, Double.Parse(duration.Text));
            }

            private void Dettach(string roomName)
            {
                Room room = roomController.GetByName(roomName);
                DateTime renovationDateTime = SelectedDate();

                renovationController.DettachRooms(room.Id, renovationDateTime, Double.Parse(duration.Text));
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
    

