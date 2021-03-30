using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// <summary>
    /// Interaction logic for VacationRequests.xaml
    /// </summary>
    public partial class VacationRequests : Window
    {
        public VacationRequests()
        {
            InitializeComponent();
        }
        public void SendRequest(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vacation is succesfully approved!");

        }
        public void CancelRequest(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have canceled vacation request.");
        }
    }
}
