// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// using System;

// namespace ClassTeams
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // Number of students
//       int students = 18;
      


//       // Number of students in a group
//       int groupSize = 3;


//       // Does groupSize go evenly into students?
//       Console.WriteLine(students % groupSize);
//     }
//   }
// };



namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Starting variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
      double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));


      // Use built-in methods and save to variable 
      double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));


      // Print the lowest number
      Console.WriteLine(Math.Min(numberOneSqrt,numberTwoSqrt));


    }
  }
}
