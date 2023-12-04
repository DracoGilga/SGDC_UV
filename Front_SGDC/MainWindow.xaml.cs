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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Front_SGDC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void IniciarSesion(object sender, RoutedEventArgs e)
        {
            PersonalAdministrativoViewModel personalAdministrativoViewModel = new PersonalAdministrativoViewModel();
            PersonalAdministrativo personalAdministrativo = new PersonalAdministrativo()
            {
                usuario = tbxUsuario.Text,
                password = tbxContrasena.Text
            };
            if (await personalAdministrativoViewModel.InicioSesion2(personalAdministrativo))
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

    }
}