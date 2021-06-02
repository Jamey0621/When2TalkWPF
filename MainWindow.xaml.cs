using ApiHelper.Kanye;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
using ApiHelper.RonSwanson;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void KayGen()
        {
            KGen.Text = KaneyQuoteGenerater.KayneQuote();
        }

        public void RonGen()
        {
          
            RGen.Text = RonQuoteGenerater.RonQuote();
        }

        private void RGen_Loaded(object sender, RoutedEventArgs e)
        {
            RonGen();
        }

        private void KGen_Loaded(object sender, RoutedEventArgs e)
        {
            KayGen();
        }

     
    }
}
