using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_6
{
    class Class1
    {
        public int num1;
        public int num2;
        public Class1()
        {

        }
        public Class1(int number)
        {
            num1 = number;
        }
        public Class1(int number, int number2)
        {
            num1 = number;
            num2 = number2;
        }
        public void Vivod()
        {
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }

    class Class2
    {
        private string str = "Пусто";
        public void Write()
        {

        }
        public void Write(string str1)
        {
            if (str1.Length > 10) str = "Слишком длинная строка";
            else str = str1;
        }
        public void Vivod()
        {
            Console.WriteLine(str);
        }
    }

    class Class3
    {
        public double a;
        public double b;
        public double c;
        public Class3(int line1, int line2, int line3)
        {
            a = line1; b = line2; c = line3;
            if ((a + b > c) && (b + c > a) && (c + a > b))
                Console.WriteLine("Треугольник возможен");
            else
                Console.WriteLine("Треуголник не возможен");

            double A = (Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c))) * (180 / Math.PI);
            double B = (Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c))) * (180 / Math.PI);
            double C = (Math.Acos((Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a))) * (180 / Math.PI);

            Console.WriteLine("Угол A = {0:0.000}", A);
            Console.WriteLine("Угол B = {0:0.000}", B);
            Console.WriteLine("Угол C = {0:0.000}", C);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 argument = new Class1();
            argument.Vivod();
            Class1 argument1 = new Class1(1938);
            argument1.Vivod();
            Class1 argument2 = new Class1(1634, 5321);
            argument2.Vivod();
            Console.WriteLine();

            Class2 text1 = new Class2();
            Class2 text2 = new Class2();
            Class2 text3 = new Class2();
            text1.Write();
            text1.Vivod();
            text2.Write("Раз два");
            text2.Vivod();
            text3.Write("Раз два три четыре пять шесть");
            text3.Vivod();  
            Console.WriteLine();

            Class3 triangle = new Class3(156, 8, 6);
            Console.WriteLine();
            Class3 triangle2 = new Class3(5, 12, 13);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
