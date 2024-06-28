using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            foreach (var emp in LinqTasks.Task1())
            {
                Console.WriteLine(emp.ToString());
            }

            Console.WriteLine("\nTask2");
            foreach (var emp in LinqTasks.Task2())
            {
                Console.WriteLine(emp.ToString());
            }

            Console.WriteLine("\nTask3");
            Console.WriteLine($"Max Salary: {LinqTasks.Task3()}");

            Console.WriteLine("\nTask4");
            foreach (var emp in LinqTasks.Task4())
            {
                Console.WriteLine(emp.ToString());
            }

            Console.WriteLine("\nTask5");
            foreach (var obj in LinqTasks.Task5())
            {
                var result = obj as dynamic;
                Console.WriteLine($"Nazwisko: {result.Nazwisko} - Praca: {result.Praca}");
            }

            Console.WriteLine("\nTask6");
            foreach (var obj in LinqTasks.Task6())
            {
                var result = obj as dynamic; 
                Console.WriteLine($"{result.Ename} - {result.Job} - {result.Dname}");
            }

            Console.WriteLine("\nTask7");
            foreach (var obj in LinqTasks.Task7())
            {
                var result = obj as dynamic; 
                Console.WriteLine($"Praca: {result.Praca} - {result.LiczbaPracownikow}");
            }

            Console.WriteLine("\nTask8");
            Console.WriteLine($"Is there any Backend programmer? {LinqTasks.Task8()}");

            Console.WriteLine("\nTask9");
            var task9Result = LinqTasks.Task9();
            if (task9Result != null)
            {
                Console.WriteLine(task9Result.ToString());
            }
            else
            {
                Console.WriteLine("No result");
            }

            Console.WriteLine("\nTask10");
            foreach (var obj in LinqTasks.Task10())
            {
                var result = obj as dynamic; 
                Console.WriteLine($"{result.Ename} - {result.Job} - {result.Hiredate}");
            }

            Console.WriteLine("\nTask11");
            foreach (var obj in LinqTasks.Task11())
            {
                var result = obj as dynamic;
                Console.WriteLine($"{result.name} - {result.numOfEmployees}");
            }

            Console.WriteLine("\nTask12");
            foreach (var emp in LinqTasks.Task12())
            {
                Console.WriteLine($"{emp.Ename} - {emp.Salary}");
            }

            Console.WriteLine("\nTask13");
            int[] task13Array = { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
            Console.WriteLine($"Number that appears odd number of times: {LinqTasks.Task13(task13Array)}");

            Console.WriteLine("\nTask14");
            foreach (var dept in LinqTasks.Task14())
            {
                Console.WriteLine($"{dept.Dname}");
            }

            Console.WriteLine("\nTask15");
            foreach (var obj in LinqTasks.Task15())
            {
                var result = obj as dynamic; 
                Console.WriteLine($"Praca: {result.Praca} - {result.LiczbaPracownikow}");
            }

            Console.WriteLine("\nTask16");
            foreach (var obj in LinqTasks.Task16())
            {
                var result = obj as dynamic; 
                Console.WriteLine($"{result.Empno} - {result.Ename} - {result.Job} - {result.Salary} - {result.HireDate} - {result.Deptno} - {result.DeptDname} - {result.DeptLoc}");
            }
        }
    }
}