using System;
using System.Collections.Generic;
using System.Text;

namespace Gra_w_kości_2026_desktop
{
    public class Kosc
    {
        public static int LiczbaInstancji = 0;

        public string[] PlikiObrazow = new string[]
        {
            "kosc0.png",
            "kosc1.png",
            "kosc2.png",
            "kosc3.png",
            "kosc4.png",
            "kosc5.png",
            "kosc6.png"
        };

        public int LiczbaOczek;
        public int IdentyfikatorPliku;
        public bool CzyDostepna;

        private static readonly Random RandomGenerator = new Random();

        public Kosc(int wartosc)
        {
            if (wartosc < 1 || wartosc > 6)
            {
                wartosc = 0;
            }

            LiczbaOczek = wartosc;
            IdentyfikatorPliku = wartosc;
            CzyDostepna = true;
            LiczbaInstancji++;
        }

        public Kosc()
        {
            int wylosowanaWartosc = RandomGenerator.Next(1, 7);

            LiczbaOczek = wylosowanaWartosc;
            IdentyfikatorPliku = wylosowanaWartosc;
            CzyDostepna = true;
            LiczbaInstancji++;
        }

        public void RzutKoscia()
        {
            if (CzyDostepna)
            {
                int wylosowanaWartosc = RandomGenerator.Next(1, 7);
                LiczbaOczek = wylosowanaWartosc;
                IdentyfikatorPliku = wylosowanaWartosc;
            }
        }

        public void BlokujKosc()
        {
            CzyDostepna = false;
        }

        public void OdblokujKosc()
        {
            CzyDostepna = true;
        }

        public string LiczbaOczekSlownie()
        {
            switch (LiczbaOczek)
            {
                case 1:
                    return "jeden";
                case 2:
                    return "dwa";
                case 3:
                    return "trzy";
                case 4:
                    return "cztery";
                case 5:
                    return "pięć";
                case 6:
                    return "sześć";
                default:
                    return "zero";
            }
        }
    }
}
