using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Front_SGDC.Modelo;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using ServiceReference1;
using Paragraph = iTextSharp.text.Paragraph;

namespace Front_SGDC
{
    /// <summary>
    /// Lógica de interacción para ProjectForm.xaml
    /// </summary>
    public partial class ProjectForm : Page
    {
        public ProjectForm()
        {
            InitializeComponent();
        }
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            //string directorName = "Carlos Alberto Ochoa Rivera";
            string proyectName = tbxProjectName.Text;
            string place = tbxPlace.Text;
            //string studentName = tbxStudents;
            string result = tbxResult.ToString();

            crearConstancia();
        }


        private void crearConstancia()
        {
            string directorName = "Carlos Alberto Ochoa Rivera";
            string proyectName = tbxProjectName.Text;
            string timeLapse = tbxTimelapse.Text;
            string place = tbxPlace.Text;
            string studentName = tbxStudents.Text;
            string result = tbxResult.Text;

            // Nombre del archivo de salida
            string outputPdfPath = "D:/Documents/administracionProyectos/Constancias/modificadoProjecto.pdf";
            // Crear el documento
            using (Document doc = new Document())
            {
                // Configurar la fuente y tamaño
                BaseFont baseFont = BaseFont.CreateFont("c:\\windows\\fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font font = new Font(baseFont, 11);

                // Crear el escritor PDF
                using (PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPdfPath, FileMode.Create)))
                {
                    doc.Open();

                    // Texto alineado a la izquierda y en negrita
                    Paragraph leftAlignedHeader = new Paragraph("A quien corresponda", new Font(baseFont, 11, Font.BOLD));
                    leftAlignedHeader.Add("\n\n");
                    leftAlignedHeader.Alignment = Element.ALIGN_LEFT;
                    doc.Add(leftAlignedHeader);

                    //Texto alineado a la izquierda
                    Paragraph leftAlignedContent1 = new Paragraph();
                    leftAlignedContent1.Add($"El que suscribe, {directorName} Director de la Facultad de Estadística e Informática, de la Universidad Veracruzana");
                    leftAlignedContent1.Add("\n\n");
                    doc.Add(leftAlignedContent1);

                    // Texto centrado y en negrita
                    Paragraph centeredTitle = new Paragraph($"HACE CONSTAR", new Font(baseFont, 11, Font.BOLD));
                    centeredTitle.Alignment = Element.ALIGN_CENTER;
                    doc.Add(centeredTitle);

                    Paragraph leftAlignedContent2 = new Paragraph();
                    leftAlignedContent2.Add($"que la <<Nombre del académico>>, participó en un proyecto de campo con las siguientes características:");
                    leftAlignedContent2.Add("\n\n");
                    doc.Add(leftAlignedContent2);



                    // Agregar tabla con encabezados
                    PdfPTable table = new PdfPTable(4);
                    table.WidthPercentage = 100; // Ancho de la tabla al 100% del ancho de la página

                    // Encabezados de la tabla
                    table.AddCell("Proyecto realizado");
                    table.AddCell("Duración");
                    table.AddCell("Lugar donde se desarrolló");
                    table.AddCell("Nombre de las y los alumnos involucrados");


                    //Datos
                    table.AddCell(proyectName);
                    table.AddCell(timeLapse);
                    table.AddCell(place);
                    table.AddCell(studentName);

                    doc.Add(table);


                    Paragraph leftAlignedContent3 = new Paragraph();
                    leftAlignedContent3.Add(new Chunk("Impacto obtenido: ", new Font(baseFont, 11, Font.BOLD)));
                    leftAlignedContent3.Add("\n\n");
                    doc.Add(leftAlignedContent3);

                    Paragraph leftAlignedContent4 = new Paragraph();
                    leftAlignedContent4.Add(result);
                    leftAlignedContent4.Add("\n\n\n\n");
                    doc.Add(leftAlignedContent4);


                    // Párrafo siguiente centrado
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

                    // Cerrar el documento
                    doc.Close();
                }
            }

            Console.WriteLine("Documento generado correctamente: " + outputPdfPath);
        }




        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

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
