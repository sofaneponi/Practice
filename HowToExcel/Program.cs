using System;
using System.Collections.Generic;
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


            List<Contracter> ListCont = new List<Contracter>();
            List<DataItem> ListTask = new List<DataItem>();

            ListCont.AddRange(reportData.Contracter);
            ListTask.AddRange(reportData.Data);

            Console.WriteLine("List of Contractors\n");
            foreach (var item in ListCont)
                if (item != null)
                    Console.WriteLine("Contractor: {0}    \tRate Per Hour: {1}     \tAvailabality: {2}", item.Name, item.RatePerHour, item.Availabality);

            Console.WriteLine("\n\nList of Tasks\n");
            foreach (var item in ListTask)
                if (item != null)
                    Console.WriteLine("Task: {0,-30}       Volume: {1,-5}      \tTerm: {2}      \tBudget: {3,3}", item.Task, item.Volume, item.Term, item.Budget);

            Console.ReadLine();
        }
    }
}
