using System;

namespace SimpelCalc
{
    class Calcs
    {
        public bool errto0;
        public bool nullto0;
        public int mode;
        public bool err;
        private static decimal pi = 3.1415926535897932384626433833m;
        private static string minstr = "minus";
        public Int32 errkey = Properties.Resources.DefaultKey;

        public Calcs()
        {
            mode = 0;
            errto0 = false;
            nullto0 = false;
            err = true;
        }
        public decimal recalc(string inp)
        {
            err = false;
            errkey = Properties.Resources.DefaultKey;
            decimal erg = 0;
            inp = inp.Replace("pi", Convert.ToString(pi));
            try
            {
                erg = stmin(inp);
            }
            catch (Exception)
            {
                err = true;
            }
            if (err)
            {
                return -1;
            }
            else
            {
                return erg;
            }
        }
        private decimal stmin(string inp)
        {
            if (inp.Contains(minstr))
            {
                err = true;
                return -1;
            }
            if (!inp.Contains("-"))
                return bracts(inp);
            if (inp.StartsWith("-"))
            {
                inp = minstr + inp.Remove(0, 1);
            }
            inp = inp.Replace("/-", "/"+minstr).Replace("*-", "*"+minstr).Replace("+-", "+"+minstr).Replace("--", "-"+minstr).Replace("(-", "(" + minstr);
            return bracts(inp);
        }

        private decimal bracts(string inp)
        {
            if (!inp.Contains("("))
                return addsub(inp);
            for(int i=0;i<10;i++)
            {
                inp = inp.Replace(Convert.ToString(i)+"(",Convert.ToString(i)+"*(").Replace(")"+Convert.ToString(i), ")*"+Convert.ToString(i));
            }
            //inp = inp.Replace("0(", "0*(").Replace("1(", "1*(").Replace("2(", "2*(").Replace("3(", "3*(").Replace("4(", "4*(").Replace("5(", "5*(").Replace("6(", "6*(").Replace("7(", "7*(").Replace("8(", "8*(").Replace("9(", "9*(");
            string tmp, edit = inp, editA = edit;
            string[] tmpArray;
            string tmperg;
            while (true)
            {
                tmpArray = edit.Split('(');
                tmp = tmpArray[tmpArray.Length - 1];
                tmp = tmp.Split(')')[0];
                tmperg = Convert.ToString(addsub(tmp));
                if (tmperg.StartsWith("-"))
                {
                    tmperg = minstr + tmperg.Remove(0, 1);
                }
                
                edit = edit.Replace("(" + tmp + ")", tmperg);
                if (edit.Equals(editA))
                {
                    break;
                }
                editA = edit;
            }
            return addsub(edit);
        }
        private decimal addsub(string inp)
        {
            if (!inp.Contains("+") && !inp.Contains("-"))
                return multiDivi(inp);
            decimal erg = 0;
            string[] teil1 = inp.Split('+');
            string[] teil2 = teil1[0].Split('-');
            int i = 1;
            erg = erg + multiDivi(teil2[0]);
            for (; i < teil2.Length; i++)
            {
                erg = erg - multiDivi(teil2[i]);
            }
            for (int d = 1; d < teil1.Length; d++)
            {
                teil2 = teil1[d].Split('-');
                i = 1;
                erg = erg + multiDivi(teil2[0]);
                for (; i < teil2.Length; i++)
                {
                    erg = erg - multiDivi(teil2[i]);
                }
            }
            return erg;
        }

        private decimal multiDivi(string inp)
        {
            if (!inp.Contains("*")&&!inp.Contains("/"))
                return pot(inp);
            decimal erg = 1;
            string[] multi = inp.Split('*');
            if (multi[0] == "")
            {

            }
            for (int d = 0; d < multi.Length; d++)
            {
                string[] divi = multi[d].Split('/');
                erg = erg * pot(divi[0]);
                for (int i = 1; i < divi.Length; i++)
                {
                    if(pot(divi[i])==0)
                    {
                        err = true;
                        errkey = Properties.Resources.DivideByZeroKey;
                        return -1;
                    }
                    erg = erg / pot(divi[i]);
                }
            }
            return erg;
        }

