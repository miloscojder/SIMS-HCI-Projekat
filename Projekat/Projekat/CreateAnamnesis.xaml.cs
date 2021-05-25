
using Model;
using System;
using System.Windows;
using Controller;

namespace Projekat
{
   
    public partial class CreateAnamnesis : Window
    {
        public AnamnesisController anamnesisController = new AnamnesisController();
        public PatientController patientController = new PatientController();
        Anamnesis anama = new Anamnesis();
        public CreateAnamnesis(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;
            FirstName.Text = p.firstName;
            LastName.Text = p.lastName;
        }

        public void Create(object sender, RoutedEventArgs e)
        {
            //Anamnesis an = new Anamnesis();
            Patient p = new Patient();
            int ida = anamnesisController.GenerateNewId();
            String anam = Anamnesis.Text;
            p.firstName = FirstName.Text;
            p.lastName = LastName.Text;
     
            Anamnesis a = new Anamnesis(ida, anam, p);
            anamnesisController.CreateAnamnesis(a);

            MessageBox.Show("Anamnesis created!");
            this.Close();
            
            Anamnesiss ap = new Anamnesiss();
            ap.Show();
            Close();
        }

       
    }
}
