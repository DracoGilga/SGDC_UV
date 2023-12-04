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
            List<Profesor> numerosPersonales = await profesorViewModel.ObtenerNumerosPersonales();
            cbNumeroDePersonal.ItemsSource = numerosPersonales;
        }

        private async void btnGuardarCambios_Click(object sender, RoutedEventArgs e)
        {
            if(cbNumeroDePersonal.SelectedIndex != -1 && tbxNuevoNombreCompletoDeProfesor.Text != "")
            {
                Profesor profesor = new Profesor();
                profesor.Id_profesor = (cbNumeroDePersonal.SelectedItem as Profesor).Id_profesor;
                profesor.numeroPersonal = (cbNumeroDePersonal.SelectedItem as Profesor).numeroPersonal;
                profesor.nombreCompleto = tbxNuevoNombreCompletoDeProfesor.Text;
                if (await profesorViewModel.ModificarProfesor(profesor))
                    MessageBox.Show("Se ha actualizado el nombre completo del profesor");
                else
                    MessageBox.Show("No se ha podido actualizar el nombre completo del profesor");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un profesor o no se ha ingresado un nombre completo");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void cbNumeroDePersonal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbNumeroDePersonal.SelectedIndex != -1)
            {
                tbxNuevoNombreCompletoDeProfesor.Text = (cbNumeroDePersonal.SelectedItem as Profesor).nombreCompleto;
            }
        }
    }
}

