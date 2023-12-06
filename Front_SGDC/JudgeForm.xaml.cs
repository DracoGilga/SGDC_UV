using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
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
using Font = iTextSharp.text.Font;
using Paragraph = iTextSharp.text.Paragraph;
using System.Globalization;
using ServiceReference1;
using Front_SGDC.Modelo;

namespace Front_SGDC
{
    /// <summary>
    /// Lógica de interacción para JudgeForm.xaml
    /// </summary>
    public partial class JudgeForm : Page
    {
        public string professorName = "";
        public JudgeForm()
        {
            InitializeComponent();
        }
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            crearConstancias();

        }
        private void crearConstancias()
        {
            string directorName = "Carlos Alberto Ochoa Rivera";
            string alumnos = tbxAlumnos.Text;
            string modalidad = tbxModalidad.Text;
            string licenciatura = tbxLicenciatura.Text;
            string titulo = tbxTituloTrabajo.Text;
            string fechaPresentacion = datePickerPresentacion.ToString();
            string cargo = ((ComboBoxItem)cbxCargo.SelectedItem)?.Content.ToString();
            string resultado = tbxResultadoDefensa.Text;

            //Nombre del archivo
            string outputPdfPath = "D:/Documents/administracionProyectos/Constancias/modificadoJurado.pdf";
            //Crear documento
            using (Document doc = new Document())
            {
                //Fuente y tamaño base
                BaseFont baseFont = BaseFont.CreateFont("c:\\windows\\fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font font = new Font(baseFont, 11);
                using (PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPdfPath, FileMode.Create)))
                {
                    doc.Open();

                    //Encabezado
                    var fontFac = FontFactory.GetFont("Gill Sans MT", 8f, Font.BOLD);
                    var rightAlignedHeaderFac = new Paragraph("Facultad de Estadística e Informática", fontFac);
                    rightAlignedHeaderFac.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(rightAlignedHeaderFac);
                    var fontRegion = iTextSharp.text.FontFactory.GetFont("Gill Sans MT", 7f, iTextSharp.text.Font.BOLD);
                    var rightAlignedHeaderRegion = new iTextSharp.text.Paragraph("Región Xalapa", fontRegion);
                    rightAlignedHeaderRegion.Alignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    doc.Add(rightAlignedHeaderRegion);

                    //Encabezado a la izquierda y en negrita
                    Paragraph leftAlignedHeader1 = new Paragraph("A quien corresponda:", new Font(baseFont, 11, Font.BOLD));
                    leftAlignedHeader1.Add("\n");
                    doc.Add(leftAlignedHeader1);
                    //Texto a la izquierda
                    Paragraph leftAlignedContent = new Paragraph();
                    leftAlignedContent.Add("El que suscribe, Director de la Facultad de Estadística e Informática, de la Universidad Veracruzana");
                    leftAlignedContent.Add("\n");
                    doc.Add(leftAlignedContent);

                    // Texto centrado y en negrita
                    Paragraph centeredTitle = new Paragraph($"HACE CONSTAR", new Font(baseFont, 11, Font.BOLD));
                    centeredTitle.Alignment = Element.ALIGN_CENTER;
                    doc.Add(centeredTitle);

                    Paragraph leftAlignedContent2 = new Paragraph();
                    leftAlignedContent2.Add("que el Mtro. <<Nombre del profesor>, fungió como " + cargo + " en los siguientes trabajos recepcionales de la licenciatura " + licenciatura);
                    leftAlignedContent2.Add("\n\n");
                    doc.Add(leftAlignedContent2);

                    // Crear la tabla
                    PdfPTable table = new PdfPTable(5); // 5 columnas
                    table.WidthPercentage = 100;

                    // Encabezados de la tabla
                    table.AddCell("Nombre(s) del (los) alumno(s)");
                    table.AddCell("Título del trabajo");
                    table.AddCell("Modalidad");
                    table.AddCell("Fecha de presentación");
                    table.AddCell("Resultado obtenido en la defensa");

                    // Agregar datos a la tabla
                    table.AddCell(alumnos);
                    table.AddCell(titulo);
                    table.AddCell(modalidad);
                    table.AddCell(fechaPresentacion);
                    table.AddCell(resultado);

                    // Agregar la tabla al documento
                    doc.Add(table);

                    string fechaActual = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("es-ES"));

                    Paragraph leftAlignedContent3 = new Paragraph();
                    leftAlignedContent3.Add($"A petición de la interesada y para los usos legales que a la misma convengan, se extiende la presente en la ciudad de Xalapa de Enríquez, Veracruz a los {fechaActual}");
                    leftAlignedContent3.Add("\n\n\n");
                    doc.Add(leftAlignedContent3);

                    Paragraph centeredContent = new Paragraph();
                    centeredContent.Alignment = Element.ALIGN_CENTER;
                    centeredContent.Add("A t e n t a m e n t e");
                    centeredContent.Add("\n");
                    centeredContent.Add("“Lis de Veracruz: Arte, Ciencia, Luz”");
                    centeredContent.Add("\n\n");
                    centeredContent.Add("\n\n");
                    centeredContent.Add($"{directorName}");
                    centeredContent.Add("\n");
                    centeredContent.Add("Director");
                    doc.Add(centeredContent);

                    doc.Close();
                }
            }

        }
        private async void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            ProfesorViewModel profesorViewModel = new ProfesorViewModel();
            if (tbxNumPersonal.Text != "")
            {
                Profesor professorName;
                professorName = await profesorViewModel.BuscarProfesorNoPersonal(tbxNumPersonal.Text);
                if (professorName != null)
                    tbxNombreDeProfesor.Text = professorName.nombreCompleto;
                else
                    MessageBox.Show("No se ha encontrado el profesor");
            }
            else
                MessageBox.Show("No se ha ingresado un número de personal");
        }
    }
}
