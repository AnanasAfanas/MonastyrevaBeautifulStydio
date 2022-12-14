using MonastyrevaBeautifulStydio.AppData;
using MonastyrevaBeautifulStydio.Model;
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
    /// Логика взаимодействия для AddProizvoditelPage.xaml
    /// </summary>
    public partial class AddProizvoditelPage : Page
    {
        public AddProizvoditelPage()
        {
            InitializeComponent();
        }

        private void AddProizvoditelBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(NameProizvoditelTb.Text))
                mes = "Введите производителя\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Proizvoditel proizvoditel = new Proizvoditel();
            proizvoditel.Name = NameProizvoditelTb.Text;
            ConnectDb.monastirBetyfulStydioEntities.Proizvoditel.Add(proizvoditel);
            ConnectDb.monastirBetyfulStydioEntities.SaveChanges();
            NameProizvoditelTb.Text = "";
        }
    }
}
