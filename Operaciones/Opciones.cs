using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public class Opciones
    {
        string mensa = "";
        public double Multiplicar(double a, double b)
        {
            return a * b;

        }
        public double TemperaturaCelcius(double a, double b)
        {
            //De Celcius A Farenheits
            b = (a * 9.0 / 5.0) + 32;
            return b;
        }

        public double TemperaturaFarenheits(double a, double b)
        {
            b = (a - 32) * 5.0 / 9.0;
            return b;
        }

        public double CalcularDistancia(double a, double b)
        {

            return a * b;
        }
        public double Promedio(double a, double b, double c)
        {
            return (a * b * c) / 3;
        }
        public double respuestas(double a, double b, double c)
        {
            double prc = 0;
            double pri = 0;
            prc = a * 4;
            pri = b * -1;
            c = pri + prc;
            return c;

        }
        public double Partidos(double a, double b, double c)
        {
            double prc = 0;
            double pri = 0;
            prc = a * 3;
            pri = b * 1;
            c = pri + prc;
            return c;

        }
        public double Planillapa(double a, double b)
        {
            return (a * b);
        }
        public double AreaTri(double a, double b, double c)
        {
            double ls = 0;
            double at = 0;
            ls = (a + b + c) / 2;
            at = Math.Pow((ls * (ls - a) * (ls - b) * (ls * c)), 0.5);
            return at;
        }
        public double microdiscos(double a)
        {
            double mg = a * 1.024;
            double md = mg / 1.44;
            return md;
        }
        public double PlanoCart(double a, double b, double c, double d)
        {
            double D = Math.Pow((Math.Pow((b - a), 2) + Math.Pow((d + c), 2)), 0.5);
            return D;
        }
        public string FechSNO(double a, double b)
        {
            double e = b - a;
            if (e > 17)
                mensa = "Debe de inscribirse en el SMO";
            else
                mensa = "No debe de inscribirse en el SMO";
            return mensa;
        }
        public string CalcularEdad(double a, double b)
        {
            double res = 0;
            string mensa = "";

            if (a > b)
            {
                res = a - b;
                mensa = ("El Primer Hermano Es Mayor Por: " + res + " Años");
            }
            else
            {
                res = b - a;
                mensa = ("El Segundo Hermano Es Mayor Por: " + res + " Años");
            }
            return mensa;
        }
        public string Incentivos(double a, double b, double c, double d, double e, double f)
        {
            double pt = 0;
            double pp = 0;
            pt = (a + b + c + d + e + f);
            pp = pt / 6;
            if (pp >= 100)
                mensa = "Recibira Incentivos";
            else
                mensa = "No Recibira Incentivos";
            return mensa;
        }
        public string NumeroMayor(double a, double b, double c)
        {
            if (a > b && a > c)
                mensa = ("El Numero Mayor Es: " + a);
            else
                if (b > c)
                mensa = ("El Numero Mayor Es: " + b);
            else
                mensa = ("El Numero Mayor Es: " + c);
            return mensa;
        }
        public string TipoTriangulo(double a, double b, double c)
        {
            if (a != b && b != c && c != a)
                mensa = "Escaloneo";
            else
                if (a == b && b == c)
                mensa = "Equilatero";
            else
                mensa = "Isosceles";
            return mensa;
        }
        public string NumRomano(int a)
        {
            switch (a)
            {
                case 1:
                    mensa = "I";
                    break;
                case 2:
                    mensa = "II";
                    break;
                case 3:
                    mensa = "III";
                    break;
                case 4:
                    mensa = "IV";
                    break;
                case 5:
                    mensa = "V";
                    break;
                case 6:
                    mensa = "VI";
                    break;
                case 7:
                    mensa = "VII";
                    break;
                case 8:
                    mensa = "VIII";
                    break;
                case 9:
                    mensa = "IX";
                    break;
                case 10:
                    mensa = "X";
                    break;
                default:
                    MessageBox.Show("Escoja Un Numero Del 1 al 10");
                    return mensa;
            }
            return mensa;
        }
        public double Bonificacion(int a)
        {
            double b = 0;
            if (a >= 0 && a < 1000)
                b = (0 * a) / 100;
            else if (a >= 1000 && a < 5000)
                b = (3 * a) / 100;
            else if (a >= 5000 && a < 20000)
                b = (5 * a) / 100;
            else if (a >= 20000)
                b = (8 * a) / 100;
            return b;
        }
    }
}
