using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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

namespace Front_SGDC
{
    /// <summary>
    /// Lógica de interacción para PladeaForm.xaml
    /// </summary>
    public partial class PladeaForm : Page
    {
        public PladeaForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            crearConstancia();
        }

        private void crearConstancia()
        {
            string directorName = "Carlos Alberto Ochoa Rivera";
            string acciones = tbxAcciones.Text;
            string eje = tbxEje.Text;
            string objetivo = tbxGeneralObj.Text;
            string meta = tbxMeta.Text;
            string programa = tbxPrograma.Text;

            //Nombre del archivo
            string outputPdfPath = "D:/Documents/administracionProyectos/Constancias/modificadoPladea.pdf";

            //Crear el documento

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
                    leftAlignedHeader1.Add("Presente");
                    doc.Add(leftAlignedHeader1);

                    //Texto a la izquierda
                    Paragraph leftAlignedContent = new Paragraph();
                    leftAlignedContent.Add("El que suscribe, Director de la Facultad de Estadística e Informática de la Universidad Veracruzana");
                    leftAlignedContent.Add("\n");
                    doc.Add(leftAlignedContent);

                    // Texto centrado y en negrita
                    Paragraph centeredTitle = new Paragraph($"HACE CONSTAR", new Font(baseFont, 11, Font.BOLD));
                    centeredTitle.Alignment = Element.ALIGN_CENTER;
                    doc.Add(centeredTitle);

                    Paragraph leftAlignedContent2 = new Paragraph();
                    leftAlignedContent2.Add("Que la Mtra. (nombre y apellidos), Profesora adscrita a esta Facultad a mí cargo contribuyó a la consecución de las siguientes metas del Plan de Desarrollo de la Entidad Académica (PlaDEA) 2017-2021:");
                    leftAlignedContent2.Add("\n");
                    doc.Add(leftAlignedContent2);
                    leftAlignedContent2.Add("\n\n");
                    Paragraph leftAlignedContent4 = new Paragraph();
                    leftAlignedContent4.Add(new Chunk($"Eje estratégico: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)));
                    leftAlignedContent4.Add(eje + "\n");
                    leftAlignedContent4.Add(new Chunk($"Programa estratégico: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)));
                    leftAlignedContent4.Add(programa + "\n");
                    leftAlignedContent4.Add(new Chunk($"Objetivos generales: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)));
                    leftAlignedContent4.Add(objetivo + "\n");
                    leftAlignedContent4.Add(new Chunk($"Acciones: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)));
                    leftAlignedContent4.Add(acciones + "\n");
                    leftAlignedContent4.Add(new Chunk($"Metas: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)));
                    leftAlignedContent4.Add(meta + "\n\n\n");
                    doc.Add(leftAlignedContent4);

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