using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SGPdotNET.CoordinateSystem;
using SGPdotNET.Observation;
using SGPdotNET.TLE;
using SGPdotNET.Util;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        int row = 0;
        var watch = new System.Diagnostics.Stopwatch();
        var satellites = new List<Satellite>();
        try
        {
            // Open the text file using a stream reader.

                var file = new StreamReader("OrbitalPositionTest/data/all.tle").ReadToEnd(); // big string
                var lines = file.Split(new char[] {'\n'});           // big array
                var count = lines.Count();
                for (int i = 0; i < count; i+=3)
                {
                    var l1 = lines[i];
                    var l2 = lines[i+1];
                    var l3 = lines[i+2];
                    satellites.Add(new Satellite(l1,l2,l3));
                }
                // Read the stream as a string, and write the string to the console.
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
            if (row == 0 || row >= 25)
                ResetConsole();
            watch.Reset();
            // string input = Console.ReadLine();
            var tle1 = "ISS (ZARYA)";
            var tle2 = "1 25544U 98067A   21110.94942367  .00002318  00000-0  50363-4 0  9994";
            var tle3 = "2 25544  51.6450 265.8312 0002499 256.1557 247.4086 15.48913248279728";
            watch.Start();
            // Create a satellite from the TLEs
            var sat = new Satellite(tle1, tle2, tle3);
            // Set up our ground station location
            // Create a ground station
            // Observe the satellite
            
            var observation = sat.Predict();
            OrbitalCalculator.Services.Collisions.FindCollisions(satellites,sat,24*7*52);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms With: {satellites.Count}");
            row += 1;
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            // if (row > 0)
            // {
            //     Console.WriteLine("Press any key to continue...");
            //     Console.ReadKey();
            // }
            // Console.Clear();
            // Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
            // row = 3;
        }
    }
}