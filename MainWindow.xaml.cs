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

namespace ClaraMonteiro_s00185743
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from b in db.Phones
                        select b;

            lbxPhone.ItemsSource = query.ToList();
        }

        private void LbxPhone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selectedPhone = lbxPhone.SelectedItem as Phone;

            if (selectedPhone != null)
            {
                imgPhone.Source = new BitmapImage(new Uri($"/images/(selected.Phone_Image)", UriKind.Relative));

            }
        }
    }
}
