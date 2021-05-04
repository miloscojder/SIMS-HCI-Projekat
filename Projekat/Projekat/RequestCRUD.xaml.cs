using Controller;
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

namespace Projekat
{
    /// <summary>
    /// Interaction logic for RequestCRUD.xaml
    /// </summary>
    public partial class RequestCRUD : Window
    {
        private RequestController requestController = new RequestController();
        List<Request> requestToShow = new List<Request>();
        List<Doctor> doctorsToShow = new List<Doctor>();
        private int id;
  
        public RequestCRUD()
        {
            InitializeComponent();
            requestToShow = requestController.GetAll();

            requestsDataGrid.ItemsSource = requestToShow;
        }


        private Request CreateRequest()
        {
            int id = requestController.GenerateNextId();
            String descriptions = Description.Text;
            DateTime dt = dateOfVacation.DisplayDate;
            int durations = Int32.Parse(duration.Text);
            //int docId = Int32.Parse(Doctor.Text);
            Doctor doc = new Doctor();
            Request request = new Request(id, descriptions, dt, DateTime.Now, durations, StatusType.Waiting, "", doc);
            requestController.Save(request);
            return request;

        }
        private void New_Request_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Request request = CreateRequest();
            }
            catch
            {
                MessageBox.Show("You have to fill in all input boxes!");
            }
        }

        private void Delete_Request_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Request request = (Request)requestsDataGrid.SelectedItems[0];
               
                requestController.DeleteRequest(request.Id);
            }
            catch
            {
                MessageBox.Show("You have to select a request to delete!");
            }
        }

        private void updateRequestButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Request request = (Request)requestsDataGrid.SelectedItems[0];
                id = request.Id;
                createRequest.Visibility = Visibility.Collapsed;
                updateRequestButton.Visibility = Visibility.Visible;
                cancelupdateRequestButton.Visibility = Visibility.Visible;
                title.Content = "Edit request";

                Description.Text = request.Description;
                dateOfVacation.Text = request.DateOfVacation.ToString();
                duration.Text = request.DurationOfVacation.ToString();

            }
            catch
            {
                MessageBox.Show("You have to fill in all input boxes!");
            }
        }

        private void update_Request_Click(object sender, RoutedEventArgs e)
        {
            
            string desc = Description.Text;
            DateTime date = DateTime.Parse(dateOfVacation.Text);
            int durations = Int32.Parse(duration.Text);
            requestController.UpdateRequest(id, desc, date, durations);
           


        }

        private void cancelupdateRequestButton_Click(object sender, RoutedEventArgs e)
        {

            Description.Text = "";
            dateOfVacation.Text = "" ;
            duration.Text = "";

   

            createRequest.Visibility = Visibility.Visible;
            updateRequestButton.Visibility = Visibility.Collapsed;
            cancelupdateRequestButton.Visibility = Visibility.Collapsed;
            title.Content = "Create new request";
        }

        private void requestsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
