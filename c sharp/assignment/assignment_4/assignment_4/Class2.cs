﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    class Doctor
    {

        private int RegnNo;
        private string Name;
        private float Feescharged;

        public void SetValues(int regnNo, string name, float fees)
        {
            RegnNo = regnNo;
            Name = name;
            Feescharged = fees;
        }

        public void DisplayValues()
        {
            Console.WriteLine($"Registration Number: {RegnNo}");
            Console.WriteLine($"Doctor Name: {Name}");
            Console.WriteLine($"Fees Charged: {Feescharged:C}");
        }
    }

    class class2
    {
        static void Main()
        {
            Doctor myDoctor = new Doctor();

            Console.WriteLine("Enter Doctor's Registration Number:");
            int regnNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Doctor's Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Fees Charged by the Doctor:");
            float fees = float.Parse(Console.ReadLine());

            myDoctor.SetValues(regnNo, name, fees);

            Console.WriteLine("Doctor Details:");
            myDoctor.DisplayValues();

            Console.ReadLine();
        }
    }
}
