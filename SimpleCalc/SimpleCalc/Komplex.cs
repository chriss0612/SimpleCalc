using System;

namespace SimpelCalc
{
    class Komplex
    {
        public decimal Im;
        public decimal Re;
        public double r;
        public double phi;
        public Komplex(decimal re, decimal im)
        {
            Im = im;
            Re = re;
            toPolar();
        }
        public static Komplex fromPolar(double r, double phi)
        {
            Komplex obj = new Komplex(0, 0);
            obj.r = r;
            obj.phi = phi;
            obj.fromPolar();
            return obj;
        }
        public static Komplex operator +(Komplex z1, Komplex z2)
        {
            return new Komplex(z1.Re + z2.Re, z1.Im + z2.Im);
        }
        public static Komplex operator -(Komplex z1, Komplex z2)
        {
            return new Komplex(z1.Re - z2.Re, z1.Im - z2.Im);
        }
        public static Komplex operator *(Komplex z1,Komplex z2)
        {
            return new Komplex(z1.Re * z2.Re - z1.Im * z2.Im, z1.Re * z2.Im + z2.Re * z1.Im);
        }
        public static Komplex operator /(Komplex z1, Komplex z2)
        {
            return fromPolar(z1.r / z2.r, z1.phi - z2.phi);
        }
        public static Komplex operator ^(Komplex z, double d)
        {
            return fromPolar(Math.Pow(z.r, d), z.phi * d);
        }
        public static Komplex root(Komplex z, double d)
        {
            return z ^ (1 / d);
        }
        private void toPolar()
        {
            r = Math.Sqrt((Double)(Re * Re + Im * Im));
            if(Re==0)
            {
                phi = 0;
            }
            else if (Re >= 0 && Im >= 0)
            {
                phi = Math.Atan((Double)(Im / Re));
            }
            else if (Re < 0 && Im >= 0)
            {
                phi = 180+Math.Atan((Double)(Im / Re));
            }
            else if (Re < 0 && Im < 0)
            {
                phi = 180+Math.Atan((Double)(Im / Re));
            }
            else if (Re < 0 && Im < 0)
            {
                phi = 360+Math.Atan((Double)(Im / Re));
            }
        }
        public void fromPolar()
        {
            Re = (decimal) (r * Math.Cos(phi));
            Im = (decimal) (r * Math.Sin(phi));
        }
        public string ToString(string arg)
        {
            if (Im == 0)
            {
                return Re.ToString(arg);
            }
            else
            {
                return Re.ToString(arg) + "+" + Im.ToString(arg) + "i";
            }
        }
        override public string ToString()
        {
            if (Im == 0)
            {
                return Re.ToString();
            }
            else
            {
                return Re.ToString() + "+" + Im.ToString() + "i";
            }
        }
        public string ToString(bool b)
        {
            if (!b)
            {
                if (Im == 0)
                {
                    return Re.ToString();
                }
                else
                {
                    return Re.ToString() + "+" + Im.ToString() + "i";
                }
            }
            else
            {
                if (Im == 0)
                {
                    return Re.ToString();
                }
                else
                {
                    return Re.ToString() + "x" + Im.ToString() + "i";
                }
            }
        }
    }
}
