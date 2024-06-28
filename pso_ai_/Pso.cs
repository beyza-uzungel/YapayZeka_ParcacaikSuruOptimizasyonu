using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pso_ai_
{
    class Pso
    {
        Parcacik[] pbestC2;
        Parcacik gbestC1;

        double parcacikSayisi;
        double jenerasyonSayisi;
        double c1;
        double c2;

        public List<double> fit_dgr = new List<double>();

        public static readonly Object kilit_obj = new Object();
        public static readonly Random random = new Random();

        int altSinir = -2;
        int ustSinir = 2;

        Parcacik[] parcacik;

        public Pso(double parcacikSayisi, double jenerasyonSayisi, double c1, double c2)
        {
            this.parcacikSayisi = parcacikSayisi;
            this.jenerasyonSayisi = jenerasyonSayisi;
            this.c1 = c1;
            this.c2 = c2;

            parcacik = new Parcacik[(int)parcacikSayisi];


            for (int i = 0; i < parcacikSayisi; i++)
            {
                parcacik[i] = new Parcacik(altSinir, ustSinir);
            }

            pbestC2 = new Parcacik[(int)parcacikSayisi];


            for (int i = 0; i < parcacikSayisi; i++)
            {
                pbestC2[i] = parcacik[i];
            }

            gbestC1 = parcacik[0];
            fit_dgr.Add(gbestC1.dgr_fit);

            for (int i = 0; i < jenerasyonSayisi; i++)
            {
                // Pbest
                for (int j = 0; j < parcacikSayisi; j++)
                {
                    if (Math.Abs(parcacik[j].dgr_fit) < Math.Abs(pbestC2[j].dgr_fit))
                    {
                        pbestC2[j].X = parcacik[j].X;
                        pbestC2[j].Y = parcacik[j].Y;
                        pbestC2[j].hiz1 = parcacik[j].hiz1;
                        pbestC2[j].hiz2 = parcacik[j].hiz2;
                    }
                }

                // Gbest
                for (int j = 0; j < pbestC2.Length; j++)
                {
                    if (Math.Abs(gbestC1.dgr_fit) > Math.Abs(pbestC2[j].dgr_fit))
                    {
                        gbestC1.X = pbestC2[j].X;
                        gbestC1.Y = pbestC2[j].Y;
                        gbestC1.hiz1 = pbestC2[j].hiz1;
                        gbestC1.hiz2 = pbestC2[j].hiz2;
                        gbestC1.dgr_fit = pbestC2[j].dgr_fit;
                    }
                }
                fit_dgr.Add(gbestC1.dgr_fit);


                double randomSayi1 = Rnd_sayi_get(0, 1);
                double randomSayi2 = Rnd_sayi_get(0, 1);

                // Hızların Hesaplanması
                for (int j = 0; j < parcacikSayisi; j++)
                {
                    // v(i) (k+1) = v(i) (k) + c1 * rand(0,1) * (pbest - x1) + c2 * rand(0,1) * (gbest - x1)

                    parcacik[j].hiz1 = parcacik[j].hiz1 +
                                    c1 * randomSayi1 * (pbestC2[j].X - parcacik[j].X)
                                    + c2 * randomSayi2 * (gbestC1.X - parcacik[j].X);

                    // v(i) (k+1) = v(i) (k) + c1 * rand(0,1) * (pbest - x2) + c2 * rand(0,1) * (gbest - x2)

                    parcacik[j].hiz2 = parcacik[j].hiz2 +
                                    c1 * randomSayi1 * (pbestC2[j].Y - parcacik[j].Y)
                                    + c2 * randomSayi2 * (gbestC1.Y - parcacik[j].Y);

                    parcacik[j].X += parcacik[j].hiz1;
                    parcacik[j].Y += parcacik[j].hiz2;

                    parcacik[j].dgr_fit = parcacik[j].fit_dgr_hesap(parcacik[j].X, parcacik[j].Y);
                }

            }
        }

        public double Rnd_sayi_get()
        {
            // Aynı random sayı gelmemesi için bir lock oluşturulmuştur.
            lock (kilit_obj)
            {
                return random.NextDouble() * (ustSinir - altSinir) + altSinir;
            }
        }

        public double Rnd_sayi_get(double xUst, double yAlt)
        {
            // Aynı random sayı gelmemesi için bir lock oluşturulmuştur.
            lock (kilit_obj)
            {
                return random.NextDouble() * (xUst - yAlt) + yAlt;
            }
        }
    }
}
