public class CurrencyConverter
{
    // Properties
    public string FromCurrency { get; private set; }
    public string ToCurrency { get; private set; }
    public double ExchangeRate { get; private set; }

    // Private static property to track the number of conversions
    private static int ConversionCount { get; set; } = 0;

    // Constructor
    public CurrencyConverter(string fromCurrency, string toCurrency, double exchangeRate)
    {
        FromCurrency = fromCurrency;
        ToCurrency = toCurrency;
        ExchangeRate = exchangeRate;
    }

    // Method to convert an amount using the default exchange rate
    public double ConvertAmount(double amount)
    {
        IncrementConversionCount();
        return amount * ExchangeRate;
    }

    // Overloaded method to convert an amount using a custom exchange rate
    public double ConvertAmount(double amount, double customRate)
    {
        IncrementConversionCount();
        return amount * customRate;
    }

    // Private static method to increment the ConversionCount
    private static void IncrementConversionCount()
    {
        ConversionCount++;
    }

    // Static method to display the total number of conversions
    public static void ShowConversionCount()
    {
        Console.WriteLine($"Total conversions performed: {ConversionCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of CurrencyConverter
        CurrencyConverter converter = new CurrencyConverter("USD", "INR", 74.85);

        // Convert 100 USD to INR using the default exchange rate
        double amountInINR = converter.ConvertAmount(100);
        Console.WriteLine($"100 USD is equal to {amountInINR} INR");

        // Convert 200 USD to INR using a custom exchange rate
        amountInINR = converter.ConvertAmount(200, 75.00);
        Console.WriteLine($"200 USD is equal to {amountInINR} INR");

        // Display the total number of conversions performed
        CurrencyConverter.ShowConversionCount();
    }
}