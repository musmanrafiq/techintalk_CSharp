using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Core;
using UglyToad.PdfPig.Fonts.Standard14Fonts;
using UglyToad.PdfPig.Writer;

namespace ConsoleApp.PdfPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadPdf();
        }
        
        public static void ReadPdf() {
            // open the pdf we want to read
            using PdfDocument document = PdfDocument.Open(@"newPdf.pdf");
            // get single page
            Page singlePage = document.GetPage(1);
            // print the text
            Console.WriteLine(singlePage.Text);

            // loop through the pages
            foreach (Page page in document.GetPages())
            {

                Console.WriteLine($"The page no. {page.Number}");
                Console.WriteLine($"The page has total {page.GetImages().Count()} images");
                Console.WriteLine($"The page has total {page.GetWords().Count()} words");
            }
        }
        public static void WritePdf()
        {
            PdfDocumentBuilder builder = new();
            // Fonts must be registered with the document builder prior to use to prevent duplication.
            PdfDocumentBuilder.AddedFont font = builder.AddStandard14Font(Standard14Font.TimesRoman);

            PdfPageBuilder page = builder.AddPage(PageSize.A4);     
            page.AddText("Hello World!", 12, new PdfPoint(25, 830), font);
            
            PdfPageBuilder page2 = builder.AddPage(PageSize.A4);
            page2.AddPng(File.ReadAllBytes("apple.png"), new PdfRectangle(10,200,300,700));

            byte[] documentBytes = builder.Build();
            File.WriteAllBytes(@"newPdf.pdf", documentBytes);
        }
    }
}