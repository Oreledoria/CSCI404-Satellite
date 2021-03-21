using System;
using OrbitalCalculator.Services.Constants;
namespace OrbitalCalculator.Services.models.SGP4
{
    public class SGP4:IPropagationModel
    {
        double a1,d1,a0,d0,n20,a20=0;
        PlanetBody Body = PlanetaryConstants.Earth;
        public SGP4(){

        }
        public void setPlanet(string body){
            Body = PlanetaryConstants.getPlanet(body);
        }
        public void SetSatiliteInputs(double no,double eo,double io,double Mo,double wo,double Oo, double ndo,double nddo,double Bstar){
            a1 = Math.Pow((Body.Ke/no),2/3);
            d1 = 3/2*((OrbitalCalculator.Constants.OrbitalConstants.CK2()/Math.Pow(a1,2)))*((3*Math.Pow(Math.Cos(io),2)-1)/Math.Pow(1-Math.Pow(eo,2),3/2));
            a0 = a1*(1-(1/3)*d1-Math.Pow(d1,2)-134/81*Math.Pow(d1,3));
            d1 = 3/2*((OrbitalCalculator.Constants.OrbitalConstants.CK2()/Math.Pow(a0,2)))*((3*Math.Pow(Math.Cos(io),2)-1)/Math.Pow(1-Math.Pow(eo,2),3/2));
            n20 = no/(1+d0);
            a20 = a0/(1+d0);
            if(wo>)
        }
        public SatelliteLocation getPosition(){
            return new SatelliteLocation(0,0,0,0,0,0,0);
        }
    }
}