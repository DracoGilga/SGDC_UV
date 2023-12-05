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

namespace Front_SGDC
{
    /// <summary>
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void CerrarSesion(object sender, MouseButtonEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
        private void btnConstancias_clic(object sender, MouseButtonEventArgs e)
        {
            WindowCU_05 window = new WindowCU_05();
            window.ShowDialog();
        }
        private void btnProfesor_clic(object sender, MouseButtonEventArgs e)
        {
            CU_01 window = new CU_01();
            window.ShowDialog();
        }
        private void btnConstularConstancia_clic(object sender, MouseButtonEventArgs e)
        {
            CU_07 window = new CU_07();
            window.ShowDialog();
        }
        private void btnEditarProfesor_clic(object sender, MouseButtonEventArgs e)
        {
            CU_03 window = new CU_03();
            window.ShowDialog();
        }
    }
}

