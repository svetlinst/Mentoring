using System;


    class CurrencyConverter
    {
        public static void Main(string[] args)
        {
        double amountToConvert = double.Parse(Console.ReadLine());
        string inputCurrency = Console.ReadLine();
        string outputCurrency = Console.ReadLine();
        double outputAmount = 0;
        if (inputCurrency=="BGN")
        {
            switch (outputCurrency)
            {
                case "EUR":
                    outputAmount = amountToConvert / 1.95583;
                    break;
                case "GBP":
                    outputAmount = amountToConvert / 2.53405;
                    break;
                case "USD":
                    outputAmount = amountToConvert / 1.79549;
                    break;
            }
        }
        if (inputCurrency == "EUR")
        {
            switch (outputCurrency)
            {
                case "USD":
                    outputAmount = (amountToConvert * 1.95583) / 1.79549;
                    break;
                case "GBP":
                    outputAmount = (amountToConvert * 1.95583) / 2.53405;
                    break;
                case "BGN":
                    outputAmount = amountToConvert * 1.95583;
                    break;
            }
        }
        if (inputCurrency == "USD")
        {
            switch (outputCurrency)
            {
                case "EUR":
                    outputAmount = (amountToConvert * 1.79549)/ 1.95583;
                    break;
                case "GBP":
                    outputAmount = (amountToConvert * 1.79549) / 2.53405;
                    break;
                case "BGN":
                    outputAmount = amountToConvert * 1.79549;
                    break;
            }
        }
        if (inputCurrency == "GBP")
        {
            switch (outputCurrency)
            {
                case "EUR":
                    outputAmount = (amountToConvert * 2.53405) / 1.95583;
                    break;
                case "BGN":
                    outputAmount = amountToConvert* 2.53405;
                    break;
                case "USD":
                    outputAmount = (amountToConvert * 2.53405) / 1.79549;
                    break;
            }
        }
        Console.WriteLine("{0:f2} {1}", outputAmount, outputCurrency);


    }
    }

