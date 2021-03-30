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
    /// Interaction logic for Patients.xaml
    /// </summary>
    public partial class Patients : Window
    {
        public Patients()
        {
            InitializeComponent();
        }
        public void AddP(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Patient is succesfully added!");

        }
        public void CancelP(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have canceled adding patient.");
        }
        private void ViewAllP(object sender, RoutedEventArgs e)
        {
            ViewPatients viewp = new ViewPatients();
            viewp.Show();
        }
    }
}
