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
    /// Interaction logic for Appointments.xaml
    /// </summary>
    public partial class Appointments : Window

        {
            public Appointments()
            {
                InitializeComponent();

                AppointmentFileStorage storage = new AppointmentFileStorage();
                List<Appointment> termini = storage.GetAll();

                lvUsers.ItemsSource = termini;

                //lvUsers.View = View.Details;  ???

            }

            private void AddButton_Click(object sender, RoutedEventArgs e)
            {
                //treba da se doradi da se podaci ucitaju sa text boxova

                Appointment novi = new Appointment();
                Doctor d = new Doctor();
                Room r = new Room();
                DateTime date1 = new DateTime(2008, 8, 29, 19, 27, 15);
                DateTime date2 = new DateTime(2008, 8, 29, 19, 27, 15);
                novi.ScedulePatient(date1, date2, d, r, "1");

                //treba da se uformatira da broj kolona bude isti ovde i u ListView-u
                lvUsers.Items.Add(novi);
            }

            private void CancButton_Click_1(object sender, RoutedEventArgs e)
            {



                if (lvUsers.SelectedItems.Count > 0)
                {
                    foreach (Appointment selected in lvUsers.SelectedItems)
                    {

                        //selected.Cancel();
                    }
                }
            }

            private void RescButton_Click_2(object sender, RoutedEventArgs e)
            {
                //treba da se doradi da se podaci ucitaju sa text boxova

                Doctor d = new Doctor();
                Room r = new Room();
                DateTime date1 = new DateTime(2008, 8, 29, 19, 27, 15);
                DateTime date2 = new DateTime(2008, 8, 29, 19, 27, 15);

                if (lvUsers.SelectedItems.Count > 0)
                {
                    foreach (Appointment selected in lvUsers.SelectedItems)
                    {
                        //treba da se uformatira da broj kolona bude isti ovde i u ListView-u
                        selected.ReschedulePatient(date1, date2, d, r, "1");
                    }
                }
            }
        }
    }

