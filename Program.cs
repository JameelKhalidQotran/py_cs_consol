
using Python.Runtime;

// ...

static void GetAirlines()
{
   // Runtime.PythonDLL = @"C:\Users\jameel\AppData\Local\Programs\Python\Python310\Python310.dll";
    PythonEngine.Initialize();
    using (Py.GIL())
    {
        dynamic flightradar24 = Py.Import("flightradar24");

        dynamic j = flightradar24.FlightRadar24API(null);
        dynamic m = j.get_airlines();

        Console.WriteLine(m);
    }
}

// ...

GetAirlines();