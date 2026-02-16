using System;
Console.Write("Enter amount in USD: ");
double amountInUSD = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter exchange rate from USD to EUR: ");
double exchangeRate = Convert.ToDouble(Console.ReadLine());
double amountInEUR = amountInUSD * exchangeRate;
Console.WriteLine("Amount in EUR: {0:F2}", amountInEUR);
