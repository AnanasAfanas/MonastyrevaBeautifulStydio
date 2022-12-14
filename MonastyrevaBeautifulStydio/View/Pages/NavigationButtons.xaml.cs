using MonastyrevaBeautifulStydio.AppData;
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

namespace MonastyrevaBeautifulStydio.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для NavigationButtons.xaml
    /// </summary>
    public partial class NavigationButtons : Page
    {
        public NavigationButtons()
        {
            InitializeComponent();
        }

        private void UchetNavBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.AddUchetFrm.Navigate(new AddUchetPage());
        }

        private void ProizvoditelNavBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.AddProizvoditelFrm.Navigate(new AddProizvoditelPage());
        }

        private void SotrudnikNavBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.AddSotrudnikFrm.Navigate(new AddSotrudnikPage());
        }

        private void MaterialNavBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.AddTovarFrm.Navigate(new AddTovarPage());
        }

        private void ListUchetNavBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.AddListUchetFrm.Navigate(new UchetPage());
        }

        private void PerodNavBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.AddPeriodSelectionFrm.Navigate(new PeriodPage());
        }
    }
}
