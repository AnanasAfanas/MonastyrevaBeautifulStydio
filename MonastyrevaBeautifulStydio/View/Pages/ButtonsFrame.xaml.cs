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
using MonastyrevaBeautifulStydio.AppData;

namespace MonastyrevaBeautifulStydio.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ButtonsFrame.xaml
    /// </summary>
    public partial class ButtonsFrame : Page
    {
        public ButtonsFrame()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.NaviFRM.Navigate(new View.Pages.NavigationButtons());
        }
    }
}
