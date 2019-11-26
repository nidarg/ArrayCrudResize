using System;

namespace ArrayCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sut = new IntArray();
            sut.Add(1);
            sut.Add(2);
            sut.Add(3);
            sut.Add(4);
            
            for(int i = 0; i < sut.Count(); i++)
            {
                Console.WriteLine(sut.Element(i));
            }
            Console.Read();
        }
    }
}
