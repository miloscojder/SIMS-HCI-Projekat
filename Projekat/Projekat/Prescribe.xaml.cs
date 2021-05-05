
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
        //public MedicalRecord md;
        public Prescribe(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;
            Name.Text = p.firstName;
            Surname.Text = p.lastName;
            Allergic.Text = p.record.Allergen;
        }

        private void PrescribeMedicine(object sender, RoutedEventArgs e)
        {
            //Prescription pr = new Prescription();
            Patient p = new Patient();
            MedicalRecord mmm = new MedicalRecord();
            int ida = prescriptionController.GenerateNewId();
            String med = Medicine.Text;
            String q = Quantity.Text;
            String ins = Instruction.Text;
            p.firstName = Name.Text;
            p.lastName = Surname.Text;
            mmm.Allergen = Allergic.Text;

            Prescription a = new Prescription(ida, med, q, ins, p);
            prescriptionController.CreatePrescription(a);

            MessageBox.Show("Medicine prescribed!");
            this.Close();
        }
    }
}
