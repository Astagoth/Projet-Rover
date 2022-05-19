using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.License;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace AppWifiBot_Controls
{
    public partial class IHMFicheIntervention : Form
    {

        string fileNameScreenShot = "ScreenCapture-" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".png";
        string fileNameToConvert;

        // path to the Desktop
        private string deskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // counter for number of snaps
        private int snapCount = 0;

        public IHMFicheIntervention()
        {
            InitializeComponent();

            textBoxDate2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;

            SaveControlImage();

            menuStrip1.Visible = true;

        }

        

        private void SaveControlImage()
        {
            int NameFileCount = snapCount;
            snapCount++;

            Bitmap bmp = new Bitmap(panelPDF.Width, panelPDF.Height);
            panelPDF.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
            bmp.Save(deskTopPath + @"/snap_" + snapCount.ToString() + @".bmp");
            string fileName = deskTopPath + @"/Fiche_" + "_" + NameFileCount.ToString();
            fileNameToConvert = deskTopPath + @"/snap_" + snapCount.ToString() + @".bmp";

            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            PdfSection section = doc.Sections.Add();
            PdfPageBase page = doc.Pages.Add();

            PdfImage image = PdfImage.FromFile(fileNameToConvert);

            float widthFitRate = image.PhysicalDimension.Width / page.Canvas.ClientSize.Width;
            float heightFitRate = image.PhysicalDimension.Height / page.Canvas.ClientSize.Height;
            float fitRate = Math.Max(widthFitRate, heightFitRate);
            float fitWidth = image.PhysicalDimension.Width / fitRate;
            float fitHeight = image.PhysicalDimension.Height / fitRate;
            page.Canvas.DrawImage(image, 0, 0, fitWidth, fitHeight);

            doc.SaveToFile(fileName + ".pdf");
            doc.Close();
            System.Diagnostics.Process.Start(fileName + ".pdf");

            File.Delete(fileNameToConvert);
        }

        private void retourAuMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            Close();
        }
    }
}
