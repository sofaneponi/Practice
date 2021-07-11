using System;
namespace Practice
{
    public class DataClass
    {
        public Contracter[] Contracter { set; get; }
        public DataItem[] Data { set; get; }
    }
    
    public class Contracter
    {
        public string Name { set; get; }
        public int RatePerHour { set; get; }
        public int Availabality { set; get; }
    }
    
    public class DataItem
    {
        public string Task { set; get; }
        public int Volume { set; get; }
        public int Term { set; get; }
        public int Budget { set; get; }
    }
}