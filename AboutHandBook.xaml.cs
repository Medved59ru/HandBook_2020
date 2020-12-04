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
using System.Windows.Shapes;

namespace HandBook_2020
{
    /// <summary>
    /// Логика взаимодействия для AboutHandBook.xaml
    /// </summary>
    public partial class AboutHandBook : Window
    {
        public AboutHandBook()
        {
            InitializeComponent();
        }
        private void btnCloseHBAbt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
