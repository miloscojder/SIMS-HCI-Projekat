
using Model;
using System;
using System.Windows;
using Controller;

namespace Projekat
{
   
    public partial class CreateAnamnesis : Window
    {
        public AnamnesisController anamnesisController = new AnamnesisController();
        public CreateAnamnesis()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            String ida = Id.Text;
            String anam = Anamnesis.Text;
            //Patient p;
           // p.Id = Pid.Text;
     
            Anamnesis a = new Anamnesis(ida, anam);
            anamnesisController.CreateAnamnesis(a);

            MessageBox.Show("Anamnesis created!");
            this.Close();
            
            Anamnesiss ap = new Anamnesiss();
            ap.Show();
        }
    }
}
