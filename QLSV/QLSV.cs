using System;
using System.Collections.Generic;
using System.Linq;

namespace QLSV
{
    public static class QLSV
    {
        // a. In dshs
        public static void InDs(List<Student> students)
        {
            Console.WriteLine("Danh sach tat ca hoc sinh hien co:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        //Tim va in hs tu 15 den 18
        public static void InDs15Den18(List<Student> students)
        {
            var studentsAged15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            Console.WriteLine("\nDanh sach hoc sinh co tuoi tu 15 den 18:");
            foreach (var student in studentsAged15To18)
            {
                Console.WriteLine(student);
            }
        }

        //Hs co ten tu chu A
        public static void InDsTuA(List<Student> students)
        {
            var studentsStartingWithA = students.Where(s => s.Name.StartsWith("A"));
            Console.WriteLine("\nDanh sach hoc sinh co ten bat dau bang chu cai 'A':");
            foreach (var student in studentsStartingWithA)
            {
                Console.WriteLine(student);
            }
        }

        //Tong tuoi cua hs
        public static void InTongTuoi(List<Student> students)
        {
            var totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong so tuoi cua tat ca hoc sinh: {totalAge}");
        }

        //In hs co tuoi lon nhat
        public static void InHsCaoTuoiNhat(List<Student> students)
        {
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine("\nHoc sinh co tuoi lon nhat:");
            Console.WriteLine(oldestStudent);
        }

        //Sap xep ds tuoi tang dan
        public static void InDsSapXepTangDan(List<Student> students)
        {
            var sortedStudents = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep tuoi tang dan:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}