using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pso_ai_
{
    class Parcacik
    {

        public static readonly Object kilit_obj = new Object();
        public static readonly Random random = new Random();

        public double X;
        public double Y;

        public double hiz1;
        public double hiz2;

        double altSinir;
        double ustSinir;

        public double dgr_fit;
        public Parcacik(double altSinir, double ustSinir)
        {
            this.altSinir = altSinir;
            this.ustSinir = ustSinir;


            X = Rnd_sayi_get();
            Y = Rnd_sayi_get();

            dgr_fit = fx(X, Y);
        }

        public double fx(double x1, double x2)
        {

            //  fonksiyon: (1 + (x + y + 1)^2 * (19 - 14x + 3x^2 - 14y + 6xy + 3y^2)) * (30 + (2x - 3y)^2 * (18 - 32x + 12x^2 + 48y - 36xy + 27y^2))
            double term1 = Math.Pow(x1 + x2 + 1, 2) * (19 - 14 * x1 + 3 * Math.Pow(x1, 2) - 14 * x2 + 6 * x1 * x2 + 3 * Math.Pow(x2, 2));
            double term2 = Math.Pow(2 * x1 - 3 * x2, 2) * (18 - 32 * x1 + 12 * Math.Pow(x1, 2) + 48 * x2 - 36 * x1 * x2 + 27 * Math.Pow(x2, 2));
            return (1 + term1) * (30 + term2);
        }

        public double Rnd_sayi_get()
        {

            lock (kilit_obj)
            {
                return random.NextDouble() * (ustSinir - altSinir) + altSinir;
            }
        }

        public double fit_dgr_hesap(double x, double y)
        {

            return fx(x, y);
        }

    }
}
