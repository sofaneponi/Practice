namespace Practice
{
    public class Dataset
    {
        public Contracter[] Contracter { set; get; }
        public Tasks[] Data { set; get; }
        public Dataset GetReport()
        {
            return new Dataset
            {
                Data = new []
                {
                    new Tasks{ Task = "Stroke", Volume = 10, Term = 2, Budget = 300},
                    new Tasks{ Task = "Feed", Volume = 6, Term = 2, Budget = 200},
                    new Tasks{ Task = "Take a walk", Volume = 30, Term = 4, Budget = 2000},
                    new Tasks{ Task = "Combing", Volume = 10, Term = 2, Budget = 400},
                    new Tasks{ Task = "To wash", Volume = 30, Term = 5, Budget = 1700},
                    new Tasks{ Task = "Cut the cat", Volume = 20, Term = 5, Budget = 1000},
                    new Tasks{ Task = "Make friends with other pets", Volume = 20, Term = 2, Budget = 1200},
                    new Tasks{ Task = "Teach the team giva a paw", Volume = 15, Term = 4, Budget = 600},
                    new Tasks{ Task = "Teach the team sit", Volume = 10, Term = 3, Budget = 400},
                    new Tasks{ Task = "Teach the team wait", Volume = 10, Term = 4, Budget = 300},
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