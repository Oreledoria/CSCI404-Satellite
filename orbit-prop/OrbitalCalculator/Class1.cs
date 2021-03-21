using System;

namespace OrbitalCalculator.Services
{
    public static class Position
    {
        /// <summary>
        /// Get orbital position in future
        /// </summary>
        /// <param name="time">time from when data is collected</param>
        /// <param name="v">velocity</param>
        /// <param name="g">gravity</param>
        /// <returns>position in pollar relative to earth</returns>
        public static double OrbitalPosition(double time,double v,double g){
            return STDGravitationParm(63710000,86400);
        }
    
        public static double STDGravitationParm(double majorAxis_M, double period){
            double u = 4*Math.Pow(Math.PI,2)*Math.Pow(majorAxis_M,3);
            return u/(Math.Pow(period,2));
        }
        public static double OrbitalPeriod(double gravitationPram,double majorAxis_M){
            double t = 2*Math.PI*Math.Sqrt(Math.Pow(majorAxis_M,3)/gravitationPram);
            return t;
        }
    }
}