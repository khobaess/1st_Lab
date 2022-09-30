﻿using System;
using System.Numerics;

namespace _1st_Lab
{
    class Program

    {
        public static double Factorial(int facushka)
        {
            double fact = 1;

            for (int i = 1; i < facushka; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void Main()
        {
            #region Level_1

            #region L1Task4
            {
                Console.Write("Write number: ");

                double xx = Convert.ToDouble(Console.ReadLine());
                double ssss = 0;

                for (int iii = 1; iii <= 9; iii++)
                {
                    ssss += Math.Cos((iii * xx)) / Math.Pow(xx, iii + 1);

                        
                }

                Console.Write("L1Task4: ");

                Console.WriteLine(ssss);


            }
            #endregion

            #region L1Task9
            double a_9 = 0;

            for (int pow = 1; pow < 7 ; pow ++)
            {
                int fac = 1;
                for (int iiii = 1; iiii <= pow; iiii++)
                {
                    fac *= iiii;
                }
                a_9 += Math.Pow(-1, pow) * Math.Pow(5, pow) / fac;
            }
            Console.Write("L1Task9: ");

            Console.WriteLine(a_9);
            #endregion

            #region L1Task15
            double chis = 1;
            double znam = 1;
            for (int iii = 0; iii < 4; iii++)
            {
                chis += znam;
                znam = chis - znam;
            }


            Console.Write("L1Task15: ");

            Console.WriteLine(chis / znam);

            #endregion

            #region L1Task16
            double sZeren = 0;
            for (int pow = 0; pow < 64; pow = pow + 1)
            {
                sZeren += Math.Pow(2, pow);

            }

            Console.Write("L1Task16: ");

            Console.WriteLine(sZeren / 15 / 1000000);
            #endregion

            #region L1Task18

            int kolvo = 10;

            Console.WriteLine("L1Task18: ");

            for (int hours = 3; hours <= 24; hours += 3)
            {
                kolvo *= 2;
                Console.WriteLine($"hours: {hours}; kolvo: {kolvo}");
            }
            #endregion
            #endregion

            #region Level_2

            #region L2Task2

            int n = 1;
            int p = 1;
            int l = 1;
            while (l < 30000)
            {
                n = p;
                p += 3;
                l *= p;
            }
            n -= 3;
            Console.Write("L2Task2: ");

            Console.WriteLine(n);
            #endregion

            #region L2Task4
            double sssss = 0;
            double epsalo = 0.0001;
            double nnn = 2;
            double x;
            double m;
            double.TryParse(Console.ReadLine(), out x);
            do
            {
                m = Math.Pow(x, nnn);
                sssss = sssss + m;
                nnn = nnn * 2;

            }
            while (nnn <= epsalo);
            Console.WriteLine($"L2Task4: {sssss}");


            #endregion

            #region L2Task7 & 8

            double distancia = 10;
            double SUMdistancia = distancia;
            int day = 1;

            for (day = 2; day <= 7; day = day + 1)
            {
                distancia += distancia * 0.1;
                SUMdistancia += distancia;

            }

            Console.WriteLine("L2Task7&8 A: ");

            distancia = 10;
            SUMdistancia = 0;
            day = 1;

            for (int iii = 1; iii <= 6; iii++)
            {
                distancia += distancia * 0.1;
                SUMdistancia += distancia;

            }
            Console.WriteLine(SUMdistancia);


            Console.WriteLine("L2Task7&8 B: ");


            distancia = 10;
            SUMdistancia = 10;
            day = 1;

            while (SUMdistancia < 100)
            {
                distancia *= 1.1;
                SUMdistancia += distancia;
                day = day + 1;

            }
            Console.WriteLine(day);
            #endregion

            Console.Write("L2Task7&8 C: ");

            double ddistancia = 10.0;
            double dday = 1;

            while (ddistancia < 20)
            {
                ddistancia *= 1.1;
                dday = dday + 1;

            }
            Console.WriteLine(dday);
            #endregion


            #region Level_3
            Console.WriteLine("L3Task1: ");
            #region L3Task1
            double aa = 0.1;
            double bb = 1;
            double hh = 0.1;
            double ss = 1;
            int i;
            double facushka;
            double u;
            double epsel = 0.0001;


            for (double xx = aa; xx <= bb; xx += hh)
            {
                i = 0;
                facushka = 1;

                do
                {
                    u = (Math.Pow(-1, i) * Math.Pow(xx, 2 * i)) / facushka;
                    i += 1;
                    ss += u;
                    facushka *= (2 * i) * (2 * i - 1);
                }
                while (u >= epsel);
                {
                    double yy = Math.Cos(xx);
                    Console.Write($"x:{Math.Round(xx, 3),4}\ts:{ss,4} y:{yy,10}");
                    Console.WriteLine();
                }
            }

            #endregion

            Console.WriteLine("L3Task2");
            #region L3Task2
            double sin = Math.Sin(Math.PI / 4);
            double cos = Math.Cos(Math.PI / 4);
            double aaa = 0.1;
            double bbb = 0.8;
            double hhh = 0.1;
            double sss = 0;
            double uu;
            double epse = 0.0001;
            int ii;
            double yyy;
            for (double xxx = aaa; xxx <= bbb; xxx += hhh)
            {
                uu = 0;
                ii = 1;
                do
                {
                    double xvitoi = Math.Pow(xxx, ii);
                    uu = xvitoi * Math.Sin((Math.PI / 4) * ii);
                    sss += uu;
                    ii += 1;
                }
                while (uu >= epse);
                {
                    yyy = (xxx * sin) / (1 - (2 * xxx * cos) + Math.Pow(xxx, 2));
                    Console.Write($"x:{Math.Round(xxx, 3),4}\ts:{sss,4} y:{yyy,10}");
                    Console.WriteLine();
                }
                #endregion
            }
        }
        #endregion
    }
}