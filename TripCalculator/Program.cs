/*
*Name: Joseph Juszak
*Course: CSCI 1250 Section 001
*Assignment: Lab 2, Trip Calculator
*Date: September 23, 2026
*Description: A calculator for a trip with friends
*/


Console.WriteLine("How many miles is the destination? ");
double destinationMileage = Convert.ToDouble(Console.ReadLine ());

Console.WriteLine("How many miles per gallon does your car use? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the price of gas per gallon? ");
double priceOfGasPerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = (destinationMileage * 2) / milesPerGallon;

double FuelCost = gallonsNeeded * priceOfGasPerGallon;

Console.WriteLine("Gallons needed:" + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel Cost:" + FuelCost.ToString("C"));












