using MonastyrevaBeautifulStydio.AppData;
using MonastyrevaBeautifulStydio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
    /// Логика взаимодействия для AddSotrudnikPage.xaml
    /// </summary>
    public partial class AddSotrudnikPage : Page
    {
        public AddSotrudnikPage()
        {
            InitializeComponent();
        }

        private void AddSotrudnikBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(NameSotrudnikTb.Text))
                mes = "Введите производителя\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Sotrudnik sotrudnik = new Sotrudnik();
            sotrudnik.Name = NameSotrudnikTb.Text;
            ConnectDb.monastirBetyfulStydioEntities.Sotrudnik.Add(sotrudnik);
            ConnectDb.monastirBetyfulStydioEntities.SaveChanges();
            NameSotrudnikTb.Text = "";
        }
    }
}
