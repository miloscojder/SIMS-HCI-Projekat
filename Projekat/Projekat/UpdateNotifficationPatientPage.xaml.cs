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

namespace Projekat
{
    /// <summary>
    /// Interaction logic for UpdateNotifficationPatientPage.xaml
    /// </summary>
    public partial class UpdateNotifficationPatientPage : Window
    {
        public UpdateNotifficationPatientPage(Notification chossenNotification)
        {
            InitializeComponent();
            this.DataContext = this;


        }
    }
}
