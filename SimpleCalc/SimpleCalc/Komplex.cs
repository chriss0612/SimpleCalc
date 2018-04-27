using System;
using System.Collections.Generic;

namespace SimpelCalc
{
    class Komplex
    {
        public decimal im;
        public decimal re;
        public List<Komplex> nebenwerte = new List<Komplex>();
        public Komplex(decimal re, decimal im)
        {
            this.im = im;
            this.re = re;
        }
        public Komplex(decimal r, double phi)
        {
            re = r * Convert.ToDecimal(Math.Cos(phi));
            im = r * Convert.ToDecimal(Math.Sin(phi));
        }
        public static Komplex operator +(Komplex z1, Komplex z2)
        {
            Komplex k = new Komplex(z1.re + z2.re, z1.im + z2.im);
            for (int i = -1; i < z1.nebenwerte.ToArray().Length; i++)
            {
                for (int d = -1; d < z2.nebenwerte.ToArray().Length; d++)
                {
                    if (i == -1 && d == -1)
                    {

                    }
                    else if (i == -1)
                    {
                        k.nebenwerte.Add(new Komplex(z1.re, z1.im) + z2.nebenwerte.ToArray()[d]);
                    }
                    else if (d == -1)
                    {
                        k.nebenwerte.Add(z1.nebenwerte.ToArray()[i] + new Komplex(z2.re, z2.im));
                    }
                    else
                    {
                        k.nebenwerte.Add(z1.nebenwerte.ToArray()[i] + z2.nebenwerte.ToArray()[d]);
                    }
                }
            }
            return k;
        }
        public static Komplex operator -(Komplex z1, Komplex z2)
        {
            Komplex k = new Komplex(z1.re - z2.re, z1.im - z2.im);
            for (int i = -1; i < z1.nebenwerte.ToArray().Length; i++)
            {
                for (int d = -1; d < z2.nebenwerte.ToArray().Length; d++)
                {
                    if (i == -1 && d == -1)
                    {

                    }
                    else if (i == -1)
                    {
                        k.nebenwerte.Add(new Komplex(z1.re, z1.im) - z2.nebenwerte.ToArray()[d]);
                    }
                    else if (d == -1)
                    {
                        k.nebenwerte.Add(z1.nebenwerte.ToArray()[i] - new Komplex(z2.re, z2.im));
                    }
                    else
                    {
                        k.nebenwerte.Add(z1.nebenwerte.ToArray()[i] - z2.nebenwerte.ToArray()[d]);
                    }
                }
            }
            return k;
        }
        public static Komplex operator *(Komplex z1, Komplex z2)
        {
            Komplex k = new Komplex(z1.re * z2.re - z1.im * z2.im, z1.re * z2.im + z2.re * z1.im);
            for (int i = -1; i < z1.nebenwerte.ToArray().Length; i++)
            {
                for (int d = -1; d < z2.nebenwerte.ToArray().Length; d++)
                {
                    if (i == -1 && d == -1)
                    {

                    }
                    else if (i == -1)
                    {
                        k.nebenwerte.Add(new Komplex(z1.re, z1.im) * z2.nebenwerte.ToArray()[d]);
                    }
                    else if (d == -1)
                    {
                        k.nebenwerte.Add(z1.nebenwerte.ToArray()[i] * new Komplex(z2.re, z2.im));
                    }
                    else
                    {
                        k.nebenwerte.Add(z1.nebenwerte.ToArray()[i] * z2.nebenwerte.ToArray()[d]);
                    }
                }
            }
            return k;
        }
        public static Komplex operator /(Komplex z1, Komplex z2)
        {
            return (z1 * konj(z2)) / (z2.re * z2.re + z2.im * z2.im);
        }
        public static Komplex operator /(Komplex z, decimal d)
        {
            return new Komplex(z.re / d, z.im / d);
        }
        private decimal ToPolarR()
        {
            return Convert.ToDecimal(Math.Sqrt((Double)(re * re + im * im)));
        }
        private double ToPolarPhi()
        {
            double phi = 0;
            if (re == 0)
            {
                if (im < 0)
                    phi = (double)Calcs.pi / 2 * 3;
                if (im >= 0)
                    phi = (double)Calcs.pi / 2;
            }
            else if (re >= 0 && im >= 0)
            {
                phi = Math.Atan((Double)(im / re));
            }
            else if (re < 0 && im >= 0)
            {
                phi = (double) Calcs.pi + Math.Atan((Double)(im / re));
            }
            else if (re < 0 && im < 0)
            {
                phi = (double) Calcs.pi + Math.Atan((Double)(im / re));
            }
            else if (re > 0 && im < 0)
            {
                phi = (double) Calcs.pi * 2 + Math.Atan((Double)(im / re));
            }
            return phi;
        }
        public string ToString(string arg)
        {
            remUnNeb();
            string neb = " ; ";
            for (int i = 0; i < nebenwerte.ToArray().Length; i++)
            {
                neb += nebenwerte.ToArray()[i].ToString(arg);
            }
            if (Math.Round(im, 12) == Math.Round(0m, 12))
            {
                return re.ToString(arg) + neb;
            }
            else
            {
                if (Calcs.mode == 0)
                {
                    if (im >= 0)
                        return Math.Round(re, 12).ToString(arg) + "+" + Math.Round(im, 12).ToString(arg) + "i (" + ToPolarR().ToString(arg) + ";" + ToPolarPhi().ToString(arg) + ")" + neb;
                    return Math.Round(re, 12).ToString(arg) + "-" + Math.Round(-1 * im, 12).ToString(arg) + "i (" + ToPolarR().ToString(arg) + ";" + ToPolarPhi().ToString(arg) + ")" + neb;
                }
                if (Calcs.mode == 1)
                {
                    if (im >= 0)
                        return Math.Round(re, 12).ToString(arg) + "+" + Math.Round(im, 12).ToString(arg) + "i (" + ToPolarR().ToString(arg) + ";" + (ToPolarPhi() * 180 / Convert.ToDouble(Calcs.pi)).ToString(arg) + "°)" + neb;
                    return Math.Round(re, 12).ToString(arg) + "-" + Math.Round(-1 * im, 12).ToString(arg) + "i (" + ToPolarR().ToString(arg) + ";" + (ToPolarPhi() * 180 / Convert.ToDouble(Calcs.pi)).ToString(arg) + "°)" + neb;
                }
                if (Calcs.mode == 2)
                {
                    if (im >= 0)
                        return Math.Round(re, 12).ToString(arg) + "+" + Math.Round(im, 12).ToString(arg) + "i (" + ToPolarR().ToString(arg) + ";" + (ToPolarPhi() * 200 / Convert.ToDouble(Calcs.pi)).ToString(arg) + "°)" + neb;
                    return Math.Round(re, 12).ToString(arg) + "-" + Math.Round(-1 * im, 12).ToString(arg) + "i (" + ToPolarR().ToString(arg) + ";" + (ToPolarPhi() * 200 / Convert.ToDouble(Calcs.pi)).ToString(arg) + "°)" + neb;
                }
                Calcs.err = true;
                return "Err";
            }
        }
        override public string ToString()
        {
            return ToString(false);
        }
        public string ToString(bool b)
        {
            remUnNeb();
            string nebs = "";
            for (int i = 0; i < nebenwerte.ToArray().Length; i++)
            {
                nebs += "k" + nebenwerte.ToArray()[i].ToString(b);
            }
            if (!b)
            {
                if (Math.Round(im, 12) == Math.Round(0m, 12))
                {
                    return re.ToString() + nebs;
                }
                else
                {
                    return re.ToString() + "+" + im.ToString() + "i" + nebs;
                }
            }
            else
            {
                if (Math.Round(im, 12) == Math.Round(0m, 12))
                {
                    return re.ToString() + nebs;
                }
                else
                {
                    return re.ToString() + "x" + im.ToString() + "i" + nebs;
                }
            }
        }
        private Komplex remUnNeb()
        {
            nebenwerte = getallneb();
            List<Komplex> rems = new List<Komplex>();
            List<Komplex> Aneb = new List<Komplex>();
            /*for (int i = 0; i < nebenwerte.Count; i++)
            {
                Console.WriteLine("neb[" + i + "] = " + nebenwerte[i]);
            }*/
            while (Aneb != nebenwerte)
            {
                Aneb = nebenwerte;
                if (nebenwerte.Count == 0)
                {
                    return this;
                }
                Console.WriteLine("TMP erg = " + toBasic().ToString());
                for (int i = 0; i < nebenwerte.Count; i++)
                {
                    if (nebenwerte[i].re == re && nebenwerte[i].im == im)
                    {
                        rems.Add(nebenwerte[i]);
                    }
                    for (int d = 0; d < nebenwerte.Count; d++)
                    {
                        if (nebenwerte[i].re == nebenwerte[d].re && nebenwerte[i].im == nebenwerte[d].im && i != d && i > d)
                            rems.Add(nebenwerte[i]);
                        }
                    }
                    foreach (Komplex kom in rems)
                    {
                        nebenwerte.Remove(kom);
                    }
                }
            return this;
        }
        private List<Komplex> getallneb()
        {
            List<Komplex> list = new List<Komplex>();
            if (nebenwerte == list)
            {
                return list;
            }
            for (int i = 0; i < nebenwerte.Count; i++)
            {
                for (int d = 0; d < nebenwerte[i].getallneb().Count; d++)
                {
                    list.Add(nebenwerte[i].getallneb()[d]);
                }
                list.Add(nebenwerte[i].toBasic());
            }
            return list;
        }
        private static Komplex konj(Komplex z)
        {
            return new Komplex(z.re, -z.im);
        }
        private Komplex toBasic()
        {
            return new Komplex(re, im);
        }
    }
}