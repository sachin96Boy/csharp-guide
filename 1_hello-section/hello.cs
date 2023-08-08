// import different libraries
using System;
// class definition
class UserData
{
    // main method will run first
    // passing args here is optional 
    // it says that we can pass List of String Argumnets
  static void Main (String[]args)f
  {

// variable Declaration on Differeent types
    string userName = "";
    int userAge = 0;
    int currentYear = 0;
    
    // use Console.Write or Console.WriteLine to print data on Console and
    // use Console.ReadLine to read that value as a String

      Console.Write ("Please enter your name: ");
      userName = Console.ReadLine ();
      
      Console.Write ("Please enter Age: ");
    //   Type casting on the String 
    // So that String will be converted to Integer
      userAge = Convert.ToInt32 (Console.ReadLine ());
      
      Console.Write ("Please enter the current year: ");
      currentYear = Convert.ToInt32 (Console.ReadLine ());

// Print the Results with dynamic values
      Console.WriteLine
      ("Hello!, My name is {0} and I'm {1} years old. I was Born in {2}. ",
       userName, userAge, currentYear - userAge);
  }
}
