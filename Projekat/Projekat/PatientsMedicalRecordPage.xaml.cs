using Model;
using System;
using System.Collections.Generic;
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
using Projekat.ViewModel;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for PatientsMedicalRecordPage.xaml
    /// </summary>
    public partial class PatientsMedicalRecordPage : Window
    {  
        public PatientsMedicalRecordPage()
        {
            InitializeComponent();
            DataContext = new PatientsMedicalRecordViewModel(this);
     
        }

    }
}
     