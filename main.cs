using System;

class MainClass {
  public static void Main (string[] args) {
    //Based on a person's age they are eligible for certain things
    //6+ - kindergarten school
    //16+ - drive
    //18+ - vote
    //21+ - drink
    //60+ - senior


    Console.WriteLine("Enter your age");
    var input = Console.ReadLine();
    int age = Convert.ToInt32(input);


    if(age >= 60)
    {
      Console.WriteLine("You are eligible for senior benefits");
    }
    else if (age >= 21)
    {
      Console.WriteLine("You are eligible to drink legally");
    }
    else if (age >= 18)
    {
      Console.WriteLine("You are eligible to vote legally");
    }
    else if (age >= 16)
    {
      Console.WriteLine("You are eligible to drive legally ");
    }
    else if (age >= 6)
    {
      Console.WriteLine("You are eligible for school");
    }
    else
    {
      Console.WriteLine("You are a baby!");
    }  
    
  }
}