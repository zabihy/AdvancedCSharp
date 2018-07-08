using System;

namespace PropertyAccessorByILGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("ali", 1);

            var type = typeof(Student);

            Console.WriteLine($"{type.GetPropertyByAccessor("Id", s)}:{type.GetPropertyByAccessor("Name", s)}");

            Console.ReadKey();
        }
    }
}
