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
using Model;
using Controller;
using Service;
using Repository;
using System.IO;
using Projekat.ViewModel;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for CreateNotifficationPatientPage.xaml
    /// </summary>
    public partial class CreateNotifficationPatientPage : Window
    {
        public CreateNotifficationPatientPage()
        {
            InitializeComponent();
            DataContext = new CreateNotificationPatientViewModel(this);
        }
    }
}
