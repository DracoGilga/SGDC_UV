using Front_SGDC.Modelo;
using ServiceReference1;
using System.Collections.Generic;
using System.Windows;

namespace Front_SGDC
{
    /// <summary>
    /// Lógica de interacción para CU_07.xaml
    /// </summary>
    public partial class CU_07 : Window
    {
        ConstanciaViewModel constanciaViewModel = new ConstanciaViewModel();
        public CU_07()
        {
            InitializeComponent();
            MostrarVentana();
        }

        private void Aceptar(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("IMPLEMENTACION DE DETALLES EN EL ENTREGABLE 2");
        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {

        }

        private async void MostrarVentana()
        {
            List<ConstanciaUnion1> listaConstancia = await constanciaViewModel.ListarConstancia();
            foreach (var item in listaConstancia)
            {
                var constancia = new
                {
                    item.constancia.Id_Constancia,
                    item.constancia.fechaCreacionConstancia,
                    item.profesor.nombreCompleto,
                    item.profesor.Id_profesor
                };

                tablaConstancias.Items.Add(constancia);
            }
        }
    }
}