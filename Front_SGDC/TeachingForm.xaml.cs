using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Paragraph = iTextSharp.text.Paragraph;

namespace Front_SGDC
{
    /// <summary>
    /// Lógica de interacción para TeachingForm.xaml
    /// </summary>
    public partial class TeachingForm : Page
    {
        public TeachingForm()
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
            string acciones = tbxAcciones.Text;
            string bloque = tbxBloque.Text;
            string creditos = tbxCreditos.Text;
            string experecienciaE = tbxEE.Text;
            string programaE = tbxProgramaE.Text;
            string hora = tbxHora.Text;
            string mes = tbxMes.Text;
            string periodoE = tbxPeriodoEscolar.Text;
            string seccion = tbxSeccion.Text;
            string semana = tbxSemana.Text;



            //nombre constancia
            string outputPdfPath = "D:/Documents/administracionProyectos/Constancias/modificadoImparticion.pdf";

            //pdf
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
                    leftAlignedContent2.Add("que el Mtro. <<Nombre del profesor>, impartió la siguiente experiencia educativa en el periodo " + periodoE);
                    leftAlignedContent2.Add("\n\n");
                    doc.Add(leftAlignedContent2);

                    //tabla
                    PdfPTable table = new PdfPTable(4); // 4 columnas
                    table.WidthPercentage = 100;

                    // Encabezados de la tabla
                    table.AddCell("Programa educativo");
                    table.AddCell("Experiencia educativa");
                    table.AddCell("Bloque/Sección/Créditos");
                    table.AddCell("H/S/M");

                    //datos de la tabla
                    table.AddCell(programaE);
                    table.AddCell(experecienciaE);
                    table.AddCell(bloque + "/" + seccion + "/" + creditos);
                    table.AddCell(hora + "/" + semana + "/" + mes);

                    //agregar tabla
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

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
