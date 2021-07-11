using System;

namespace Practice
{
    public class Dataset
    {
        public DataClass GetReport()
        {
            return new DataClass
            {
                History = new []
                {
                    new DataItem{ Task = "Stroke", Volume = 1, Term = 2, Budget = 2},
                    new DataItem{ Task = "Feed", Volume = 2, Term = 2, Budget = 4},
                    new DataItem{ Task = "Take a walk", Volume = 3, Term = 4, Budget = 2},
                    new DataItem{ Task = "Combing", Volume = 1, Term = 1, Budget = 2},
                    new DataItem{ Task = "To wash", Volume = 3, Term = 5, Budget = 4},
                    new DataItem{ Task = "Cut the cat", Volume = 2, Term = 5, Budget = 2},
                    new DataItem{ Task = "Make friends with other pets", Volume = 4, Term = 2, Budget = 5},
                    new DataItem{ Task = "Teach the team giva a paw", Volume = 3, Term = 4, Budget = 4},
                    new DataItem{ Task = "Teach the team sit", Volume = 2, Term = 3, Budget = 3},
                    new DataItem{ Task = "Teach the team wait", Volume = 2, Term = 4, Budget = 3},
                }
            };
        }
    }
}