
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
using Controller;

namespace Projekat
{
   
    public partial class Prescribe : Window
    {
        public PrescriptionController prescriptionController = new PrescriptionController();
        public Prescribe()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void PrescribeMedicine(object sender, RoutedEventArgs e)
        {
            String ida = Id.Text;
            String med = Medicine.Text;
            String q = Quantity.Text;
            String ins = Instruction.Text;
            // Patient idpatient = Pid.Text;

            Prescription a = new Prescription(ida, med, q, ins);
            prescriptionController.CreatePrescription(a);

            MessageBox.Show("Medicine prescribed!");
            this.Close();
        }
    }
}
