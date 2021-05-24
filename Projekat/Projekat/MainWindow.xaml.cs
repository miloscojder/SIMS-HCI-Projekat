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
using Model;
using Newtonsoft.Json;
using Projekat.Model;
using Controller;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        UserController userController = new UserController();
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
            DoctorWindow doctor = new DoctorWindow();
            doctor.Show();
        }



        private void Request_Click(object sender, RoutedEventArgs e)
        {
            RequestCRUD request = new RequestCRUD();
            request.Show();
        }

        private void PatientButton_Click(object sender, RoutedEventArgs e)
        {
            PatientMainPage pmp = new PatientMainPage(null);
            pmp.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {              
            User loggedUser = userController.FindUserByUsernameAndPasswrod(UsernameTextBox.Text, PasswordTextBox.Text);

            switch (loggedUser.Rool)
            {
                case RoolType.Doctor:
                    DoctorWindow dw = new DoctorWindow();
                    dw.Show();
                    break;
                case RoolType.Patient:
                    PatientMainPage pw = new PatientMainPage(loggedUser);
                    pw.Show();
                    break;
                case RoolType.Secretary:
                    SecretaryWindow sw = new SecretaryWindow();
                    sw.Show();
                    break;
                case RoolType.Director:
                    DirectorWindow dirw = new DirectorWindow();
                    dirw.Show();
                    break;
                default:
                    MessageBox.Show("Nemate nalog!");
                    break;
            }

            
        }
    }
}
