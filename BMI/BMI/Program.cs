﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            BaslikYaz();
            double boy = Giris("Boy (m): ");
            double kilo = Giris("Kilo (kg): ");
            double bmi = EndeksHesapla(boy, kilo);
            Console.WriteLine($"Endeks: {bmi}");
            HesapSonucunuYazdir(bmi); 
            Console.ReadLine();
        }

        static void HesapSonucunuYazdir(double bmi)
        {
            Console.WriteLine("BMİ: ");
            if (bmi < 18)
                Console.WriteLine("Zayıf");
            else if (bmi >= 18 && bmi < 25)
                Console.WriteLine("Normal");
            else if (bmi >= 25 && bmi <30)
                Console.WriteLine("Kilolu");
            else
                Console.WriteLine("Obez");

        }

        static double EndeksHesapla(double boy, double kilo)
        {
            return kilo / (boy * boy);
        }

        static void BaslikYaz()
        {
            Console.WriteLine("*** BMI Calculator ***");
        }

        static double Giris(string yazi)
        {
            Console.Write(yazi);
            double giris = Convert.ToDouble(Console.ReadLine());
            return giris;
        }
    }
}
