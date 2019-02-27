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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(new Action(aufruf));
        }

        void aufruf()
        {
            Dispatcher.Invoke(new Action(() => button1.IsEnabled = false));

            //Zeitaufwendiger Prozess!!
            Thread.Sleep(2000);

            Dispatcher.Invoke(new Action(() => label_1.Content = "Hallo"));

            Dispatcher.Invoke(new Action(() => button1.IsEnabled = true));
        }

    }
}
