
using System.Drawing.Printing;
using POSLayer.Library;

namespace POSWinFormLayer.Library;

public class PrintHandlerText
{
    private PrinterSettings pSettings;
    private PrintDocument pDocument;

    private string DocumentToPrint;

    private Font font; //must use a mono spaced font as the spaces need to line up
    private int fontHeight;
    private int startX;
    private int startY;

    private Brush brush;
    private Graphics g = null;
    private int max_numberOfCharacters = 40;
    private int reportwidthcm = 250;



    public PrintHandlerText(PosConfig config, string DocumentToPrint, string printerNetworkName)
    {
        this.DocumentToPrint = DocumentToPrint;

        float fontSize = config.ReportFontSize;
        string fontName = config.ReportFontName;

        startX = 10;
        startY = 5;

        this.font = new Font(fontName, fontSize, FontStyle.Bold);
        fontHeight = (int)font.GetHeight();
        brush = new SolidBrush(Color.Black);

        max_numberOfCharacters = config.GetFontMaximumCharacter(fontSize);
        reportwidthcm = 270;

        pSettings = new PrinterSettings();

        pDocument = new PrintDocument();
        pDocument.PrinterSettings = pSettings;
        pSettings.PrinterName = printerNetworkName;
        pDocument.PrintPage += pDocument_PrintPage;
    }

    public void PrintNow()
    {
        pDocument.Print();
    }

    public void Reset()
    {
        startY = 5;
    }

    void pDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
        if (e.PageSettings.PaperSize.Kind == PaperKind.A4)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters  
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(DocumentToPrint, font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);
           
            // Draws the string within the bounds of the page
            e.Graphics.DrawString(DocumentToPrint, font, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            DocumentToPrint = DocumentToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (DocumentToPrint.Length > 0);
        } else
        {
            e.Graphics.DrawString(DocumentToPrint, font, brush, new PointF(startX, startY));
        }
    }


}
