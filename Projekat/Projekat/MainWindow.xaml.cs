using System;
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
using Controller;
using Model;
using Newtonsoft.Json;
using Projekat.Model;
namespace Projekat
{

    public partial class MainWindow : Window
    {

        UserController userController = new UserController();
        DoctorController doctorController = new DoctorController();
        PatientController patientController = new PatientController();
        //DirectorController directorController = new DirectorController();
        //SecretaryController secretaryController = new SecretaryController();
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void Director_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow director = new DirectorWindow();
            director.Show();
        }

      private void Doctor_Click(object sender, RoutedEventArgs e)
        {
            Doctor d = new Doctor();
            DoctorWindow doctor = new DoctorWindow(d);
            doctor.Show();
        }
      


        private void Request_Click(object sender, RoutedEventArgs e)
        {
            RequestCRUD request = new RequestCRUD();
            request.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            User loggedUser = userController.FindUserByUsernameAndPasswrod(UsernameTextBox.Text, PasswordTextBox.Password);

            if (loggedUser == null)
            {

                MessageBox.Show("Ne postoji nalog!");
            }
            else
            {
                switch (loggedUser.Rool)
                {
                    case RoolType.Doctor:
                        Doctor d = new Doctor();
                        d = doctorController.FindDoctorByUsernameAndPassword(loggedUser.Username, loggedUser.Password);
                        DoctorWindow dw = new DoctorWindow(d);
                        dw.Show();
                        break;
                    case RoolType.Patient:
                        Patient p = new Patient();
                        p = patientController.FindPatientByUsernameAndPassword(loggedUser.Username, loggedUser.Password);
                        PatientMainPage pw = new PatientMainPage(p);
                        pw.Show();
                        break;
                    case RoolType.Secretary:
                        SecretaryWindow sw = new SecretaryWindow();
                        sw.Show();
                        break;
                    case RoolType.Director:
                        DirectorWindow dirw = new DirectorWindow(loggedUser);
                        dirw.Show();
                        break;
                 
                }

            }
            
        }
    }
}
