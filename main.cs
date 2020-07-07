using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine("Enter the number of days");
    int nbrDays = Convert.ToInt32(Console.ReadLine());


    double[] celcius = new double[nbrDays];
    double[] fahrenheit = new double[nbrDays];

    for(int pos=0; pos < celcius.Length; pos++)
    {
        Console.WriteLine("Enter temperature in celcius");
        celcius[pos]=Convert.ToInt32(Console.ReadLine());

        fahrenheit[pos]=((celcius[pos] * 9/5) + 32);
    }

   
    Console.WriteLine("Temperature in Fahrenheit");
    Array.Reverse(fahrenheit);
    foreach (double item in fahrenheit) 
    {
     Console.WriteLine(item);
    }
    
    double sum=0, avg=0;
    for(int pos=0; pos < fahrenheit.Length; pos++)
    {
      sum += fahrenheit[pos];
      avg = sum / nbrDays;
     
    }
    
    Console.WriteLine("The sum is " + sum);
    Console.WriteLine("The average is " + avg);





  }
}