
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
   
    public partial class ScheduleOperation : Window
    {
        public OperationController operationController = new OperationController();
        public ScheduleOperation()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Schedule(object sender, RoutedEventArgs e)
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
            //    Room idroom = Rid;
            // Patient idpatient = Pid.Text;
            // String type = type.Text;




            //    TipPregleda t = new TipPregleda();
          //  Operations a = new Operations(ida, date, start, duration, end);
          //  operationController.ScheduleOperation(a);

            Operationss ap = new Operationss();
            ap.Show();

           
        }
    }
}
