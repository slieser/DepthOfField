using System;

namespace DepthOfField.logik
{
    public static class Blendenwert
    {
        public static readonly double[] Blendenwerte = new[] {
            1.0, 1.1, 1.2, 1.4, 1.6, 1.8, 2.0, 2.2, 2.5, 2.8, 3.2, 3.5, 
            4.0, 4.5, 5.0, 5.6, 6.3, 7.1, 8.0, 9.0, 10.0, 11.0, 
            13.0, 14.0, 16.0, 18.0, 20.0, 22.0, 25.0, 28.0, 32.0
        };

        public static double Wert(double k) {
            var minAbweichung = double.MaxValue;
            var besteBlende = 0.0;
            foreach (var d in Blendenwerte) {
                if (Math.Abs(d - k) < minAbweichung) {
                    minAbweichung = Math.Abs(d - k);
                    besteBlende = d;
                }
            }
            return besteBlende;
        }
    }
}