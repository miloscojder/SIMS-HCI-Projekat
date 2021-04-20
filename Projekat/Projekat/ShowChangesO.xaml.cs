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
using Repository;

namespace Projekat
{
  
    public partial class ShowChangesO : Window
    {
        public OperationController operationController = new OperationController();

        public List<Operations> operations
        {
            get;
            set;
        }
        public ShowChangesO(Appointment appoin)
        {
            InitializeComponent();

        OperationRepository operationRepository = new OperationRepository();
        List<Operations> operations = operationRepository.GetAll();
        dataGrid.ItemsSource = operations;
            
        }

    private void Save(object sender, RoutedEventArgs e)
    {

        String ida = Id.Text;
        String date = Date.Text;
        String hours = Hours.Text;
        String minutes = Minutes.Text;
        String hourss = Hourss.Text;
        String minutess = Minutess.Text;
        String start = hours + ":" + minutes;
        String end = hourss + ":" + minutess;
        String duration = Duration.Text;


        //Operations a = new Operations(ida, date, start, duration, end);
         //   operationController.RescheduleDoctor(a);

        Operationss ap = new Operationss();
        ap.Show();


    }
}
}
