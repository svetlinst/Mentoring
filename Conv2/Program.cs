using System;

class Program
{
    static void Main()
    {
        decimal amount = decimal.Parse(Console.ReadLine());
        string inputCurrency = Console.ReadLine();
        string outputCurrency = Console.ReadLine();
        decimal outputAmount = 0;
        if (inputCurrency == "BGN")
        {
            switch (outputCurrency)
            {
                case "EUR":
                    outputAmount = amount / 1.95583m;
                    break;
                case "USD":
                    outputAmount = amount / 1.79549m;
                    break;
                case "GBP":
                    outputAmount = amount / 2.53405m;
                    break;
            }
        }
        if (inputCurrency == "USD")
        {
            switch (outputCurrency)
            {
                case "BGN":
                    outputAmount = amount * 1.79549m;
                    break;
                case "EUR":
                    outputAmount = (amount * 1.79549m) / 1.95583m;
                    break;
                case "GBP":
                    outputAmount = (amount * 1.79549m) / 2.53405m;
                    break;
            }
        }
        if (inputCurrency == "EUR")
        {
            switch (outputCurrency)
            {
                case "BGN":
                    outputAmount = amount * 1.95583m;
                    break;
                case "USD":
                    outputAmount = (amount * 1.95583m) / 1.79549m;
                    break;
                case "GBP":
                    outputAmount = (amount * 1.95583m) / 2.53405m;
                    break;
            }
        }
        if (inputCurrency =="GBP")
        {
            switch (outputCurrency)
            {
                case "BGN":
                    outputAmount = amount * 2.53405m;
                    break;
                case "EUR":
                    outputAmount = (amount * 2.53405m) / 1.95583m;
                    break;
                case "USD":
                    outputAmount = (amount * 2.53405m) / 1.79549m;
                    break;
            }
        }
        Console.WriteLine("{0:F2} {1}", outputAmount, outputCurrency);


    }
}

