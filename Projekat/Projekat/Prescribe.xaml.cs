
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
        public MedicalRecord md;
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
            Patient pe = new Patient();
            MedicalRecord mmm = new MedicalRecord();
            int ida = prescriptionController.GenerateNewId();
            String med = Medicine.Text;
            //mmm.Allergen = Allergic.Text;
            mmm.Allergen = Allergic.Text;
            String q = Quantity.Text;
            String ins = Instruction.Text;
            pe.firstName = Name.Text;
            pe.lastName = Surname.Text;
            

            if (med == mmm.Allergen)
            {
                MessageBox.Show("YOU ENTERED PATIENTS ALLERGEN!");
                
            } else
            {


                Prescription a = new Prescription(ida, med, q, ins, pe);
                prescriptionController.CreatePrescription(a);


                MessageBox.Show("Medicine prescribed!");
                

                Prescriptions ap = new Prescriptions();
                ap.Show();
                Close();
            }

        }
    }
}
