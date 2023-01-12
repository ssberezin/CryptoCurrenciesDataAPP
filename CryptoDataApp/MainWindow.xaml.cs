using CryptoDataApp.ViewModel;
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

namespace CryptoDataApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // DataContext = new MainViewModel();


        }
        //mb here there is smp
        //https://www.youtube.com/watch?v=0SCKUine6tY&ab_channel=SingletonSean
        private async void WindowLoaded(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();            
            await ((MainViewModel)DataContext).ItinAssets();
        }



    }
}
