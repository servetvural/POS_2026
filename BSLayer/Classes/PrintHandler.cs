using System.Drawing.Printing;
using System.Drawing;

namespace DTRMNS {
    public class PrintHandler {
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
        


        public PrintHandler(DTRMSimpleBusiness bslayer, string DocumentToPrint, string printerNetworkName) {

            this.DocumentToPrint = DocumentToPrint;

            float fontSize = bslayer.config.ReportFontSize;
            string fontName = bslayer.config.ReportFontName;

            startX = 10;
            startY = 5;

            this.font = new Font(fontName, fontSize, FontStyle.Bold);
            fontHeight = (int)font.GetHeight();
            brush = new SolidBrush(Color.Black);

            max_numberOfCharacters = bslayer.config.GetFontMaximumCharacter(fontSize) ;
            reportwidthcm = 270;

            pSettings = new PrinterSettings();
            
            pDocument = new PrintDocument();
            pDocument.PrinterSettings = pSettings;
            pSettings.PrinterName = printerNetworkName;
            pDocument.PrintPage += pDocument_PrintPage;
            //pDocument.Print();
        }

        public void PrintNow() {
            pDocument.Print();
        }


        public void Reset() {
            startY = 5;
        }

        void pDocument_PrintPage(object sender, PrintPageEventArgs e) {
            if (e.PageSettings.PaperSize.Kind == PaperKind.A4) {

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
            } else {
                 e.Graphics.DrawString(DocumentToPrint, font, brush, new PointF(startX, startY));
            }
        }
            
       
        //private void DrawText(string line) {
        //    g.DrawString(line, font, brush, startX, startY);
        //    startY += fontHeight;
        //}

        //private void DrawLine() {
        //    // DrawText(new string('-',numberOfCharacters));

        //    startY += 5;
        //    g.DrawLine(Pens.Black, new Point(startX, startY), new Point(startX + reportwidthcm, startY));
        //    startY += 5;
        //}

        //private void DrawDoubleLine() {
        //    //DrawText(new string('=', numberOfCharacters));

        //    startY += 5;
        //    g.DrawLine(Pens.Black, new Point(startX, startY), new Point(startX + reportwidthcm, startY));
        //    startY += 2;
        //    g.DrawLine(Pens.Black, new Point(startX, startY), new Point(startX + reportwidthcm, startY));
        //    startY += 5;

        //}

        //private void NewLine() {
        //    startY += fontHeight;
        //}

        

        //private string centeredString(string s) {
        //    if (s.Length >= max_numberOfCharacters) {
        //        return s.Substring(0, max_numberOfCharacters - 1);
        //    }

        //    int leftPadding = (max_numberOfCharacters - s.Length) / 2;
        //    int rightPadding = max_numberOfCharacters - s.Length - leftPadding;

        //    return new string(' ', leftPadding) + s + new string(' ', rightPadding);
        //}


        //private float MeasureStringMin(string str) {
        //    return g.MeasureString(str, font).Width;
        //}
        //private float GetReceiptWidth() {
        //    return g.MeasureString(new string('A', max_numberOfCharacters), font).Width;
        //}                
    }
}

