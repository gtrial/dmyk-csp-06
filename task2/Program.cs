using System;
using System.Reflection;

namespace task2
{
    internal static class Program
    {
        private class MyClass
        {
            
        }
        private static void Main()
        {
            var assembly = Assembly.Load("task2");
            //Создайте свою пользовательскую сборку по примеру сборки CarLibrary из урока, сборка будет использоваться для работы с конвертером температуры.
            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine(type);
            }

            foreach (var memberInfo in assembly.GetType("task2.Program+MyClass")?.GetMembers())
            {
                Console.WriteLine(memberInfo);
            }

            foreach (var parameterInfo in assembly.GetType("task2.Program+MyClass").GetMethod("GetHashCode").GetParameters())
            {
                Console.WriteLine(parameterInfo.Name);
            }
        }
    }
}