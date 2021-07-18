using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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


            List<Contracter> ListContr = new List<Contracter>();
            List<Tasks> ListTask = new List<Tasks>();

            ListContr.AddRange(reportData.Contracter);
            ListTask.AddRange(reportData.Data);

            ////Выведем информацию о списке исполнителей
            Console.WriteLine("List of ListItems\n");
            foreach (var item in ListContr)
                if (item != null)
                    Console.WriteLine("Contractor: {0}    \tRate Per Hour: {1}     \tAvailabality: {2}", item.Name, item.RatePerHour, item.Availabality);

            //Выведем информацию о списке задач
            Console.WriteLine("\n\nList of Tasks\n");
            foreach (var item in ListTask)
                if (item != null)
                    Console.WriteLine("Task: {0,-30}       Volume: {1,-5}      \tTerm: {2}      \tBudget: {3,3}", item.Task, item.Volume, item.Term, item.Budget);


            Contracter contr = new Contracter();
            List<TypeOfWork> works = new List<TypeOfWork>();

            ListTask = ListTask.OrderBy(x => x.Volume).ToList();
            ListContr = ListContr.OrderBy(x => x.Availabality).ToList();

            Console.WriteLine("\nDistribution of tasks to performers: \n");
            for (int i = 0; i < ListTask.Count; i++)
            {
                    works.Add(new TypeOfWork() {Competence = ListContr[i].Name });
                Console.WriteLine("Task: {0,-30}       Contracter: {1,-5}       \tWorking days: {2}      \tExpenses(from budget): {3,3} / {4,4}", ListTask[i].Task, works[i].Competence, string.Format("{0:0.00}", ListTask[i].Volume / ListContr[i].Availabality), string.Format("{0:0.00}", ListTask[i].Volume * ListContr[i].RatePerHour), ListTask[i].Budget);
            }
            Console.ReadLine();
        }
    }
}
