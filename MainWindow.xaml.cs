using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HandBook_2020
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string filePaph;
        public string partDescription;
        public MainWindow()
        {
            InitializeComponent();
            PDFDock.Margin = new Thickness(100);
        }
        /// <summary>
        /// обработчик нажатия кнопки "Меню"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if (sideMenu.Visibility == Visibility.Collapsed)
            {
                PDFDock.Margin = new Thickness(100);
                sideMenu.Visibility = Visibility.Visible;
                PDFBorder.Visibility = Visibility.Collapsed;
                PDFHost.Visibility = Visibility.Collapsed;
                SmallLogo.Visibility = Visibility.Collapsed;
                HeaderText.Text = "";
            }
            else
            {
                sideMenu.Visibility = Visibility.Collapsed;
                PDFDock.Margin = new Thickness(100);
            }
        }
        /// <summary>
        ///   Обработка нажатия на кнопки бокового меню. Событие нажание на объект размещенный в панели 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideMenu_Click(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource == btnIntroduction)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\1_4.pdf";
                HeaderText.Text = "ВВЕДЕНИЕ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnDrillingOrganization)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\5.pdf";
                HeaderText.Text = "ПОРЯДОК ВЗАИМООТНОШЕНИЙ ПРИ ПРОИЗВОДСТВЕ БУРОВЫХ РАБОТ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnWellDesign)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\6.pdf";
                HeaderText.Text = "ПРОЕКТИРОВАНИЕ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnWellConstructionTechnology)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\7.pdf";
                HeaderText.Text = "ТЕХНОЛОГИИ СТРОИТЕЛЬСТВА СКВАЖИН";
                btnClickResult(filePaph);

            }
            else if (e.OriginalSource == btnDrillingFluids)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\8.pdf";
                HeaderText.Text = "БУРОВЫЕ РАСТВОРЫ";
                btnClickResult(filePaph);

            }
            else if (e.OriginalSource == btnCementing)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\9.pdf";
                HeaderText.Text = "КРЕПЛЕНИЕ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnLWD)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\10.pdf";
                HeaderText.Text = "ГИС В ПРОЦЕССЕ БУРЕНИЯ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnPlugging)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\11.pdf";
                HeaderText.Text = "УСТАНОВКА МОСТОВ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnTesting)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\12.pdf";
                HeaderText.Text = "ИСПЫТАНИЯ В ПРОЦЕССЕ БУРЕНИЯ";
                btnClickResult(filePaph);

            }
            else if (e.OriginalSource == btnBOP)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\13.pdf";
                HeaderText.Text = "ПВО";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnSealing)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\14.pdf";
                HeaderText.Text = "ЛИКВИДАЦИЯ ПОГЛОЩЕНИЙ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnComplication)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\15.pdf";
                HeaderText.Text = "ПРЕДУПРЕЖДЕНИЕ И БОРЬБА С ОСЛОЖНЕНИЯМИ В ПРОЦЕССЕ СТРОИТЕЛЬСТВА СКВАЖИН";
                btnClickResult(filePaph);

            }
            else if (e.OriginalSource == btnSideTracking)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\16.pdf";
                HeaderText.Text = "ЗАРЕЗКА БОКОВЫХ СТВОЛОВ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnProduction)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\17.pdf";
                HeaderText.Text = "ОСВОЕНИЕ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnShutOff)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\17_8.pdf";
                HeaderText.Text = "ГЛУШЕНИЕ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnFixCasing)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\17_9.pdf";
                HeaderText.Text = "РЕМОНТНО - ИЗОЛЯЦИОННЫЕ РАБОТЫ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnPump)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\18.pdf";
                HeaderText.Text = "ГЛУБИННО-НАСОСНОЕ ОБОРУДОВАНИЕ";
                btnClickResult(filePaph);
            }
            else if (e.OriginalSource == btnUKDPS)
            {
                filePaph = $"{Environment.CurrentDirectory}/Parts\\19.pdf";
                HeaderText.Text = "ВЕРХНЕКАМСКОЕ МЕСТОРОЖДЕНИЕ КАЛИЙНЫХ СОЛЕЙ";
                btnClickResult(filePaph);
            }



        }

        /// <summary>
        /// реализация принципа DRY. обработка однотипных событий при нажитии кнопки бокового меню.
        /// </summary>
        /// <param name="filePaph"></param>
        private void btnClickResult(string filePaph)
        {
            try // обработка случая отсуствия подключаемого по COM приложения Acrobat
            {
                var uPDFc = new UserControl1(filePaph);
                this.PDFHost.Child = uPDFc;
                PDFDock.Margin = new Thickness(0);
                sideMenu.Visibility = Visibility.Collapsed;
                PDFBorder.Visibility = Visibility.Visible;
                PDFHost.Visibility = Visibility.Visible;
                SmallLogo.Visibility = Visibility.Visible;
                FAQMenu.Visibility = Visibility.Collapsed;
            }
            catch
            {
                System.Windows.MessageBox.Show("Прочитайте файл с требованиями к системе Readme.txt в корневом каталоге. \n Возможно необходимо устновить или обновить Adobe Acrobat Reader. ", "ВНИМАНИЕ.  ПРИЛОЖЕНИЕ ЗАКРЫВАЕТСЯ. ", MessageBoxButton.OK, MessageBoxImage.Error);
                System.Windows.Application.Current.Shutdown();
            }

        }
        /// <summary>
        /// обработка событий нажания на кнопки в меню справочники 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FAQMenu_Click(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource == bntFAQ)
            {
                Window FAQwindow = new HowDoesItWork();
                FAQwindow.Show();
                FAQMenu.Visibility = Visibility.Collapsed;
            }
            else if (e.OriginalSource == btnAbout)
            {
                Window AbtWnd = new About();
                AbtWnd.ShowDialog();
                FAQMenu.Visibility = Visibility.Collapsed;
            }
            else if (e.OriginalSource == btnAboutBook)
            {
                Window AbtHBWnd = new AboutHandBook();
                AbtHBWnd.ShowDialog();
                FAQMenu.Visibility = Visibility.Collapsed;
            }
        }
        /// <summary>
        /// ОБРАБОТЧИК ЗАКРЫТЬ ПРИЛОЖЕНИЕ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShutDown_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// обработка события нажаний на кнопки справочника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnFAQMenu_Click(object sender, RoutedEventArgs e)
        {
            if (FAQMenu.Visibility == Visibility.Collapsed)
            {
                FAQMenu.Visibility = Visibility.Visible;
            }
            else
            {
                FAQMenu.Visibility = Visibility.Collapsed;
            }
        }
    }

}
