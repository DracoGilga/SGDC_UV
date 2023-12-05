using Front_SGDC.Modelo;
using ServiceReference1;
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
    /// Lógica de interacción para CU_01.xaml
    /// </summary>
    public partial class CU_01 : Window
    {
        public CU_01()
        {
            InitializeComponent();
        }

        private async void btnAgregarProfesor_Click(object sender, RoutedEventArgs e)
        {
            if(tbxNombreProfesor.Text != "" && tbxNumeroPersonal.Text != "")
            {
                Profesor profesor = new Profesor();
                profesor.nombreCompleto = tbxNombreProfesor.Text;
                profesor.numeroPersonal = tbxNumeroPersonal.Text;
                ProfesorViewModel profesorViewModel = new ProfesorViewModel();
                if (await profesorViewModel.AgregarProfesor(profesor))
                    MessageBox.Show("Se ha agregado el profesor");
                else
                    MessageBox.Show("No se ha podido agregar el profesor");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha ingresado un nombre o un número de personal");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
