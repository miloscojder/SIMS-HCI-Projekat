using Model;
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
    /// Interaction logic for DoctorAppointment.xaml
    /// </summary>
    public partial class DoctorAppointment : Window
    {
        public DoctorAppointment()
        {
            InitializeComponent();
            AppointmentFileStorage storage = new AppointmentFileStorage();
            List<Appointment> appointments = storage.GetAll();

            lvDataBinding.ItemsSource = appointments;
        }

        private void Button_Click_Zakazi(object sender, RoutedEventArgs e)
        {
            Appointment selected = (Appointment)lvDataBinding.SelectedItems[0];
            Appointment nov = new Appointment();
            Doctor d = new Doctor();
            d.AddAppointment(nov);
        }

        private void Button_Click_Otkazi(object sender, RoutedEventArgs e)
        {
            Appointment selected = (Appointment)lvDataBinding.SelectedItems[0];
            Appointment nov = new Appointment();
            Doctor d = new Doctor();
            d.RemoveAppointment(nov);
        }
        public System.Collections.ArrayList app;
        private void Button_Click_Izmeni(object sender, RoutedEventArgs e)
        {

            Appointment selected = (Appointment)lvDataBinding.SelectedItems[0];
            //Appointment nov = new ArrayList;
            Doctor d = new Doctor();
            d.SetAppointment(app);

        }

        private void Button_Click_Pregled(object sender, RoutedEventArgs e)
        {
            Appointment selected = (Appointment)lvDataBinding.SelectedItems[0];
            Appointment nov = new Appointment();
            Doctor d = new Doctor();
            Room r = new Room();
            nov.GetAllAppointments();
        }

        private void lvDataBinding_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
