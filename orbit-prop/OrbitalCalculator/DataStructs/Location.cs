using System;

namespace OrbitalCalculator.Services.models
{
    public struct SatelliteLocation
    {
        public double x;
        public double y;
        public double z;
        public double xd;
        public double yd;
        public double zd;
        public double epoch;
        public SatelliteLocation(double x,double y,double z,double xd,double yd,double zd,double epoch){
            this.epoch=epoch;
            this.x=x;
            this.y=y;
            this.z=z;
            this.xd=xd;
            this.yd=yd;
            this.zd=zd;
        }
    }
}
