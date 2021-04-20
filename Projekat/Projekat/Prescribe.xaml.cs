
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
   
    public partial class Prescribe : Window
    {
        public Prescribe()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void PrescribeMedicine(object sender, RoutedEventArgs e)
        {
            //prikupljam polja iz forme
           
            String ida = Id.Text;
            String med = (String)Medicine.Text;
            String q = (String)Quantity.Text;
            String ins = (String)Instruction.Text;

            String Idnovi = Convert.ToString(ida)+1;
            

           
            String red =Idnovi.ToString()+ "," + ida + "," +  med + "," + q + "," + ins ;



            //PrescriptionFileStorage fajl = new PrescriptionFileStorage(@"C:\Users\krist\Desktop\prescriptions.txt");
            // fajl.Save(red,true);

             MessageBox.Show("Medicine prescribed!");
            this.Close();
        }
    }
}
