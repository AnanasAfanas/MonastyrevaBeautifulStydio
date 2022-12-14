using MonastyrevaBeautifulStydio.AppData;
using MonastyrevaBeautifulStydio.View.Pages;
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

namespace MonastyrevaBeautifulStydio
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationClass.ButtonsFramess = ButtonsFrm;
            ButtonsFrm.Navigate(new View.Pages.ButtonsFrame());
            NavigationClass.NaviFRM = ButtonsFrm;
            NavigationClass.NaviUchetFrm = MainFrame;
            NavigationClass.AddProizvoditelFrm = MainFrame;
            NavigationClass.AddSotrudnikFrm = MainFrame;
            NavigationClass.AddTovarFrm = MainFrame;
            NavigationClass.AddUchetFrm = MainFrame;
            NavigationClass.AddListUchetFrm = MainFrame;
            NavigationClass.AddPeriodSelectionFrm = MainFrame;


            //ButtonsFrame okfrm = new ButtonsFrame();
            //ButtonsFrm.Navigate(okfrm);
        }
    }
}
