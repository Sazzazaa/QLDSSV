﻿using System;

namespace QLSV
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Ten: {Name}, Tuoi: {Age}";
        }
    }
}