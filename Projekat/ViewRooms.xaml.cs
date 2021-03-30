﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for ViewRooms.xaml
    /// </summary>
    public partial class ViewRooms : Window
    {
        public ViewRooms()
        {
            InitializeComponent();
            RoomFileStorage storage = new RoomFileStorage();
            List<Room> rooms = storage.GetAllRooms();

            lvDataBinding.ItemsSource = rooms;
        }
    }
}
