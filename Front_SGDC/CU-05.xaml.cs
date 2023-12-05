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

namespace Front_SGDC
{
    /// <summary>
    /// Lógica de interacción para CU_05.xaml
    /// </summary>
    /// <summary>
    /// Lógica de interacción para CU_05.xaml
    /// </summary>
    public partial class CU_05 : Page
    {
        public CU_05()
        {
            InitializeComponent();
        }

        private void itemPladea_Click(object sender, RoutedEventArgs e)
        {
            Container.NavigationService.Navigate(new PladeaForm());
        }

        private void itemProject_Click(object sender, RoutedEventArgs e)
        {
            Container.NavigationService.Navigate(new ProjectForm());
        }

        private void itemTeaching_Click(object sender, RoutedEventArgs e)
        {
            Container.NavigationService.Navigate(new TeachingForm());
        }

        private void itemJudge_Click(object sender, RoutedEventArgs e)
        {
            Container.NavigationService.Navigate(new JudgeForm());
        }
    }
}
