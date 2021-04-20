using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Model;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for ScheduleAppointmentPatient.xaml
    /// </summary>
    public partial class ScheduleAppointmentPatient : Window
    {

        public enum Priority { DATE, DOCTOR }

        public List<String> Termini { get; set; }
        public string SelektovanTermin { get; set; }
        public List<String> Doktori { get; set; }
        public string SelektovanDoktor { get; set; }
        public Priority priority;

        public ScheduleAppointmentPatient()
        {
            InitializeComponent();
            this.DataContext = this;

            string[] termini = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8);
            Termini = new List<string>(termini);

            string[] doktori = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\doktoriak.txt", Encoding.UTF8);
            Doktori = new List<string>(doktori);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            priority = Priority.DATE;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            priority = Priority.DOCTOR;
        }

        private void SendRequestClick(object sender, RoutedEventArgs e)
        {
            DateTime choosenDate = new DateTime();

            String nesto = (string)Combobox1.SelectedItem;
            string[] preuzeto = nesto.Split(':');

            choosenDate = (DateTime)IzaberiDatum.SelectedDate;
            choosenDate = new DateTime(IzaberiDatum.SelectedDate.Value.Year, IzaberiDatum.SelectedDate.Value.Month, IzaberiDatum.SelectedDate.Value.Day, Convert.ToInt32(preuzeto[0]), Convert.ToInt32(preuzeto[1]), 0);

            string izabraniDoktor = (string)Combobox2.SelectedItem;

            //            Appointment a = new Appointment(choosenDate, izabraniDoktor);

            //  System.Windows.MessageBox.Show(Convert.ToString(choosenDate) + " " + izabraniDoktor)  ;
            //  System.Windows.MessageBox.Show(Convert.ToString(priority));

            AcceptNewAppointmentPatient anap = new AcceptNewAppointmentPatient(/*a,*/ priority, choosenDate, izabraniDoktor);
            anap.Show();
        }
    }
}
