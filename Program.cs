using System;

class Program
{
    static void homerseklet()
    {
        double[] homersekletek = new double[7];
        double osszeg = 0;
        double legmelegebb = double.MinValue;
        double leghidegebb = double.MaxValue;
        bool fagypontAlatt = false;
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Kérlek, írd be a(z) {i + 1}. napi hőmérsékletet (°C): ");
            while (!double.TryParse(Console.ReadLine(), out homersekletek[i]))
            {
                Console.WriteLine("Kérlek, érvényes számot adj meg!");
                Console.Write($"Kérlek, írd be a(z) {i + 1}. napi hőmérsékletet (°C): ");
            }
            osszeg += homersekletek[i];
            if (homersekletek[i] > legmelegebb)
            {
                legmelegebb = homersekletek[i];
            }
            if (homersekletek[i] < leghidegebb)
            {
                leghidegebb = homersekletek[i];
            }
            if (homersekletek[i] < 0)
            {
                fagypontAlatt = true;
            }
        }
        double atlag = osszeg / 7;
        Console.WriteLine($"\nA hét átlaghőmérséklete: {atlag:F2} °C");
        Console.WriteLine($"A legmelegebb nap hőmérséklete: {legmelegebb} °C");
        Console.WriteLine($"A leghidegebb nap hőmérséklete: {leghidegebb} °C");
        if (fagypontAlatt)
        { 
            Console.WriteLine("Fagypont alatti nap is volt!");
        }
    }
    static void Main(string[] args)
    {
        homerseklet();
    }
}
