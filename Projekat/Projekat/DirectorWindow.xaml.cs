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
    /// Interaction logic for DirectorWindow.xaml
    /// </summary>
    public partial class DirectorWindow : Window
    {
        public DirectorWindow()
        {
            InitializeComponent();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            CreateRoom cr = new CreateRoom();
            cr.Show();
        }

        private void CreateE_Click(object sender, RoutedEventArgs e)
        {
            CreateEquipment ce = new CreateEquipment();
            ce.Show();
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            UpdateRoom ur = new UpdateRoom();
            ur.Show();
        }
        private void View_Click(object sender, RoutedEventArgs e)
        {
            ViewRooms vr = new ViewRooms();
            vr.Show();
        }
        private void ViewE_Click(object sender, RoutedEventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ViewRooms vr = new ViewRooms();
            vr.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
