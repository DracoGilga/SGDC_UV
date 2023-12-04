using Front_SGDC.Modelo;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// Lógica de interacción para CU_03.xaml
    /// </summary>
    public partial class CU_03 : Window
    {
        ProfesorViewModel profesorViewModel = new ProfesorViewModel();

        public CU_03()
        {
            InitializeComponent();
            CargarComboBox();
        }
        private async void CargarComboBox()
        {
            List<string> numerosPersonales = await profesorViewModel.ObtenerNumerosPersonales();
            cbNumeroDePersonal.ItemsSource = numerosPersonales;
        }

        private void btnGuardarCambios_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void cbNumeroDePersonal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<string> listaConstancia = await profesorViewModel.ObtenerNumerosPersonales();
            
        }
    }
}

