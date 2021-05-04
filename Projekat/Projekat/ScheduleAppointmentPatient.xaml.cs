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
        public static int counter = 0;          //ovo treba da bude globalno, da li ovo valja?
        List<DateTime> listaVremenaZakazivanja = new List<DateTime>();
        TimeSpan timeSpan = new TimeSpan(7, 0, 0, 0, 0);

        //globalni brojac

        public ScheduleAppointmentPatient()
        {
            InitializeComponent();
            this.DataContext = this;

            string[] termini = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8);
            Termini = new List<string>(termini);

            string[] doktori = File.ReadAllLines(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doktoriak.txt", Encoding.UTF8);
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


            //atni spam zastita? proveriti ovo malo
            foreach (DateTime datum in listaVremenaZakazivanja)
            {
                if ((DateTime.Now.Date - datum.Date) > timeSpan)    
                {
                    listaVremenaZakazivanja.Remove(datum);
                    counter--;                                                              // ovo cu da ucitam iz fajla nekog posle
                }    
            }        
            
            if(counter >= 10)                             
            {
                MessageBox.Show("Blokirani ste zbog spamovanja, javite nam se za vis enformacija");
                //window close        
            } 
            else 
            {
                counter++;
                listaVremenaZakazivanja.Add(DateTime.Now);

                DateTime choosenDate = new DateTime();

                String nesto = (string)Combobox1.SelectedItem;
                string[] preuzeto = nesto.Split(':');

                choosenDate = (DateTime)IzaberiDatum.SelectedDate;
                choosenDate = new DateTime(IzaberiDatum.SelectedDate.Value.Year, IzaberiDatum.SelectedDate.Value.Month, IzaberiDatum.SelectedDate.Value.Day, Convert.ToInt32(preuzeto[0]), Convert.ToInt32(preuzeto[1]), 0);

                string izabraniDoktor = (string)Combobox2.SelectedItem;

                AcceptNewAppointmentPatient anap = new AcceptNewAppointmentPatient(/*a,*/ priority, choosenDate, izabraniDoktor);
                anap.Show();
             }
        } 
            /*    else    // ovo mi iskreno mozda i ne treba keke             1.3 sve pod ovim elsom ce se verovatno brisati
                {
                    if(counter >= 10 )
                    {
                        MessageBox.Show("Lik je spamer");
                    } 
                    else
                    {
                        counter++;
                        listaVremenaZakazivanja.Add(DateTime.Now);

                        DateTime choosenDate = new DateTime();

                        String nesto = (string)Combobox1.SelectedItem;
                        string[] preuzeto = nesto.Split(':');

                        choosenDate = (DateTime)IzaberiDatum.SelectedDate;
                        choosenDate = new DateTime(IzaberiDatum.SelectedDate.Value.Year, IzaberiDatum.SelectedDate.Value.Month, IzaberiDatum.SelectedDate.Value.Day, Convert.ToInt32(preuzeto[0]), Convert.ToInt32(preuzeto[1]), 0);

                        string izabraniDoktor = (string)Combobox2.SelectedItem;

                        AcceptNewAppointmentPatient anap = new AcceptNewAppointmentPatient(/*a,*/ /*priority, choosenDate, izabraniDoktor);
                        anap.Show();
                    }
                }
            }

  */    





            //OVO MORAS DA URADIS                  //dodaj fajlove sa doktorom i njihovim zauzetim terminima //malo cimanje za napravit al okej
            /*
              Appointment<List> doctorAppointments = ucitati iz fajla sve doktorove appoitnemtne
              foreach (app in doctorAppointements) {
                  if(app.timeStart!=choosenDate) {
                      Appointment a = new Appointment(choosenDate,izabraniDoktor,freeSala)
                      random id
               
            
                        AppointmentsPage ap = new AppointemntsPage(a);
                        ap.Show();
                    }
              }

              else {
                 AcceptNewAppointmentPatient anap = new AcceptNewAppointmentPatient(/*a,priority, choosenDate, izabraniDoktor);
                 anap.Show();
            */
       
    
    }
}
