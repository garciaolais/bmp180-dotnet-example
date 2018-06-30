# bmp180-dotnet-example

Example for using [bmp180-dotnet](https://github.com/garciaolais/bmp180-dotnet) Library 

 ```csharp
                    var temperature = bmp180.ReadTemperature();
                    var pressure = bmp180.ReadPressure();
                    var altitude = bmp180.ReadAltitude();
                    var p0 = bmp180.ReadSeaAltitude();

                    Console.WriteLine("Temperature {0}.{1} *C", temperature / 10, temperature % 10);
                    Console.WriteLine("Pressure {0} Bar", pressure);
                    Console.WriteLine("Altitude {0:0.##} mts", altitude);
                    Console.WriteLine("Sealevel Pressure {0} Pa", p0);
```