        private decimal pot(string inp)
        {
            int i = 0;
            if (inp.Contains("E")) i++;
            if (inp.Contains("e")) i++;
            if (inp.Contains("^")) i++;
            if (i == 0)
                return useE(inp);
            if (i==1)
            {
                if (inp.Contains("E")) return useE(inp);
                if (inp.Contains("e")) return usee(inp);
            }
            else
            {
                err = true;
                errkey = Properties.Resources.PotAndEKey;
                return -1;
            }
            string[] teil1 = inp.Split('^');
            if (teil1.Length == 1)
            {
                return useE(teil1[0]);
            }
            else if (teil1.Length == 2)
            {
                return Convert.ToDecimal(Math.Pow(toDouble(teil1[0]), toDouble(teil1[1])));
            }
            else
            {
                err = true;
                return -1m;
            }
        }


        private double toDouble(string s)
        {
            try
            {
                if (nullto0 && s == "")
                {
                    return 0d;
                }
                if(s=="")
                {
                    err = true;
                    errkey = Properties.Resources.NullConvertDoubleKey;
                    return -1;
                }
                if (s.StartsWith(minstr))
                {
                    s = s.Remove(0, minstr.Length);
                    return -Convert.ToDouble(s);
                }
                return Convert.ToDouble(s);
            }
            catch (Exception)
            {
                if (errto0)
                {
                    return 0;
                }
                else
                {
                    err = true;
                    errkey = Properties.Resources.ErrConvertDoubleKey;
                    return -1;
                }

            }
        }
        private decimal toDecimal(string s)
        {
            try
            {
                if (nullto0 && s == "")
                {
                    return 0m;
                }
                if (s == "")
                {
                    err = true;
                    errkey = Properties.Resources.NullConvertDecimalKey;
                    return -1;
                }
                if (s.StartsWith(minstr))
                {
                    s = s.Remove(0, minstr.Length);
                    return -Convert.ToDecimal(s);
                }
                return Convert.ToDecimal(s);
            }
            catch (Exception)
            {
                if (errto0)
                {
                    return 0;
                }
                else
                {
                    err = true;
                    errkey = Properties.Resources.ErrConvertDecimalKey;
                    return -1;
                }
            }
        }
        private Int64 toInt(string s)
        {
            try
            {
                if (nullto0 && s == "")
                {
                    return 0;
                }
                if (s == "")
                {
                    err = true;
                    errkey = Properties.Resources.NullConvertIntKey;
                    return -1;
                }
                if (s.StartsWith(minstr))
                {
                    s = s.Remove(0, minstr.Length);
                    return -Convert.ToInt64(s);
                }
                return Convert.ToInt64(s);
            }
            catch (Exception)
            {
                if (errto0)
                {
                    return 0;
                }
                else
                {
                    err = true;
                    errkey = Properties.Resources.ErrConvertIntKey;
                    return -1;
                }
            }
        }


