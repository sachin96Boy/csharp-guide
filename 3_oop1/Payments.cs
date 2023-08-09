
using System;
class Payments
{
  static void Main ()
  {
    int pay;
    // object decaration
    Staff staff1 = new Staff ("Peter");
    // accessing setter method
      staff1.HoursWorked = 160;
    //   accessing calculatePay method
      pay = staff1.CalculatePay (1000, 400);
      Console.WriteLine ("Pay = {0}", pay);
  }
}

class Staff
{
  private String nameOfStaff;
  private const int hourlyRate = 30;
  private int hWorked;

//   invoke constructor
  public Staff (string name)
  {
    nameOfStaff = name;
    Console.WriteLine ("\n" + nameOfStaff);
    Console.WriteLine ("----------------");
  }


//   public int HoursWorked
//   {
//     get
//     {
//       return hWorked;
//     }
//     set
//     {
//       if (value > 0)
//      {
//      hWorked = value}
//       else
//      {
//        hWorked = 0;
//      }
//     }
//   }

//   public int HoursWorked
//   {
//     get;
//     set;
//   }
//   This is equivalent to private int hWorked;
  public int HoursWorked
  {
    get
    {
      return hWorked;
    }
    set
    {
      hWorked = value;
    }
  }
  public void PrintMessage ()
  {
    Console.WriteLine ("Calculating Pay...");
  }
  public int CalculatePay ()
  {
    PrintMessage ();

    int staffPay;
    staffPay = hWorked * hourlyRate;

    if (hWorked > 0)
      {
	return staffPay;

      }
    else
      {
	return 0;
      }

  }
//   method overloading
  public int CalculatePay (int bonus, int allowance)
  {
    PrintMessage ();

    if (hWorked > 0)
      return hWorked * hourlyRate + bonus + allowance;
    else
      return 0;
  }
//   override tostring method on the class
  public override String ToString ()
  {
    return "Name of Staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate +
      ", hWorked = " + hWorked;
  }
}
