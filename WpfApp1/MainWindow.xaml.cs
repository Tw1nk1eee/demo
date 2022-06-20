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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MaterialListView.ItemsSource = DEMOEntities.GetContext().Material.ToList();
        }

        

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TypeComboBox_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Sorting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }
}
