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
    /// Lógica de interacción para WindowCU_05.xaml
    /// </summary>
    public partial class WindowCU_05 : Window
    {
        public WindowCU_05()
        {
            InitializeComponent();

            // Crea una nueva instancia de tu página
            CU_05 cu_05 = new CU_05();

            // Obtiene el Frame de la ventana
            Frame frame = (Frame)this.framePrincipal;

            // Navega a la nueva página
            frame.Navigate(cu_05);
        }

    }
}
