using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class numerosTabela
    {
        public static void NumerosTabela()
        {
            int a = 0, b = 1, c = 2, d = 3, e = 4, f = 5, g = 6, h = 7, i = 8, j = 9, k = 10;
            int l, m, n, o, p, q, r, s, t, u, v;//Quadrados
            int x, y, z, w, a1, a2, a3, a4, a5, a6, a7;//Cubos

            l = (a * a);
            m = (b * b);
            n = (c * c);
            o = (d * d);
            p = (e * e);
            q = (f * f);
            r = (g * g);
            s = (h * h);
            t = (i * i);
            u = (j * j);
            v = (k * k);

            x = (a * a * a);
            y = (b * b * b);
            z = (c * c * c);
            w = (d * d * d);
            a1 = (e * e * e);
            a2 = (f * f * f);
            a3 = (g * g * g);
            a4 = (h * h * h);
            a5 = (i * i * i);
            a6 = (j * j * j);
            a7 = (k * k * k);

            Console.WriteLine();
            Console.WriteLine("\t\t|número|\t|quadrado|\t\t|cubo|");
            Console.WriteLine("\t\t {0}{1}{2}", a + "\t\t ", l + "\t\t\t", x);
            Console.WriteLine("\t\t {0}{1}{2}", b + "\t\t ", m + "\t\t\t", y);
            Console.WriteLine("\t\t {0}{1}{2}", c + "\t\t ", n + "\t\t\t", z);
            Console.WriteLine("\t\t {0}{1}{2}", d + "\t\t ", o + "\t\t\t", w);
            Console.WriteLine("\t\t {0}{1}{2}", e + "\t\t ", p + "\t\t\t", a1);
            Console.WriteLine("\t\t {0}{1}{2}", f + "\t\t ", q + "\t\t\t", a2);
            Console.WriteLine("\t\t {0}{1}{2}", g + "\t\t ", r + "\t\t\t", a3);
            Console.WriteLine("\t\t {0}{1}{2}", h + "\t\t ", s + "\t\t\t", a4);
            Console.WriteLine("\t\t {0}{1}{2}", i + "\t\t ", t + "\t\t\t", a5);
            Console.WriteLine("\t\t {0}{1}{2}", j + "\t\t ", u + "\t\t\t", a6);
            Console.WriteLine("\t\t {0}{1}{2}", k + "\t\t ", v + "\t\t\t", a7);
        }
    }
}
