using System;
using OrbitalCalculator.Constants;
//0.0010826269, -0.0000025323,
namespace OrbitalCalculator.Constants
{

    public class OrbitalConstants
    {
        public static double J2(string planet="earth"){
            return PlanetaryConstants.getPlanet(planet).grav_harmonics[0];
        }
        public static double J3(string planet="earth"){
            return PlanetaryConstants.getPlanet(planet).grav_harmonics[1];
        }
        public static double J4(string planet="earth"){
            return PlanetaryConstants.getPlanet(planet).grav_harmonics[2];
        }
        public static double CK2(string planet="earth"){
            PlanetBody Body = PlanetaryConstants.getPlanet(planet);
            return 0.5*Body.grav_harmonics[0]*Math.Pow(Body.ae,2);
        }
        public static double CK4(string planet="earth"){
            PlanetBody Body = PlanetaryConstants.getPlanet(planet);
            return -0.375*Body.grav_harmonics[2]*Math.Pow(Body.ae,4);
        }
        public static double E6A = 0.000001;
        public static double s(string planet="earth"){
            PlanetBody Body = PlanetaryConstants.getPlanet(planet);
            return Body.ae+78/(Body.radius/1000);
        }
        public static double qo(string planet="earth"){
            PlanetBody Body = PlanetaryConstants.getPlanet(planet);
            return Body.ae+120/(Body.radius/1000);
        }
        public static double QOMS2T(string planet="earth"){
            PlanetBody Body = PlanetaryConstants.getPlanet(planet);
            return Math.Pow((qo()-s()),4);
        }
        public static double S(string planet="earth"){
            PlanetBody Body = PlanetaryConstants.getPlanet(planet);
            return s(); 
        }
        public static double XKE(string planet="earth"){
            return 0.0743669161;
        }
        public static double XKMPER(string planet="earth"){
            return 6378.135;
        }
        public static double XMNPDA(string planet="earth"){
            return 1440.0;
        }
        public static double DE2RA(string planet="earth"){
            return 0.0174532925;
        }
        public static double PI(){
            return 3.14159265359;
        }
        public static double PI02(){
            return 1.57079632679;
        }
        public static double TWOPI(){
            return 6.28318530718;
        }
        public static double X3PI02(){
            return 4.71238898038;
        }
        public static double A30(string planet="earth"){
            PlanetBody Body = PlanetaryConstants.getPlanet(planet);
            return -1*Body.grav_harmonics[1]*Math.Pow(Body.ae,3);
        }
        public static double B(double A,double m,double Cd=1.05){
            return(0.5*Cd*(A/m));
        }
    }
}