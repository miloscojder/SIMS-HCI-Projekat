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
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNewRoom(object sender, RoutedEventArgs e)
        {
            Rooms room = new Rooms();
            room.Show();
        }

        private void AddPacients(object sender, RoutedEventArgs e)
        {
            Patients patient = new Patients();
            patient.Show();
        }

        private void AddAppointment(object sender, RoutedEventArgs e)
        {
            Appointments app = new Appointments();
            app.Show();
        }
        private void AddAppD(object sender, RoutedEventArgs e)
        {
            DoctorAppointment app = new DoctorAppointment();
            app.Show();
        }

        private void VacationReq(object sender, RoutedEventArgs e)
        {
            VacationRequests vacation = new VacationRequests();
            vacation.Show();
        }
    }
}
