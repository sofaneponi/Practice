using System.IO;

namespace Practice
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var reportData = new Dataset()
                .GetReport();
            var reportExcel = new ExcelFile()
                .Generate(reportData);
            
            File.WriteAllBytes("Data.xlsx", reportExcel);
        }
    }
}
