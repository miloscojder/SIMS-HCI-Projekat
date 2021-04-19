using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Model;
using Newtonsoft.Json;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Request request = new Request(1, "description1", new DateTime(), new DateTime(), 2, StatusType.Waiting, "", new Doctor());
            //Primer serijalizacije
            string outPut = JsonConvert.SerializeObject(request);
            System.Console.WriteLine(outPut);
            string location = "C:\\Users\\cojder\\Desktop\\SIMS_Projekat\\SIMS-HCI-Projekat\\Projekat\\Projekat\\Data\\Requests.json";

            File.WriteAllText(location, outPut);
            //Primer deserijalizacije
            using (StreamReader r = new StreamReader(location)) {
                string allData = r.ReadToEnd();
                if (allData != "") {
                    Request loaded = JsonConvert.DeserializeObject<Request>(allData);
                    System.Console.WriteLine(loaded);
                }
            }

                
        }
    }
}
