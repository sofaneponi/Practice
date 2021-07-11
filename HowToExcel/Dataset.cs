using System;

namespace Practice
{
    public class Dataset
    {
        public DataClass GetReport()
        {
            return new DataClass
            {
                Data = new []
                {
                    new DataItem{ Task = "Stroke", Volume = 10, Term = 2, Budget = 20},
                    new DataItem{ Task = "Feed", Volume = 6, Term = 2, Budget = 40},
                    new DataItem{ Task = "Take a walk", Volume = 30, Term = 4, Budget = 20},
                    new DataItem{ Task = "Combing", Volume = 10, Term = 1, Budget = 20},
                    new DataItem{ Task = "To wash", Volume = 30, Term = 5, Budget = 40},
                    new DataItem{ Task = "Cut the cat", Volume = 20, Term = 5, Budget = 20},
                    new DataItem{ Task = "Make friends with other pets", Volume = 20, Term = 2, Budget = 50},
                    new DataItem{ Task = "Teach the team giva a paw", Volume = 15, Term = 4, Budget = 40},
                    new DataItem{ Task = "Teach the team sit", Volume = 10, Term = 3, Budget = 30},
                    new DataItem{ Task = "Teach the team wait", Volume = 10, Term = 4, Budget = 30},
                },
                Contracter = new[]
                {
                    new Contracter{ Name = "Simon", RatePerHour = 50, Availabality = 8},
                    new Contracter{ Name = "Anna", RatePerHour = 20, Availabality = 5},
                    new Contracter{ Name = "Jake", RatePerHour = 60, Availabality = 9},
                    new Contracter{ Name = "Fin", RatePerHour = 50, Availabality = 7},
                    new Contracter{ Name = "Vanessa", RatePerHour = 30, Availabality = 5},
                    new Contracter{ Name = "George", RatePerHour = 55, Availabality = 9},
                    new Contracter{ Name = "Peter", RatePerHour = 40, Availabality = 5},
                    new Contracter{ Name = "Olga", RatePerHour = 40, Availabality = 5},
                    new Contracter{ Name = "Sabrina", RatePerHour = 30, Availabality = 5},
                    new Contracter{ Name = "Stacy", RatePerHour = 35, Availabality = 5},
                }
            };
        }
    }
}