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
    /// Логика взаимодействия для AddUchetPage.xaml
    /// </summary>
    public partial class AddUchetPage : Page
    {
        public AddUchetPage()
        {
            InitializeComponent();
            ProizvoditelCb.ItemsSource = ConnectDb.monastirBetyfulStydioEntities.Proizvoditel.ToList();
            MaterialCb.ItemsSource = ConnectDb.monastirBetyfulStydioEntities.Material.ToList();
            SontudnikCb.ItemsSource = ConnectDb.monastirBetyfulStydioEntities.Sotrudnik.ToList();
        }

        private void AddUchetBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";

            if (string.IsNullOrWhiteSpace(PriceTb.Text))
                mes = "Введите цену \n";
            if (string.IsNullOrWhiteSpace(CountTbl.Text))
                mes = "Введите количество\n";
            if (string.IsNullOrWhiteSpace(SelectDateVidachiDp.Text))
                mes = "Введите дату\n";
            if (string.IsNullOrWhiteSpace(SontudnikCb.Text))
                mes = "Введите производителя\n";
            if (string.IsNullOrWhiteSpace(MaterialCb.Text))
                mes = "Введите материал\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Uchet uchet = new Uchet();
            uchet.Zena = Convert.ToDecimal(PriceTb.Text);
            uchet.Detalspol = (DateTime)SelectDateVidachiDp.SelectedDate;
            uchet.Kolvo = Convert.ToInt32(CountTbl.Text);
            uchet.Sotrudnik = SontudnikCb.SelectedItem as Sotrudnik;
            uchet.Material = MaterialCb.SelectedItem as Material;
            ConnectDb.monastirBetyfulStydioEntities.Uchet.Add(uchet);
            ConnectDb.monastirBetyfulStydioEntities.SaveChanges();
            MessageBox.Show("Запись добавлена");
            PriceTb.Text = "";
            SelectDateVidachiDp.Text = "";
            CountTbl.Text = "";
            SontudnikCb.Text = "";
            MaterialCb.Text = "";
            //uchet.IdMaterial;
        }

        private void ProizvoditelCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MaterialCb.ItemsSource = ConnectDb.monastirBetyfulStydioEntities.Material.Where(i => i.IdProizvoditel == ((Proizvoditel)ProizvoditelCb.SelectedItem).Id).ToList();
        }

       
    }
}
