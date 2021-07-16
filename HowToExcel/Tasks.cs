using System.Collections.Generic;

namespace Practice
{
    public class Tasks
    {
        public string Task { set; get; }
        public int Volume { set; get; }
        public int Term { set; get; }
        public int Budget { set; get; }
        internal List<TypeOfWork> Works { set; get; }
    }
}
