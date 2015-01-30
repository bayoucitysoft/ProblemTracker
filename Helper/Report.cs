using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ProblemTracker.Models;

namespace ProblemTracker.Helper
{
    public class Report
    {
        public string basePath = @"C:\";
        private List<Models.Entry> entries;
        public double totalHours = 0;

        public Report()
        {

        }

        public Report(List<Models.Entry> EntryCollection)
        {
            entries = EntryCollection;
            Document _doc = InitializeDocument();
            _doc.Open();
            _doc.Add(AddHeader());
            _doc.Add(AddMessage());
            _doc.Add(AddTitle());
            _doc.Add(AddHeaderTable());
            _doc.Add(Newline());
            _doc.Add(ActivityTable());
            _doc.Add(Newline());
            _doc.Add(CommentTable());
            _doc.Add(Newline());
            _doc.Add(Acknowledgment());
            _doc.Close();
        }

    

        private Document InitializeDocument()
        {
            string dateFormat = DateTime.Now.Year.ToString();
            if (DateTime.Now.Month < 10)
                dateFormat += "_0" + DateTime.Now.Month.ToString();
            else
                dateFormat += "_" + DateTime.Now.Month.ToString();
            if (DateTime.Now.Day < 10)
                dateFormat += "_0" + DateTime.Now.Day.ToString();
            else
                dateFormat += "_" + DateTime.Now.Day.ToString();

            FileStream fs = new FileStream(basePath + dateFormat + "_IAR.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Rectangle rec = new Rectangle(PageSize.LETTER);
            Document doc = new Document(rec);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            return doc;
        }

        private Paragraph AddHeader()
        {
           
            Paragraph paragraph = new Paragraph();
            
            var logo = Image.GetInstance(@"C:\vsprojects\zPet\ProblemTracker\ProblemTracker\Media\Images\EnscoLogo.png");
            logo.ScalePercent(35f);
            logo.SetAbsolutePosition(0, -75);
            Chunk chnkLogo = new Chunk(logo, 0, 0);
            Phrase _logo = new Phrase(chnkLogo);
            paragraph.Add(_logo);
            return paragraph;
        }

        private Paragraph AddMessage()
        {
            Paragraph paragraph = new Paragraph();
            Chunk message = new Chunk("CONFIDENTIAL", FontFactory.GetFont("Calibri"));
            message.Font.SetColor(0, 166, 255);
            message.Font.Size = 6;
            Phrase _message = new Phrase(message);
            paragraph.Add(_message);
            paragraph.Alignment = Element.ALIGN_RIGHT;
            return paragraph;
        }

        private Paragraph AddTitle()
        {
            Paragraph paragraph = new Paragraph();
            
            Chunk space = new Chunk(Environment.NewLine);
            Chunk title = new Chunk("Individual Activity Report", FontFactory.GetFont("Calibri"));
            paragraph.Add(space);
            paragraph.Add(title);
            paragraph.Add(space);
            paragraph.Add(space);
            paragraph.Alignment = Element.ALIGN_CENTER;
            return paragraph;
        }

        private PdfPTable AddHeaderTable()
        {
            Paragraph paragraph = new Paragraph();
            PdfPTable table = new PdfPTable(4);
            table.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(GenerateGreyCell(@"Company/Department"));
            table.AddCell(GenerateWhiteCell(@"Dimension Technology Solutions"));
            table.AddCell(GenerateGreyCell(@"Project Name"));
            table.AddCell(GenerateWhiteCell(@"EAM Project"));
            table.AddCell(GenerateGreyCell(@"Name"));
            table.AddCell(GenerateWhiteCell(@"Caleb Williams"));
            table.AddCell(GenerateGreyCell(@"Project Manager"));
            table.AddCell(GenerateWhiteCell(@"Exie Tonsall"));
            table.AddCell(GenerateGreyCell(@"Role"));
            table.AddCell(GenerateWhiteCell(@"Developer"));
            table.AddCell(GenerateGreyCell(@"Effort / Phase"));
            table.AddCell(GenerateWhiteCell(@"Development/Support"));
            table.AddCell(GenerateGreyCell(@"Reporting Period"));
            table.AddCell(GenerateWhiteCell(DateTime.Now.Month.ToString() + @"/" + DateTime.Now.Year.ToString()));
            table.AddCell(GenerateGreyCell(@"Report Date"));
            table.AddCell(GenerateWhiteCell(DateTime.Now.ToShortDateString()));
            return table;
        }

        private PdfPTable ActivityTable()
        {
            PdfPTable table = new PdfPTable(4);
            //headers
            table.AddCell(GenerateGreyCell(@"Work Product/Deliverable"));
            table.AddCell(GenerateGreyCell(@"Date"));
            table.AddCell(GenerateGreyCell(@"Activity Description"));
            table.AddCell(GenerateGreyCell(@"Time(Hours)"));
            //now we need to start making content for these dynamically
            for (int i = 0; i < entries.Count; i++ )
            {
                //need to change model to incorporate some type value that can fill the work Product / deliverable 
                //will probably have to change backend schema too 
                //for now the header will do, I guess 
                if (entries[i].Header.ToLower() != "end")
                {
                    double taskHours = GenerateTaskHours(entries[i], i);

                    table.AddCell(GenerateWhiteCell(entries[i].Header));
                    table.AddCell(GenerateWhiteCell(DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString()));
                    table.AddCell(GenerateWhiteCell(entries[i].Comment));
                    table.AddCell(GenerateWhiteCell(taskHours.ToString()));
                }
                else
                    entries.RemoveAt(i);
            }
            
            table.AddCell(GenerateWhiteCell(string.Empty));
            table.AddCell(GenerateWhiteCell(string.Empty));
            table.AddCell(GenerateWhiteCell("Total Time:", true));
            table.AddCell(GenerateWhiteCell(totalHours.ToString(), true));
            table.AddCell(GenerateWhiteCell(string.Empty));
            table.AddCell(GenerateWhiteCell(string.Empty));
            table.AddCell(GenerateWhiteCell("Non Project Time:", true));
            table.AddCell(GenerateWhiteCell("0", true));
            table.AddCell(GenerateWhiteCell(string.Empty));
            table.AddCell(GenerateWhiteCell(string.Empty));
            table.AddCell(GenerateWhiteCell("Project Time:", true));
            table.AddCell(GenerateWhiteCell(totalHours.ToString(), true));
            return table;
        }

  

        private PdfPTable CommentTable()
        {
            PdfPTable table = new PdfPTable(1);
            table.AddCell(GenerateGreyCell(@"Comments"));
            table.AddCell(GenerateWhiteCell(Environment.NewLine));
            table.AddCell(GenerateWhiteCell(Environment.NewLine));
            table.AddCell(GenerateWhiteCell(Environment.NewLine));

            return table;
        }

        private double GenerateTaskHours(Models.Entry entry, int iterator)
        {
            double hours = 0;
            Entry end = new Entry();

            if (entries.Count() -1 <= iterator)
                end.DateCompleted = DateTime.Now;
            else
                end = entries[iterator + 1];
                

            TimeSpan diff = end.DateCompleted.Subtract(entry.DateCompleted);
            hours = Math.Round(diff.TotalHours, MidpointRounding.AwayFromZero);
            totalHours += hours;
            return Math.Round(hours, MidpointRounding.AwayFromZero);
        }

        private PdfPTable Acknowledgment()
        {
            PdfPTable table = new PdfPTable(6);
            PdfPCell header = GenerateGreyCell("Project Manager Acknowledgement");
            header.Colspan = 6;
            table.AddCell(header);
            table.AddCell(GenerateWhiteCell(string.Empty, 2));
            table.AddCell(GenerateWhiteCell("Project", 2));
            table.AddCell(GenerateWhiteCell("Category", 2));
            table.AddCell(GenerateWhiteCell(string.Empty, 3));
            table.AddCell(GenerateWhiteCell("Hours"));
            table.AddCell(GenerateWhiteCell("Capital"));
            table.AddCell(GenerateWhiteCell("Expense"));
            table.AddCell(GenerateWhiteCell(string.Empty, 3));
            table.AddCell(GenerateWhiteCell(string.Empty));
            table.AddCell(GenerateWhiteCell(string.Empty));
            table.AddCell(GenerateWhiteCell(string.Empty));
            table.AddCell(GenerateWhiteCell(string.Empty, 6));
            table.AddCell(GenerateWhiteCell("Reviewed By", 3));
            table.AddCell(GenerateWhiteCell("Date", 3));
            table.AddCell(GenerateWhiteCell(Environment.NewLine, 3));
            table.AddCell(GenerateWhiteCell(Environment.NewLine, 3));

            return table;
        }

        private Paragraph Newline()
        {
            return new Paragraph(Environment.NewLine);
        }

        private PdfPCell GenerateGreyCell(string content)
        {
            Chunk _content = new Chunk(content);
            _content.Font.Size = 6;
            Phrase phrase = new Phrase(_content);
            PdfPCell cell = new PdfPCell(phrase);
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            return cell;

        }

        private PdfPCell GenerateWhiteCell(string content)
        {
            Chunk _content = new Chunk(content);
            _content.Font.Size = 6;
            Phrase phrase = new Phrase(_content);
            PdfPCell cell = new PdfPCell(phrase);
            cell.BackgroundColor = BaseColor.WHITE;
            return cell;
        }

        private PdfPCell GenerateWhiteCell(string content, bool bold)
        {
            Chunk _content = new Chunk(content);
            _content.Font.Size = 6.2f;
            _content.Font.SetStyle("bold");
            Phrase phrase = new Phrase(_content);       
            PdfPCell cell = new PdfPCell(phrase);
            cell.BackgroundColor = BaseColor.WHITE;
            return cell;
        }



        private PdfPCell GenerateWhiteCell(string content, int colSpan)
        {
            Chunk _content = new Chunk(content);
            _content.Font.Size = 6.2f;
            _content.Font.SetStyle("bold");
            Phrase phrase = new Phrase(_content);
            PdfPCell cell = new PdfPCell(phrase);
            cell.Colspan = colSpan;
            cell.BackgroundColor = BaseColor.WHITE;
            return cell;   
        }
    }
}
