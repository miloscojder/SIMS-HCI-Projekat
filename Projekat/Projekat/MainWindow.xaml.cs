﻿using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Model;
using Newtonsoft.Json;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Director_Click(object sender, RoutedEventArgs e)
<<<<<<< HEAD
        {
           // DirectorWindow director = new DirectorWindow();
            //director.Show();
        }

        private void Doctor_Click(object sender, RoutedEventArgs e)
        {
            //DoctorWindow doctor = new DoctorWindow();
            //doctor.Show();
        }

        private void Request_Click(object sender, RoutedEventArgs e)
        {
            RequestCRUD request = new RequestCRUD();
            request.Show();
=======
            {
                DirectorWindow director = new DirectorWindow();
                director.Show();
            }

        private void Doctor_Click(object sender, RoutedEventArgs e)
        {
            DoctorWindow doctor = new DoctorWindow();
            doctor.Show();
>>>>>>> bd3334dc1a17fd49b6ad94de7bd9174783e50a8c
        }

    }
}