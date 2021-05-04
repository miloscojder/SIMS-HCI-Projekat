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
        private DoctorController doctorController = new DoctorController();
        private RequestForDinamicEquipmentController requestForDinamicEquipmentController = new RequestForDinamicEquipmentController();
        List<Request> requestToShow = new List<Request>();
        List<Doctor> doctorsToShow = new List<Doctor>();
        List<RequestForDinamicEquipment> requestForDinamicEquipment = new List<RequestForDinamicEquipment>();
        List<string> doctorNames = new List<string>();
        private int id;
  
        public RequestCRUD()
        {
            InitializeComponent();
            requestToShow = requestController.GetAll();
            doctorsToShow = doctorController.GetAllDoctors();
            requestForDinamicEquipment = requestForDinamicEquipmentController.GetAll();
            foreach(Doctor d in doctorsToShow){
                doctorNames.Add(d.FirstName + " " + d.LastName);
            }
            doctorsBox.ItemsSource = doctorNames;
            requestsDataGrid.ItemsSource = requestToShow;
            requestsDataGrid2.ItemsSource = filterRequestsStatus(requestToShow, StatusType.Waiting);
            requestsDataGrid3.ItemsSource = requestForDinamicEquipment;
        }

        public List<Request> filterRequestsStatus(List<Request> requests, StatusType type) {
            List<Request> ret = new List<Request>();
            foreach (Request r in requests) {
                if (r.Status == type) {
                    ret.Add(r);
                }
            }

            return ret;
        }


        private Request CreateRequest()
        {
            int id = requestController.GenerateNextId();
            String descriptions = Description.Text;
            DateTime dt = dateOfVacation.DisplayDate;
            int durations = Int32.Parse(duration.Text);
            string doctorName = (string)doctorsBox.SelectedItem;
            string firstName = doctorName.Split(" ")[0];
            string lastName = doctorName.Split(" ")[1];
            Doctor doc = new Doctor();
            foreach (Doctor d in doctorsToShow){
                if (String.Compare(d.FirstName, firstName) == 0 && String.Compare(d.LastName, lastName) == 0) {
                    doc = d;
                    break;
                }
            }
            Request request = new Request(id, descriptions, dt, DateTime.Now, durations, StatusType.Waiting, "", doc);
            requestController.Save(request);
            return request;

        }
        private void New_Request_Click(object sender, RoutedEventArgs e)
        {
            if(doctorsBox.SelectedItem == null)
            {
                MessageBox.Show("You have to fill in all input boxes!");
                return;
            }
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

        private void accept_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                Request request = (Request)requestsDataGrid2.SelectedItems[0];
                if (explanationBox.Text == "")
                {
                    MessageBox.Show("You have to fill explanation box!");
                    return;
                }
               

                bool result = requestController.AcceptingRequest(request.Id, StatusType.Accepted, explanationBox.Text);
                if(result) MessageBox.Show("Successfuly accepted request!");
               
            }
            catch
            {
                MessageBox.Show("You have to select request which you wan't to accept !");
            }
        }

        private void decline_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Request request = (Request)requestsDataGrid2.SelectedItems[0];
                if (explanationBox.Text == "")
                {
                    MessageBox.Show("You have to fill explanation box!");
                    return;
                }


                bool result = requestController.AcceptingRequest(request.Id, StatusType.Rejected, explanationBox.Text);
                if (!result) MessageBox.Show("Successfuly declined request!");
            }
            catch
            {
                MessageBox.Show("You have to select request which you wan't to decline !");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                if (nameBox.Text == "")
                {
                    MessageBox.Show("You have to fill name box!");
                    return;
                }


            int id = requestForDinamicEquipmentController.generateNextId();
            RequestForDinamicEquipment requestForDinamicEquipment = new RequestForDinamicEquipment(nameBox.Text, StatusType.Waiting, DateTime.Now, id);
            requestForDinamicEquipmentController.Save(requestForDinamicEquipment);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                RequestForDinamicEquipment request = (RequestForDinamicEquipment) requestsDataGrid3.SelectedItems[0];
                if (nameBox.Text == "")
                {
                    MessageBox.Show("You have to fill name box!");
                    return;
                }


                requestForDinamicEquipmentController.Update(request.Id, nameBox.Text);
                MessageBox.Show("Successfuly updated request!");
            }
            catch
            {
                MessageBox.Show("You have to select request which you wan't to update !");
            }
        }

        private void deleteDynamicButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RequestForDinamicEquipment request = (RequestForDinamicEquipment)requestsDataGrid3.SelectedItems[0];

                requestForDinamicEquipmentController.Delete(request.Id);
                MessageBox.Show("Successfuly deleted request!");
            }
            catch
            {
                MessageBox.Show("You have to select request which you wan't to delete !");
            }
        }
    }
}
