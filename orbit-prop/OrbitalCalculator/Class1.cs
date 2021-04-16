using System;
using System.Collections.Generic;
using SGPdotNET.CoordinateSystem;
using SGPdotNET.Observation;
using SGPdotNET.TLE;
using SGPdotNET.Util;
namespace OrbitalCalculator.Services
{
    public static class Collisions
    {
        public static List<Intersects> FindCollisions(List<Satellite> bodies,Satellite your_satilites, double max_look_ahead){
            List<Intersects> test = new List<Intersects>(); 
            test.Add(new Intersects());
            return test;
        }
    }
    public class Intersects{
        public string satilite_name = "test";
        public double time = 23;
    }
}