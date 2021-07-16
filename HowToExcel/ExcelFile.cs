using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;

namespace Practice
{
    public class ExcelFile
    {
        public byte[] Generate(Dataset report)
        {
            var package = new ExcelPackage();

            var sheet = package.Workbook.Worksheets
                .Add("Page 1");

            sheet.Cells[1, 1, 10, 10].LoadFromArrays(new object[][]{ new []{"Task", "Volume", "Term", "Budget"} });
            sheet.Cells[1, 7, 8, 8].LoadFromArrays(new object[][] { new[] { "Contracter", "Rate Per Hour", "Availability" } });
            var row = 2;
            var column = 1;
            foreach (var item in report.Data)
            {
                sheet.Cells[row, column].Value = item.Task;
                sheet.Cells[row, column + 1].Value = item.Volume;
                sheet.Cells[row, column + 2].Value = item.Term;
                sheet.Cells[row, column + 3].Value = item.Budget;
                row++;
            }
            row = 2;
            foreach (var item in report.Contracter)
            {
                sheet.Cells[row, column + 6].Value = item.Name;
                sheet.Cells[row, column + 7].Value = item.RatePerHour;
                sheet.Cells[row, column + 8].Value = item.Availabality;
                row++;
            }

            sheet.Column(1).Width = 23;
            sheet.Column(2).Width = 10;
            sheet.Column(3).Width = 10;
            sheet.Column(4).Width = 10;
            sheet.Column(7).Width = 20;
            sheet.Column(8).Width = 20;
            sheet.Column(8).Width = 12;

            sheet.Protection.IsProtected = true;
            return package.GetAsByteArray();
        }
    }
}