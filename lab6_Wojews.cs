using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wojew_lab6
{
    public static class Tools
    {
        public static Double SinFmDeg2(this int x)
        {
            double rad = x * Math.PI / 180;
            double s = Math.Sin(rad);
            return s;
        }
        public static Double CosFmDeg2(this int x)
        {
            double rad = x * Math.PI / 180;
            double s = Math.Cos(rad);
            return s;
        }
        public static Double logar10(this int x, int p)
        {
            double wynik = (Math.Log10(x)) / Math.Log10(p);
            return wynik;
        }
        public static Double Suma2(this double x, double y)
        {
            return x + y;
        }
        public static Double Roznica2(this double x, double y)
        {
            return x - y;
        }
        public static Double Iloczyn2(this double x, double y)
        {
            return x * y;
        }
        public static Double Iloraz2(this double x, double y)
        {
            return x / y;
        }
        public static Double Pierwiastek2(this double x)
        {
            return Math.Sqrt(x);
        }
        public static Int32 Silnia2(this int a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a * (a-1).Silnia2();
        }
    }
    internal class Program
    {

        public static Double Deg2Rad(int x)
        {
            double rad = x * Math.PI / 180;
            return rad;
        }
        public static Double sinus(double x)
        {
            double s = Math.Sin(x);
            return s;
        }
        public static Double cosinus(double x)
        {
            double c = Math.Cos(x);
            return c;
        }
        public static Double SinFmDeg(int x)
        {
            double rad = x * Math.PI / 180;
            double s = Math.Sin(rad);
            return s;

        }
        public static Double CosFmDeg(int x)
        {
            double rad = x * Math.PI / 180;
            double s = Math.Cos(rad);
            return s;

        }
        public static Double logar10(int x, int p)
        {
            double wynik = (Math.Log10(x)) / Math.Log10(p);
            return wynik;
        }
        public static Double loga10(int x)
        {
            double wynik = Math.Log(x);
            return wynik;
        }
        public static Double Suma(double x, double y)
        {
            return x + y;
        }
        public static Double Roznica(double x, double y)
        {
            return x - y;
        }
        public static Double Iloczyn(double x, double y)
        {
            return x * y;
        }
        public static Double Iloraz(double x, double y)
        {
            return x / y;
        }
        public static Double Pierwiastek(double x)
        {
            return Math.Sqrt(x);
        }
        public static int nwd(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
        public static int nwdrek(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
           return nwdrek(b, a % b);
        }
        public static int silniarek(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a*silnia(a-1);
        }
        public static int silnia(int a)
        {
            int wynik = 1;
            for (int i = 1; i < a+1; i++)
            {
                wynik = wynik * i;
            }
            return wynik;
        }
        public static int Fib(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            if (a == 1)
            {
                return 1;
            }
            return Fib(a - 2) + Fib(a - 1);
        }
        public static int Fibzw(int a)
        {
            int b, c, i, next;
            b = 1;
            c = 1;
            next = 0;
            for (i=0; i <= a; i++)
            {
                next = b + c;
                c = b;
                b = next;
            }
            return next;
        }
        public delegate Double Delegacja(Double x, Double y);
        public static Double Sumlambda(Double x, Double y) => x + y;
        public static Double Iloczynlamba(Double x, Double y) => x * y;
        public static Int32[] tabmake(int x)
        {
            int i = 0;
            Int32[] tabela = new int[x];
            Random los = new Random();
            do
            {
                tabela[i] = los.Next(0,x*x);
                i++;
            }
            while (i < x);
            return tabela;
        }

        static void Main(string[] args)
        {
            //zad 1
            /*Console.WriteLine("kąt" + "  |  " + "sinus" + "  |  " + "cosinus");*/
            //zad 1a
            /*or (int i = 0; i <= 90; i = i + 10)
            {
                Console.Write($"{i,5}");
                Console.Write($"{sinus(i * Math.PI / 180),9:F3}");
                Console.WriteLine($"{cosinus(i * Math.PI / 180),9:F3}");

            }
            Console.WriteLine();*/
            //zad 1b
            /*for (int i = 0; i <= 90; i = i + 10)
            {
                Console.Write($"{i,5}");
                Console.Write($"{sinus(Deg2Rad(i)),9:F3}");
                Console.WriteLine($"{cosinus(Deg2Rad(i)),9:F3}");

            }
            Console.WriteLine();*/
            //zad 1c
            /*for (int i = 0; i <= 90; i = i + 10)
            {
                Console.Write($"{i,5}");
                Console.Write($"{SinFmDeg(i),9:F3}");
                Console.WriteLine($"{CosFmDeg(i),9:F3}");

            }
            Console.WriteLine();*/
            //zad 1d
            /*for (int i = 0; i <= 90; i = i + 10)
            {
                Console.Write($"{i,5}");
                Console.Write($"{i.SinFmDeg2(),9:F3}");
                Console.WriteLine($"{i.CosFmDeg2(),9:F3}");

            }*/

            //zad 2
            //zad 2a
            /*int p = Int32.Parse(Console.ReadLine());
            for (int i = 16; i <= 256; i = i + 16)
            {
                Console.WriteLine($"{loga10(i) / loga10(p),4:F4}" + " - " + i);
            }
            Console.WriteLine();*/
            //zad 2b
            /*for (int i = 16; i <= 256; i = i + 16)
            {
                Console.WriteLine($"{logar10(i, p),4:F4}" + " - " + i);
            }
            Console.WriteLine();*/
            //zad 2c
            /*for (int i = 16; i <= 256; i = i + 16)
            {
                Console.WriteLine($"{i.logar10(p),4:F4}" + " - " + i);
            }*/

            //zad 3
            /*int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Suma(2 * a, 3 * b));
            Console.WriteLine(Suma(a * b, 7));
            Console.WriteLine(Suma(Math.Sqrt(a), b * b));
            Console.WriteLine(Suma(Suma(a, b), 1));*/

            //zad 4
            /*int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            int C = Int32.Parse(Console.ReadLine());
            double Delta;
            Delta = Roznica(Iloczyn(B, B), Iloczyn(4, Iloczyn(A, C)));

            if (Delta > 0)
            {
                double x1, x2;
                x1 = Iloraz(Roznica(Iloczyn(-1, B), Pierwiastek(Delta)), Iloczyn(2, A));
                x2 = Iloraz(Suma(Iloczyn(-1, B), Pierwiastek(Delta)), Iloczyn(2, A));
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                double x0;
                x0 = Iloraz(Iloczyn(-1, B), Iloczyn(2, A));
                Console.WriteLine("x0 = " + x0);
            }
            Console.WriteLine();*/

            //zad 5
            /*Double A = Int32.Parse(Console.ReadLine());
            Double B = Int32.Parse(Console.ReadLine());
            Double C = Int32.Parse(Console.ReadLine());
            double Delta;
            Delta = (B.Iloczyn2(B)).Roznica2((4.0).Iloczyn2(A.Iloczyn2(C)));

            if (Delta > 0)
            {
                double x1, x2;
                x1 = ((B.Iloczyn2(-1)).Roznica2(Delta.Pierwiastek2())).Iloraz2((2.0).Iloczyn2(A));
                x2 = ((B.Iloczyn2(-1)).Suma2(Delta.Pierwiastek2())).Iloraz2((2.0).Iloczyn2(A));
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                double x0;
                x0 = (B.Iloczyn2(-1)).Iloraz2((2.0).Iloczyn2(A));
                Console.WriteLine("x0 = " + x0);
            }
*/


            //Dane do 6 i 7 i 8
            /*Console.Write("Podaj od kąd: ");
            int pocz = int.Parse(Console.ReadLine());
            Console.Write("Podaj do kąd: ");
            int kon = int.Parse(Console.ReadLine());*/
            //zad 6
            /*Random rng = new Random();
            int a, b;
            do
            {
                a = rng.Next(pocz, kon + 1);
                b = rng.Next(pocz, kon + 1);
            } 
            while (nwd(a, b) != 1);
            Console.WriteLine($"liczby wzglednie pierwsze: {a}, {b}");*/

            //zad 7
            /*Random rng = new Random();
            int a, b;
            do
                {
                    a = rng.Next(pocz, kon + 1);
                    a = rng.Next(pocz, kon + 1);
                }
                while (nwdrek(a, b) != 1);

                Console.WriteLine($"liczby wzglednie pierwsze: {a}, {b}");
            */

            //zad 8
            /*Random rng = new Random();
            int a;

            for (int b = pocz; b <= kon + 1; b++)
            {
                do
                {
                    a = rng.Next(pocz, kon + 1);
                }
                while (nwdrek(a, b) != 1);

                Console.WriteLine($"liczby wzglednie pierwsze: {a}, {b}");
            }*/

            //zad 9
            /*int pocz = int.Parse(Console.ReadLine());
            int kon = int.Parse(Console.ReadLine());
            for (int i = pocz; i <= kon; i++)
            {
                Console.WriteLine("Silnia dla liczby " + i + ":  " + silnia(i));
            }*/

            //zad 10
            /*int pocz = int.Parse(Console.ReadLine());
            int kon = int.Parse(Console.ReadLine());
            for (int i = pocz; i <= kon; i++)
                {
                    Console.WriteLine("Silnia dla liczby " + i + ":  " + silniarek(i));
                }*/

            //zad 11
            /*int pocz = int.Parse(Console.ReadLine());
            int kon = int.Parse(Console.ReadLine());
            for (int i = pocz; i <= kon; i++)
            {
                Console.WriteLine("Silnia dla liczby " + i + ": " + i.Silnia2());
            }*/

            //zad 12
            /*int i = 0;
            do
            {
                Console.WriteLine(Fib(i));
                i++;
            }
            while (Fib(i) <= 50);*/

            //zad 13
            /*Stopwatch sw = new Stopwatch();
            int pocz = int.Parse(Console.ReadLine());
            int kon = int.Parse(Console.ReadLine());
            for (int i = pocz; i <= kon; i++)
            {
                sw.Start();
                Console.WriteLine("Silnia dla liczby " + i + ":  " + silniarek(i));
                sw.Stop();
                Console.WriteLine("czas to: " + sw.Elapsed);
                sw.Reset();
            }*/

            //zad 14
            /*int i = 0;
            do
            {
                Console.WriteLine(Fibzw(i));
                i++;
            }
            while (Fibzw(i) <= 50);*/

            //zad 15 dane
            /*double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sum, sumalambda;*/
            //zad 15a
            /*Delegacja del = Suma;
            sum = del(a, b);
            Console.WriteLine("Delegacja " + sum);
*/
            //zad 15b
            /*Delegacja del2 = Sumlambda;
            sumalambda = del2(a, b);
            Console.WriteLine("Wyrazenie lampda " + sumalambda);*/

            //zad 16 dane
            /*double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sum, sumalambda, iloczyn, iloczynlambda;*/

            //zad 16a
            /*Delegacja del = Suma;
            sum = del(a, b);
            Console.WriteLine("Suma delegacja " + sum);
            Delegacja del2 = Iloczyn;
            iloczyn = del2(a, b);
            Console.WriteLine("Iloczyn delegacja " + iloczyn);*/

            //zad 16b
            /*Delegacja del3 = Sumlambda;
            sumalambda = del2(a, b);
            Console.WriteLine("Suma wyrazenie lampda " + sumalambda);
            Delegacja del4 = Iloczynlamba;
            iloczynlambda = del4(a, b);
            Console.WriteLine("Iloczyn delegacja " + iloczynlambda);*/


            Int32[] tabela;
            int rozmtabeli;
            Console.Write("Podaj rozmiar tabeli: ");
            rozmtabeli=int.Parse(Console.ReadLine());
            tabela = tabmake(rozmtabeli);
            for (int i = 0; i < rozmtabeli; i++)
            {
                Console.WriteLine(tabela[i]);
            }





            Console.ReadKey();
        }
    }
}
