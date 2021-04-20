﻿using System;
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
    /// Interaction logic for CreateEquipment.xaml
    /// </summary>
    public partial class CreateEquipment : Window
    {
        public CreateEquipment()
        {
            InitializeComponent();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow de = new DirectorWindow();
            de.Show();
        }
    }
}
