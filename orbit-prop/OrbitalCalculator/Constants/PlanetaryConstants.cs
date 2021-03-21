using System;

namespace OrbitalCalculator.Constants
{
    public struct PlanetBody {
        public double radius;
        public double[] grav_harmonics;
        public float ae;
        public double Ke;
        public PlanetBody(double radius,float ae,double Ke, double[] j_values){
            this.radius = radius;
            this.grav_harmonics = j_values;
            this.ae=ae;
            this.Ke=Ke;
        }
    };  
    public static class PlanetaryConstants
    {
        public static PlanetBody Earth = new PlanetBody(6378136.3,1,0.0743669161,new double[] {0.0010826269, -0.0000025323, -0.0000016204});
        public static PlanetBody Jupiter = new PlanetBody(71492000,1,0.0743669161,new double[] {0.01475, 0, -0.00058});
        public static PlanetBody Mars = new PlanetBody(3397200,1,0.0743669161,new double[] {0.001964, 0.000036, 0});
        public static PlanetBody Mercury = new PlanetBody(2439000,1,0.0743669161,new double[] {0.00006, 0, 0});
        public static PlanetBody Moon = new PlanetBody(1738000,1,0.0743669161,new double[] {0.0002027, 0, 0});
        public static PlanetBody Neptune = new PlanetBody(24764000,1,0.0743669161,new double[] {0.004, 0, 0});
        public static PlanetBody Saturn = new PlanetBody(60268000,1,0.0743669161,new double[] {0.01645, 0, -0.001});
        public static PlanetBody Uranus = new PlanetBody(25559000,1,0.0743669161,new double[] {0.012, 0, 0});
        public static PlanetBody Venus = new PlanetBody(6052000,1,0.0743669161,new double[] {0.000027, 0, 0});    

        public static PlanetBody getPlanet(string name){
            switch (name.ToLower())
            {
                case "earth":
                    return Earth;
                case "jupiter":
                    return Jupiter;
                case "mars":
                    return Mars;
                case "mercury":
                    return Mercury;
                case "neptune":
                    return Neptune;
                case "saturn":
                    return Saturn;
                case "uranus":
                    return Uranus;
                case "venus":
                    return Venus;
                default:
                    throw(new Exception("Planet Not found"));
            }
        }
    }
}