using System;

Console.Write("Enter the principal amount: ");
double principal = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter rate of interest: ");
double rate = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter time in years: ");
double time = Convert.ToDouble(Console.ReadLine());

double simpleInterest = (principal * rate * time) / 100;
Console.WriteLine("Simple Interest: {0:F2}", simpleInterest);