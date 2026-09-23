/*
*Name: Joseph Juszak
*Course: CSCI 1250 Section 001
*Assignment: Lab 2, Trip Calculator
*Date: September 23, 2026
*Description: A calculator for a trip with friends
*/

//A calculator for the cost of fuel for the trip

Console.WriteLine("===== Part 1 ======");
Console.WriteLine("");

Console.WriteLine("How many miles are you traveling round trip? ");
double destinationMileage = Convert.ToDouble(Console.ReadLine ());

Console.WriteLine("How many miles per gallon does your car use? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the price of gas per gallon? ");
double priceOfGasPerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = (destinationMileage) / milesPerGallon;

double FuelCost = gallonsNeeded * priceOfGasPerGallon;

Console.WriteLine("Gallons needed:" + gallonsNeeded.ToString("F2"));

Console.WriteLine("Fuel Cost:" + FuelCost.ToString("C"));

//A calculator for the price of pizza per person for the trip
Console.WriteLine("");
Console.WriteLine("===== Part 2 ======");
Console.WriteLine("");

Console.WriteLine("How many people are going?");
double peopleGoing = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How many pizzas are you ordering?");
double pizzas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the price of a pizza?");
double priceOfPizza = Convert.ToDouble(Console.ReadLine());

const double SLICES_PER_PIZZA = 8.0;

double slicesProvided = pizzas* SLICES_PER_PIZZA;

double slicesPerPerson = slicesProvided/ peopleGoing;

double pizzaCost = pizzas * priceOfPizza;

Console.WriteLine("Total Slices:" + slicesProvided);

Console.WriteLine("Slices Per Person:" + slicesPerPerson.ToString("F1"));

Console.WriteLine("Pizza Cost:" + pizzaCost.ToString("C"));

//A calculator for your paycheck
Console.WriteLine("");
Console.WriteLine("===== Part 3=====");
Console.WriteLine("");

Console.WriteLine("How many hours did you work this week?");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is your hourly rate?");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

const double TAX_RATE = 0.18;

double grossPay = hoursWorked * hourlyRate;

double taxWithheldd= grossPay * TAX_RATE;

double takeHomePay = grossPay - taxWithheldd;

Console.WriteLine("Your gross pay is " + grossPay.ToString("C"));

Console.WriteLine("Your tax withheld is " + taxWithheldd.ToString("C"));

Console.WriteLine("Your take home pay is " + takeHomePay.ToString("C"));
Console.WriteLine("");

Console.WriteLine("===== Part 4 =====");
Console.WriteLine("");
//A calculator for the total cost of your trip

double tripTotal = FuelCost + pizzaCost;

double costPerPerson = tripTotal / peopleGoing;

double takeHomePayPerHour = takeHomePay / hoursWorked;

double hoursYouMustWork = costPerPerson / takeHomePayPerHour;

Console.WriteLine("Total Trip Cost: " + tripTotal.ToString("C"));

Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));

Console.WriteLine("Take home pay per hour " + takeHomePayPerHour.ToString("C"));

Console.WriteLine("Hours you must work to attend trip " +hoursYouMustWork.ToString("F2") );
















