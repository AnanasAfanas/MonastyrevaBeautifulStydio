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
    /// Логика взаимодействия для PeriodPage.xaml
    /// </summary>
    public partial class PeriodPage : Page
    {
        public PeriodPage()
        {
            InitializeComponent();
            DataLv.ItemsSource = ConnectDb.monastirBetyfulStydioEntities.Uchet.ToList();
        }

        private void OrgerByDateBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(DateSartDp.Text))
                mes += "Выберите начало периода \n";
            if (!string.IsNullOrWhiteSpace(DateStopDp.Text))
                mes += "Выберите конец периода \n";
            if (mes == "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            var a = (DateTime)DateSartDp.SelectedDate;
            var b = (DateTime)DateStopDp.SelectedDate;
            //var qwerty = ConnectDb.monastirBetyfulStydioEntities.Uchet.Where(i => i.Detalspol >= a && i.Detalspol <= b).GroupBy(y => y.Sotrudnik).Select(g => new{Сотрудник = g.Key, Сумма = g.Sum(s => s.Summa)}).OrderBy(n => n.Сотрудник);
            DataLv.ItemsSource = ConnectDb.monastirBetyfulStydioEntities.View_1.Where(i => i.Detalspol >= a && i.Detalspol <= b)
                .GroupBy(y => y.Name)
                .Select(g => new { Сотрудник = g.Key, Сумма = g
                .Sum(s => s.Summa) })
                .OrderBy(n => n.Сотрудник).
                ToList(); 
        }
    }
}
