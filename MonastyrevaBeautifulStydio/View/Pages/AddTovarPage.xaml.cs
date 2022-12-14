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
    /// Логика взаимодействия для AddTovarPage.xaml
    /// </summary>
    public partial class AddTovarPage : Page
    {
        public AddTovarPage()
        {
            InitializeComponent();
            NameProizvoditelTavaraCb.ItemsSource = ConnectDb.monastirBetyfulStydioEntities.Proizvoditel.ToList(); 
        }

        private void AddTovarBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(NametovaTb.Text))
                mes += "Введите названиее товара\n";
            if (string.IsNullOrWhiteSpace(NameProizvoditelTavaraCb.Text))
                mes += "выберите имя производителя";
            if (mes != "")
            { 
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Material material = new Material();
            material.Name = NametovaTb.Text;
            material.IdProizvoditel = NameProizvoditelTavaraCb.SelectedIndex+1;
            ConnectDb.monastirBetyfulStydioEntities.Material.Add(material);
            ConnectDb.monastirBetyfulStydioEntities.SaveChanges();
            MessageBox.Show("Зaпись добавлена удачно");
            NametovaTb.Text = "";
            NameProizvoditelTavaraCb.Text = "";
        }
    }
}
