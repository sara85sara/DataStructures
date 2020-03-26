using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class HashSetWorks
    {
        public void Create()
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("sara");
            names.Add("Sindhu");
            names.Add("Ruthura");
        }
        public void Display(HashSet<string> names)
        {
            if (names != null && names.Count > 0)
            {
                foreach (var item in names)
                {
                    Console.WriteLine(item);
                }
            }
        }
        /// <summary>
        /// Combine items from both collections and display
        /// </summary>
        /// <param name="colection1"></param>
        /// <param name="collection2"></param>
        public void UnionWith(HashSet<string> colection1, HashSet<string> collection2)
        {
            HashSet<string> names1 = new HashSet<string>();
            names1.Add("sara");
            names1.Add("Sindhu");
            names1.Add("Ruthura");

            HashSet<string> names2 = new HashSet<string>();
            names2.Add("sara");
            names2.Add("Sindhu");
            names2.Add("Ruthura");

            names1.UnionWith(names2);
            foreach (var item in names1)
            {
                Console.WriteLine(item);
            }

        }
        /// <summary>      
        /// This method combines the elements that are common to both the collections
        /// </summary>
        /// <param name="colection1"></param>
        /// <param name="collection2"></param>
        public void IntersectWith(HashSet<string> colection1, HashSet<string> collection2)
        {
            HashSet<string> names1 = new HashSet<string>();
            names1.Add("sara");
            names1.Add("Sindhu");
            names1.Add("Ruthura");

            HashSet<string> names2 = new HashSet<string>();
            names2.Add("sara");
            names2.Add("Sindhu");
            names2.Add("Ruthura");
            names2.Add("Maya");

            names2.IntersectWith(names2);
            foreach (var item in names1)
            {
                Console.WriteLine(item);
            }

        }
        /// <summary>
        /// This method removes all the elements that are present in the other collections from the collection on which it is called.
        /// </summary>
        /// <param name="colection1"></param>
        /// <param name="collection2"></param>
        public void ExceptWith(HashSet<string> colection1, HashSet<string> collection2)
        {
            HashSet<string> names = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit"
            };
            HashSet<string> names1 = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit",
                "Deepak",
                "Mohit"
            };
            names1.ExceptWith(names);
            foreach (var item in names1)
            {
                Console.WriteLine(item);
            }

        }
        public void HasSetWithClass()
        {
            HashSet<Employee> hsEmployee = new HashSet<Employee> {
            {
                new Employee { EmployeeId = 1, EmployeeName = "saravanan", DepartmentName = "Physcis" }
            },
            {
                new Employee { EmployeeId = 1, EmployeeName = "saravanan", DepartmentName = "Physcis" }

            }
            };
            foreach (var emploee in hsEmployee)
            {
                Console.WriteLine(emploee);
            }
        }
    }
}
/// <summary>
/// 
/// </summary>
public class Employee : IEquatable<Employee>
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string DepartmentName { get; set; }

    public bool Equals(Employee other)
    {
        return this.EmployeeId.Equals(other.EmployeeId);
    }
}