        private decimal useE(string inp)
        {
            if (!inp.Contains("E"))
                return usee(inp);
            string[] teil1 = inp.Split('e');
            if (teil1.Length == 1)
            {
                return usee(teil1[0]);
            }
            else if (teil1.Length == 2)
            {
                return (toDecimal(teil1[0]) * Convert.ToDecimal(Math.Pow(10, toDouble(teil1[1]))));
            }
            else
            {
                err = true;
                return -1m;
            }
        }
        private decimal usee(string inp)
        {

            if (!inp.Contains("e"))
                return Factorial(inp);
            string[] teil1 = inp.Split('e');
            if (teil1.Length == 1)
            {
                return Factorial(teil1[0]);
            }
            else if (teil1.Length == 2)
            {
                return (toDecimal(teil1[0]) * Convert.ToDecimal(Math.Pow(10, toDouble(teil1[1]))));
            }
            else
            {
                err = true;
                return -1m;
            }
        }
        private decimal Factorial(string inp)
        {
            if (inp.StartsWith("!"))
            {
                return Factorial(toInt(inp.Remove(0, 1)));
            }
            return fibonacci(inp);
        }
        private Int64 Factorial(Int64 inp)
        {
            if (inp == 1)
                return 1;
            if (inp == 0)
                return 0;
            if (inp > 0)
            {
                return Factorial(inp - 1) * inp;
            }
            err = true;
            return -1;
        }
        private decimal fibonacci(string inp)
        {
            if (inp.StartsWith("F") || inp.StartsWith("f"))
            {
                return fibonacci(toInt(inp.Remove(0, 1)));
            }
            return arcsin(inp);
        }
        private Int64 fibonacci(Int64 inp)
        {
            if (inp == 0)
            {
                return 0;
            }
            if (inp == 2|| inp == 1)
            { 
                return 1;
            }
            if (inp < 0)
            {
                err = true;
                return -1;
            }
            int erg = 0, erg1 = 1, erg2 = 1;
            for (int i=2;i< inp;i++)
            {
                erg = erg1 + erg2;
                erg2 = erg1;
                erg1 = erg;
            }
            return erg;
        }
        private decimal sin(string inp)
        {
            if (inp.StartsWith("sin"))
            {
                inp = inp.Remove(0, 3);
                if (mode == 0)
                    return Convert.ToDecimal(Math.Sin(toDouble(inp)));
                if (mode == 1)
                    return Convert.ToDecimal(Math.Sin(DegToRad(toDouble(inp))));
                if (mode == 2)
                    return Convert.ToDecimal(Math.Sin(GradToRad(toDouble(inp))));
            }
            return cos(inp);
        }
        private decimal cos(string inp)
        {
            if (inp.StartsWith("cos"))
            {
                inp = inp.Remove(0, 3);
                if (mode == 0)
                    return Convert.ToDecimal(Math.Cos(toDouble(inp)));
                if (mode == 1)
                    return Convert.ToDecimal(Math.Cos(DegToRad(toDouble(inp))));
                if (mode == 2)
                    return Convert.ToDecimal(Math.Cos(GradToRad(toDouble(inp))));
            }
            return tan(inp);
        }
        private decimal tan(string inp)
        {
            if (inp.StartsWith("tan"))
            {
                inp = inp.Remove(0, 3);
                if (mode == 0)
                    return Convert.ToDecimal(Math.Tan(toDouble(inp)));
                if (mode == 1)
                    return Convert.ToDecimal(Math.Tan(DegToRad(toDouble(inp))));
                if (mode == 2)
                    return Convert.ToDecimal(Math.Tan(GradToRad(toDouble(inp))));
            }
            return toDecimal(inp);
        }
        private decimal arcsin(string inp)
        {
            if (inp.StartsWith("arcsin"))
            {
                inp = inp.Remove(0, 6);
                if (mode == 0)
                    return Convert.ToDecimal(Math.Asin(toDouble(inp)));
                if (mode == 1)
                    return Convert.ToDecimal(Math.Asin(DegToRad(toDouble(inp))));
                if (mode == 2)
                    return Convert.ToDecimal(Math.Asin(GradToRad(toDouble(inp))));
            }
            return arccos(inp);
        }
        private decimal arccos(string inp)
        {
            if (inp.StartsWith("arccos"))
            {
                inp = inp.Remove(0, 6);
                if (mode == 0)
                    return Convert.ToDecimal(Math.Acos(toDouble(inp)));
                if (mode == 1)
                    return Convert.ToDecimal(Math.Acos(DegToRad(toDouble(inp))));
                if (mode == 2)
                    return Convert.ToDecimal(Math.Acos(GradToRad(toDouble(inp))));
            }
            return arctan(inp);
        }
        private decimal arctan(string inp)
        {
            if (inp.StartsWith("arctan"))
            {
                inp = inp.Remove(0, 6);
                if (mode == 0)
                    return Convert.ToDecimal(Math.Atan(toDouble(inp)));
                if (mode == 1)
                    return Convert.ToDecimal(Math.Atan(DegToRad(toDouble(inp))));
                if (mode == 2)
                    return Convert.ToDecimal(Math.Atan(GradToRad(toDouble(inp))));
            }
            return sin(inp);
        }
        private double GradToRad(double inp)
        {
            return (inp / 200) * Convert.ToDouble(pi);
        }
        private double DegToRad(double inp)
        {
            return (inp / 180) * Convert.ToDouble(pi);
        }
    }
}
