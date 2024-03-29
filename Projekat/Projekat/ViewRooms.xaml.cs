﻿using Model;
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
using Projekat.Model;
using Projekat.Controller;

namespace Projekat
{

    public partial class ViewRooms : Window
    {
        private RoomController roomController = new RoomController();
        private StaticEquipmentController staticEquipmentController = new StaticEquipmentController();
        private DynamicEquipmentController dynamicEquipmentController = new DynamicEquipmentController();
        private RenovationController renovationController = new RenovationController();

        public List<Room> room { get; set; }
        public List<StaticEquipment> StaticEquipment { get; set; }
        public ViewRooms()
        {
            InitializeComponent();
            RenovationTime();
            RoomRepository roomRepository = new RoomRepository();
            List<Room> rooms = roomRepository.GetAllRooms();
            dataGridSobe.ItemsSource = rooms;


        }

        private void RenovationTime()
        {
            List<RenovationAppointment> renovations = renovationController.GetAllRenovation();
            foreach (RenovationAppointment renovation in renovations.ToArray())
            {
                if (renovation.StartTime.Ticks <= DateTime.Now.Ticks)
                {
                    if (renovation.Type == 0)
                    {
                        roomController.AttachRooms(renovation.RoomId, renovation.RoomBId);
                        renovationController.DeleteRenovation(renovation.id);
                    }
                    else
                    {
                        roomController.DettachRooms(renovation.RoomId);
                        renovationController.DeleteRenovation(renovation.id);
                    }
                }

            }
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
            Room room = (Room)dataGridSobe.SelectedItems[0];
            

            ViewEquipment equipment = new ViewEquipment(room.Id);
            equipment.Show();
           
        }

    }
}
