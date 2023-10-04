using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Reporting;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Drawing.Imaging;

namespace Central.Reportes
{
    partial class Ticket : Form, IDisposable
    {


        public List<FacturaDet> Detalle = new List<FacturaDet>();
        public List<FacturaEnc> Encabezado = new List<FacturaEnc>();
        public int total;
        int tama;

        //objetos para la creacion de streaming

        private int m_currentPageIndex;
        private IList<Stream> m_streams;


        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            LocalReport rp = new LocalReport();
           /* rp.ReportPath = @"..\..\Reportes\Ticket.rldc";
             rp.ReportEmbeddedResource = "Central.Reportes.Ticket.rdlc";
             RpwTicket.LocalReport .ReportPath = @"..\..\Reportes\Ticket.rldc";
            RpwTicket.LocalReport.ReportEmbeddedResource= "Central.Reportes.Ticket.rdlc";
           
            foreach (var dto in Detalle)
            {
                MessageBox.Show("Precio: " + dto.pre.ToString() + "\nSubtotal: " + dto.subt.ToString ());

            }*/
            RpwTicket.LocalReport.DataSources.Clear();
            RpwTicket.LocalReport.DataSources.Add(new ReportDataSource("Titulo", Encabezado));
            RpwTicket.LocalReport.DataSources.Add(new ReportDataSource("Detalle", Detalle));
            RpwTicket.SetDisplayMode(DisplayMode.PrintLayout);
            RpwTicket.ZoomMode = ZoomMode.Percent;
            RpwTicket.RefreshReport();
            PageSettings ps = new PageSettings();
            tama = 300 * total / 10;
            tama += 250;
            tama = 354;
            ps.PaperSize = new PaperSize("Custom", 312, tama);
            ps.PaperSize.Height = tama;
            ps.Margins.Bottom = 0;
            ps.Margins.Left = 0;
            ps.Margins.Top = 0;
            ps.Margins.Right = 0;
            ps.PaperSize.RawKind = (int)PaperKind.Custom;
            this.RpwTicket.SetPageSettings(ps);
            this.RpwTicket.RefreshReport();
            impirmir(RpwTicket.LocalReport);
        }

        private void impirmir(LocalReport rep)
        {
            exportar(rep);
            print();

        }

        private void exportar(LocalReport rep)
        {
            string deviceinfo = "" +
              "<DeviceInfo>" +
              " <OutputFormat>EMF</OutputFormat>" +
              " <PageWidth>" + 3.12 + "in</PageWidth>" +
              " <PageHeight>" + 3.24 + "in</PageHeight>" +
              " <MarginTop>0.01in</MarginTop>" +
              " <MarginLeft>0.01in</MarginLeft>" +
              " <MarginRight>0.1in</MarginRight>" +
              " <MarginBottom>0.1in</MarginBottom>" +
              "</DeviceInfo>";
            Warning[] Warninigs;
            m_streams = new List<Stream>();
            rep.Render("Image", deviceinfo, CreateStream, out Warninigs);
            foreach (Stream stream in m_streams)
            { stream.Position = 0; }

        }

        private Stream CreateStream(string name, string FileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        private void print()
        {
            PrintDocument printdoc;
            string printname = ImpresoraPred();
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no hay datos que imprimir");
            printdoc = new PrintDocument();
            printdoc.PrinterSettings.PrinterName = printname;

            if (!printdoc.PrinterSettings.IsValid)
            {
                throw new Exception(String.Format("No se puede encontrar la impresora \"{0}\".", printname));

            }
            else
            {
                printdoc.PrintPage += new PrintPageEventHandler(printpage);
                m_currentPageIndex = 0;

                printdoc.Print();
            }
        }

        private void printpage(object sender, PrintPageEventArgs ev)
        {
            Metafile PageImage = new Metafile(m_streams[m_currentPageIndex]);
            Rectangle adjustRectangle = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                312,
                tama);
            ev.Graphics.FillRectangle(Brushes.White, adjustRectangle);
            ev.Graphics.DrawImage(PageImage, adjustRectangle);
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);

        }

        private string ImpresoraPred()
        {
           for (Int32 i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                PrinterSettings a = new PrinterSettings();
                a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                if (a.IsDefaultPrinter)
                { return PrinterSettings.InstalledPrinters[i].ToString(); }

            }
            return "";
        }

        public void Dispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }


    }
}
