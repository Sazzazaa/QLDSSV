using System;
using System.Collections.Generic;

namespace QLSV
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tao dshsinh
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Khang", Age = 21 },
                new Student { Id = 2, Name = "Huy", Age = 17 },
                new Student { Id = 3, Name = "Thy", Age = 19 },
                new Student { Id = 4, Name = "Anh", Age = 15 },
                new Student { Id = 5, Name = "An", Age = 25 }
            };

            // Goi chuc nang
            QLSV.InDs(students);
            QLSV.InDs15Den18(students);
            QLSV.InDsTuA(students);
            QLSV.InTongTuoi(students);
            QLSV.InHsCaoTuoiNhat(students);
            QLSV.InDsSapXepTangDan(students);
        }
    }
}