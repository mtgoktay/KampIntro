using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary   
{
    class MyDictionary<Key,Value>
    {
        Key[] numbers;
        Key[] tempNumbers;
        Value[] names;
        Value[] tempNames;

        public MyDictionary()
        {
            numbers = new Key[0];
            names = new Value[0];           
        }
        public void Add (Key key, Value value)
        {
            tempNumbers = numbers;
            tempNames = names;

            numbers = new Key[numbers.Length+1];
            names = new Value[names.Length+1];

            for (int i = 0; i < tempNumbers.Length; i++)
            {
                numbers [i] = tempNumbers[i];
                names[i] = tempNames[i];
            }

            numbers[numbers.Length - 1] = key;
            names[names.Length - 1] = value;
                    
            
        }


        public void GetAll()
        {
            for (int i = 0; i < numbers.Length; i++)     
            {
                Console.WriteLine(numbers[i] + " " + " Numaralı " + names[i] + " Eklendi");

            }

        }
    }
}
