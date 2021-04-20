
using Model;
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

namespace Projekat
{
   
    public partial class CreateAnamnesis : Window
    {
        public CreateAnamnesis()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            //prikupljam polja iz forme
           
            String ida = Id.Text;
            String anam = (String)Anamnesis.Text;
            
            String Idnovi = Convert.ToString(ida)+1;
            int sign = 0;

           
            String red =Idnovi.ToString()+ "," + ida + "," +  anam ;



            //AnamnesisFileStorage fajl = new AnamnesisFileStorage(@"C:\Users\krist\Desktop\anamnesis.txt");
            // fajl.Save(red,true);

             MessageBox.Show("Anamnesis created!");
            this.Close();
        }
    }
}
