using System;

namespace Indexer
{
    #region Theory 
    /// <summary>
    /// What?
    /// ==> C# indexers are usually known as smart arrays. A C# indexer is a class property that allows you to access a member variable of a class or struct using the features of an array. In C#, indexers are created using this keyword. Indexers in C# are applicable on both classes and structs.
    /// 
    /// Why?
    /// ==> Indexers resemble properties except that their accessors take parameters.Indexer can be used as an array to access various object values.
    /// 
    /// How?
    /// ==> Defining an indexer allows you to create a class like that can allows its items to be accessed an array.Instances of that class can be accessed using the [] array access operator
    /// 
    /// 
    /// </summary>
    #endregion

    #region Implementation
    class Program
    {
        static void Main(string[] args)
        {
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello, World";
            Console.WriteLine(stringCollection[0]);

            var stringCollectionX = new SampleCollectionX<string>();
            stringCollectionX.Add("Hello, World");
            System.Console.WriteLine(stringCollection[0]);


            var obj = new SampleCollection<Student>();
            obj[0].Id = 173015026;
            obj[0].Name = "Rafiul Islam";

            obj[1].Id = 173015035;
            obj[1].Name = "Naymul Haque";

            System.Console.WriteLine(obj[0]);
        }
    }

    class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    class SampleCollectionX<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];
        int nextIndex = 0;

        // Define the indexer to allow client code to use [] notation.
        public T this[int i] => arr[i];

        public void Add(T value)
        {
            if (nextIndex >= arr.Length)
                throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
            arr[nextIndex++] = value;
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    

    #endregion
}
