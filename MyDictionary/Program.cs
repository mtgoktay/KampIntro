using System;

namespace MyDictionary
{
    class Program
    {
        public 
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1,"Mehmet GÖKTAY");
            myDictionary.Add(2, "Engin Demiroğ");
            myDictionary.Add(3, "Ali Sunal");

            myDictionary.GetAll();
        }
    }
}
