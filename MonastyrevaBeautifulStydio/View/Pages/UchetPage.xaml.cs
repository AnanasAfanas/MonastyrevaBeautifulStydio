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
    /// Логика взаимодействия для UchetPage.xaml
    /// </summary>
    public partial class UchetPage : Page
    {
        public UchetPage()
        {
            InitializeComponent();
            UchetLv.ItemsSource = ConnectDb.monastirBetyfulStydioEntities.Uchet.ToList();
            
            SelectPersonalCmb.ItemsSource = ConnectDb.monastirBetyfulStydioEntities.Sotrudnik.ToList();
        }

        //private void SlectPersonalBtn_Click(object sender, RoutedEventArgs e)
        //{
           
        //}

        private void SelectPersonalCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectSotrud = Convert.ToInt32(((Sotrudnik)SelectPersonalCmb.SelectedItem).Id);
            UchetLv.ItemsSource = ConnectDb.monastirBetyfulStydioEntities.Uchet.Where(i => i.IdSotrudnik == SelectSotrud).ToList();
            var CountZapis = ConnectDb.monastirBetyfulStydioEntities.Uchet.Where(i => i.IdSotrudnik == SelectSotrud).Count();
            KolvoTb.Text = Convert.ToString(CountZapis);
            var SumZapis = ConnectDb.monastirBetyfulStydioEntities.Uchet.Where(i => i.IdSotrudnik == SelectSotrud).Select(x => x.Summa).Sum();
            SummaTb.Text = Convert.ToString(SumZapis);
        }
    }
}
