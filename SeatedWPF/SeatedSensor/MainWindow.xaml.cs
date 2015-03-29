using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
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
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Mantin.Controls.Wpf.Notification;


namespace SeatedSensor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sensor1;
        int sensor2;
        public MainWindow()
        {
            InitializeComponent();
            update();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 3);
            dispatcherTimer.Start();

        }


static string HttpGet(string url) {
  HttpWebRequest req = WebRequest.Create(url)
                       as HttpWebRequest;
  string result = null;
  using (HttpWebResponse resp = req.GetResponse()
                                as HttpWebResponse)
  {
    StreamReader reader =
        new StreamReader(resp.GetResponseStream());
    result = reader.ReadToEnd();
  }
  return result;
}



private void update()
        {
           string jsonCell2 =  HttpGet("https://api.spark.io/v1/devices/54ff71066672524822431867/photocell2?access_token=eef5a0cba3f7e74a20df3a6d9b49229ce8b54fc7");
           string jsonCell = HttpGet("https://api.spark.io/v1/devices/54ff71066672524822431867/photocell?access_token=eef5a0cba3f7e74a20df3a6d9b49229ce8b54fc7");

            RootObject photocell2 = JsonConvert.DeserializeObject<RootObject>(jsonCell2);
            RootObject photocell = JsonConvert.DeserializeObject<RootObject>(jsonCell);

            sensor1 = photocell.result;
            sensor2 = photocell2.result;

           
    

            if (sensor1 == 1)
            {
                Indicator.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
                
                begintimer();

            }

            else  if (sensor1 == 0)
            {
                Indicator.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black);

            }

            if (sensor2 == 1)
            {
                Indicator2.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);

            }

            else if (sensor1 == 0)
            {
                Indicator2.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black);

            }

    if (sensor2 == 0 && sensor1 == 1)
    {
        MessageBox.Show("Are you in your chair? The lights and seat sensor do not agree");
    }

   
            // Bad Boys
         
        }

System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
private void begintimer()
{
   
    dispatcherTimer.Tick += new EventHandler(popup);
    dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 3);
    dispatcherTimer.Start();
}

private void popup(object sender, EventArgs e)
{
    new ToastPopUp("Alert", "You've been sitting around for too long buddy", NotificationType.Information)
    {
        Background = new LinearGradientBrush(System.Windows.Media.Color.FromArgb(255, 4, 253, 82), System.Windows.Media.Color.FromArgb(255, 10, 13, 248), 90),
        BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0)),
        FontColor = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255))
    }.Show();
    dispatcherTimer.Stop();
}

private void dispatcherTimer_Tick(object sender, EventArgs e)
{
    update();
}

private void Button_Click(object sender, RoutedEventArgs e)
{

    var newForm = new Window1(); //create your new form.
    newForm.Show(); //show the new form.
    this.Close(); //only if you want to close the current form.

}
}
        
    }
