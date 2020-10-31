﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Student
    {
        string id;
        string name;
        string department;
        float cgpa;
        string Id
        {
            set { id = value; }
            get { return id; }
        }
        string Name
        {
            set { name = value; }
            get { return name; }
        }
        string Department
        {
            set { department = value; }
            get { return department; }
        }
        float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }
        public Student()
        {
        }
        public Student(string id, string name, string department, float cgpa)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.cgpa = cgpa;
        }
        void ShowInfo()
        {
            Id = "3345";
            Name = "Rahim";
            Department = "BBA";
            Cgpa = 1.5F;
        }
    }
