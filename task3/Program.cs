using System;
using System.IO;
using System.Reflection;

namespace task3
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {
                var assembly = Assembly.Load("task2");
                var type = assembly.GetType("task2.Program+MyClass");
                dynamic myClassInstance = Activator.CreateInstance(type ?? throw new InvalidOperationException());
                if (myClassInstance != null) myClassInstance.GetHashCode();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}