using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba_1
{
    internal class Complex
    {
        public double real_part;
        public double imaginary_part;
        public double modul;
        public double phi;

        public Complex() { }

        public Complex(double real_part, double imeginary_part, int n)
        {
            if (n == 1)
            {
                this.real_part = real_part;
                this.imaginary_part = imeginary_part;
            }
            if (n == 2)
            {

                this.real_part = real_part * Math.Cos(imeginary_part);
                this.imaginary_part = imaginary_part * Math.Sin(imeginary_part);
            }
        }

        public double get_real()
        {
            return real_part;
        }

        public double get_img()
        {
            return imaginary_part;
        }
        public double get_modul()
        {
            return modul;
        }
        public double get_phi()
        {
            return phi;
        }

        public void reculculate()
        {
            modul = Math.Sqrt(real_part * real_part + imaginary_part * imaginary_part);
            phi = Math.Asin(real_part / modul);
        }

        public static Complex operator +(Complex com1, Complex com2)
        {
            Complex res = new Complex();
            res.real_part = com1.real_part + com2.real_part;
            res.imaginary_part = com1.imaginary_part + com2.imaginary_part;
            res.reculculate();
            return res;
        }

        public static Complex operator -(Complex com1, Complex com2)
        {
            Complex res = new Complex();
            res.real_part = com1.real_part - com2.real_part;
            res.imaginary_part = com1.imaginary_part - com2.imaginary_part;
            res.reculculate();
            return res;
        }

        public static Complex operator *(Complex com1, Complex com2)
        {
            Complex res = new Complex();
            res.real_part = com1.real_part * com2.real_part - com1.imaginary_part * com2.imaginary_part;
            res.imaginary_part = com1.real_part * com2.imaginary_part + com2.real_part * com1.imaginary_part;
            res.reculculate();
            return res;
        }

        public static Complex operator /(Complex com1, Complex com2)
        {
            Complex res = new Complex();
            double sum_sq = com2.real_part * com2.real_part + com2.imaginary_part * com2.imaginary_part;
            res.real_part = (com1.real_part * com2.real_part + com1.imaginary_part * com2.imaginary_part) / sum_sq;
            res.imaginary_part = (com2.real_part * com1.imaginary_part + com1.real_part * com2.real_part) / sum_sq;
            res.reculculate();
            return res;
        }

        public static Complex Pow(Complex com, int n)
        {
            Complex res = new Complex(com.real_part, com.imaginary_part, 1);
            for (int i = 1; i < n; i++)
            {
                res *= com;
            }
            res.reculculate();
            return res;
        }

        public static Complex sq(Complex com, int n)
        {
            Complex res = new Complex(com.real_part, com.imaginary_part, 1);
            for (int i = 1; i < n; i++)
            {
                res /= com;
            }
            res.reculculate();
            return res;
        }

    }
}

