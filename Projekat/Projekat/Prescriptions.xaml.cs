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

    public partial class Prescriptions : Window
    {
        public List<Prescription> prescriptions
        {
            get;
            set;
        }
        public Prescriptions()
        {
            InitializeComponent();
            this.DataContext = this;

            prescriptions = new List<Prescription>();
            //PrescriptionFileStorage fajl = new PrescriptionFileStorage(@"C:\Users\krist\Desktop\prescriptions.txt");
            //prescriptions = fajl.GetAll();
        }

      

        private void Prescribe(object sender, RoutedEventArgs e)
        {

        
            Prescribe sa = new Prescribe();
            sa.Show();


        }
    }
}
