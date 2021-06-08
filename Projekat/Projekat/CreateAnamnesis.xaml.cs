
using Model;
using System;
using System.Windows;
using Controller;

using System.Windows.Media;


namespace Projekat
{
   
    public partial class CreateAnamnesis : Window
    {
        public AnamnesisController anamnesisController = new AnamnesisController();
        public PatientController patientController = new PatientController();
        public Anamnesis Anamnesis = new Anamnesis();
        
        
        public CreateAnamnesis(Patient p)
        {
            this.DataContext = this;    
            InitializeComponent();
            FirstName.Text = p.firstName;
            LastName.Text = p.lastName;
            
        }

        public void Create(object sender, RoutedEventArgs e)
        {
     
            Patient p = new Patient();
            int ida = anamnesisController.GenerateNewId();
            String anam = Anamneza.Text;
            p.firstName = FirstName.Text;
            p.lastName = LastName.Text;

            if (Anamneza.Text == null || Anamneza.Text=="" || Anamneza.Text==" ")
            {
                Anamneza.BorderBrush = new SolidColorBrush(Color.FromRgb(250, 0, 0) );
                er.Text = "Anamnesis is required";
            }
            else
            {
                Anamnesis a = new Anamnesis(ida, anam, p);
                anamnesisController.CreateAnamnesis(a);

                MessageBox.Show("Anamnesis created!");


                Anamnesiss ap = new Anamnesiss();
                ap.Show();
                Close();
            }
                
            
        }



        private void Back(object sender, RoutedEventArgs e)
        {
            Anamnesiss ap = new Anamnesiss();
            ap.Show();
            Close();
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow ap = new MainWindow();
            ap.Show();
            Close();
        }
    }
}
