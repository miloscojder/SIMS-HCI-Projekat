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
    /// Interaction logic for Rooms.xaml
    /// </summary>
    public partial class Rooms : Window
    {
        public Rooms()
        {
            InitializeComponent();
        }
        public void AddR(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Room is succesfully added!");

        }
        public void CancelR(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have canceled adding room.");
        }

        private void ViewR(object sender, RoutedEventArgs e)
        {
            ViewRooms viewr = new ViewRooms();
            viewr.Show();
        }
    }
}
