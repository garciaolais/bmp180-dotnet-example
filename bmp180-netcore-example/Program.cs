using System;
using bmp180_netcore;
using System.Diagnostics;

namespace bmp180_netcore_example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BMP180 bmp180 = new BMP180())
            {
                try
                {
                    var temperature = bmp180.ReadTemperature();
                    var pressure = bmp180.ReadPressure();
                    var altitude = bmp180.ReadAltitude();
                    var p0 = bmp180.ReadSeaAltitude();

                    Console.WriteLine("Temperature {0}.{1} *C", temperature / 10, temperature % 10);
                    Console.WriteLine("Pressure {0} Bar", pressure);
                    Console.WriteLine("Altitude {0:0.##} mts", altitude);
                    Console.WriteLine("Sealevel Pressure {0} Pa", p0);
                }
                catch (Exception ex)
                {
                    var st = new StackTrace(ex, true);
                    var frame = st.GetFrame(0);
                    var line = frame.GetFileLineNumber();
                   
                    Console.WriteLine("[{0}]: {1}",line, ex.Message);
                }
            }
        }
    }
}
