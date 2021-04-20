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

    public partial class Operationss : Window
    {
        public OperationController operationController = new OperationController();

        public List<Operations> operations
        {
            get;
            set;
        }
        public Operationss()
        {

            InitializeComponent();
            OperationRepository operationRepository = new OperationRepository();
            List<Operations> operaions = operationRepository.GetAll();
            dataGrid.ItemsSource = operaions;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Operations a = (Operations)dataGrid.SelectedItems[0];
          //  operationController.Cancel(a);

            Operationss ap = new Operationss();
            ap.Show();
        }

        private void Reschedule(object sender, RoutedEventArgs e)
        {

          //  Operations a = (Operations)dataGrid.SelectedItems[0];
          //  ShowChangesO sc = new ShowChangesO(a);
        //    sc.Show();


        }

        private void Schedule(object sender, RoutedEventArgs e)
        {

        
            ScheduleOperation sa = new ScheduleOperation();
            sa.Show();


        }
    }
}
