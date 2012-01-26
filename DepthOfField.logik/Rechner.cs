using System;

namespace DepthOfField.logik
{
    public static class Rechner
    {
        public static double Blende(double brennweite, double schärfentiefe, double gegenstandsweite, double zerstreuungskreisdurchmesser) {
            var blende = (brennweite * brennweite * (Math.Sqrt(gegenstandsweite * gegenstandsweite + schärfentiefe * schärfentiefe) - gegenstandsweite)) /
                (schärfentiefe * zerstreuungskreisdurchmesser * (gegenstandsweite - brennweite));
            return Blendenwert.Wert(blende);
        }

        public static double Schärfentiefe(double brennweite, double blende, double gegenstandsweite, double zerstreuungskreisdurchmesser) {
            var fernpunkt = (brennweite * brennweite * gegenstandsweite) / 
                (brennweite * brennweite - blende * zerstreuungskreisdurchmesser * (gegenstandsweite - brennweite));
            var nahpunkt = (brennweite * brennweite * gegenstandsweite) / 
                (brennweite * brennweite + blende * zerstreuungskreisdurchmesser * (gegenstandsweite - brennweite));
            return Math.Round(fernpunkt - nahpunkt, 1);
        }
    }
}