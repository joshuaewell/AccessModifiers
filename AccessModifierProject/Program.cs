using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AccessModifierProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var publicMethodsOfA = Assembly.GetAssembly(typeof(AssemblyAClass1))
                .GetType("AccessModifierProject.AssemblyAClass1")
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);

            Console.WriteLine("Public Methods:");
            PrintMethodsToConsole(publicMethodsOfA);

            var nonPublicMethodsOfA = Assembly.GetAssembly(typeof(AssemblyAClass1))
                .GetType("AccessModifierProject.AssemblyAClass1")
                .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);

            Console.WriteLine("NonPublic Methods:");
            PrintMethodsToConsole(nonPublicMethodsOfA);
               
            Console.ReadLine();
        }

        public static void PrintMethodsToConsole(MethodInfo[] methods)
        {
            if (methods.Length > 0)
            {
                foreach (var m in methods)
                {
                    Console.WriteLine($"    {m.Name}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
