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



// namespace LowestNumber
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // Starting variables 
//       int numberOne = 12932;
//       int numberTwo = -2828472;

//       // Use built-in methods and save to variable 
//       double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));


//       // Use built-in methods and save to variable 
//       double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));


//       // Print the lowest number
//       Console.WriteLine(Math.Min(numberOneSqrt,numberTwoSqrt));


//     }
//   }
// }

// for (int i=0;i<5;i++){
//     Console.WriteLine("First"+i);
// }


// string firstName = "Jhon";
// string lastName = "Cena";
// string fullName = $"My full name is :{firstName }  {lastName}";
// Console.WriteLine(fullName);


// string name = "Hello";
// Console.WriteLine(name[4]);


// int x =20;
// int y =25;
// if(x>y)
// {
//     Console.WriteLine("x is greater than y");
// }
// else
// {
//     Console.WriteLine("x isn't greater than y");
// }


// int time = 20;
// if(time >30){
//     Console.WriteLine("Good Morning");
// } 
// else if (time >10)
// {
//     Console.WriteLine("Good afternoon");
// }
// else
// {
//     Console.WriteLine("Good night");
// }


// int time =20;
// string result = (time > 18)? "Good Day." : "Good Afternoon.";
// Console.WriteLine(result);



// int day = 2;
// switch (day) {
//     case 1:
//         Console.WriteLine("Monday");
//         break;
//     case 2:
//         Console.WriteLine("Tuesday");
//         break;
//     case 3:
//         Console.WriteLine("Wednesday");
//         break;
//     case 4:
//         Console.WriteLine("Thursday");
//         break;
//     case 5:
//         Console.WriteLine("Friday");
//         break;
//     case 6:
//         Console.WriteLine("Saturday");
//         break;
//     case 7:
//         Console.WriteLine("Sunday");
//         break;}



// string name = "Ban";
// while (name.Length < 5){
//     Console.WriteLine(name);
//     name+= "a";
// }


// int i = 0;
// do 
// {
//   Console.WriteLine(i);
//   i++;
// }
// while (i < 5);


// for (int i = 0; i < 10;i ++){
//     Console.WriteLine(i);
// }

// using System.Runtime.InteropServices;

// string [] cars=  ["BMW","TOYOTA","AUDI","MERCEDES","LEXUS"];
// foreach (string i in cars)
// {
//     Console.WriteLine(i);
// }


// for (int i = 0; i < 10;i ++){
//     if (i == 4){
//         break;
//     }
//     Console.WriteLine(i);
// }



// int i = 0;
// while (i < 10) 
// {
//   if (i == 4) 
//   {
//     i++;
//     continue;
//   }
//   Console.WriteLine(i);
//   i++;
// }


// sort string 
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// for (int i = 0; i < cars.Length; i++) 
// {
//   Console.WriteLine(cars[i]);
// }

// sort init 

// int[] numbers = {1,2,3,4,5};
// Array.Sort(numbers);
// foreach (int i in numbers){
//     Console.WriteLine(i);
// }



// int[,] numbers = {{1,2,3},{4,5,6}};
// numbers[0,0] =5;
// Console.WriteLine(numbers[0,0]);


// int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

// foreach (int i in numbers)
// {
//   Console.WriteLine(i);
// }


// int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

// for (int i = 0; i < numbers.GetLength(0); i++) 
// { 
//   for (int j = 0; j < numbers.GetLength(1); j++) 
//   { 
//     Console.WriteLine(numbers[i, j]); 
//   } 
// } 




// using System;

// class Program
// {
// static void MyMethod(string name ,int age)
//   {
//     Console.WriteLine(name + " is " + age);
//   }
//   static void Main(string[] args)
//   {
//     MyMethod("Mg Mg",15);
//     MyMethod("Aung Aung" , 15);
//     MyMethod("Zaw Zaw" , 25);
//   }
// }



// using System;
//  class Program
// {
//   static int MyMethod(int x)
//   {
//     return(5+x);
//   }
//   static void Main(string[] args)
//   {
//     Console.WriteLine(MyMethod(3));
//   }
// }




// using System;
// class Progran
// {
//   static void MyMethod(string child1, string child2, string child3)
//   {
//     Console.WriteLine("The youngest child is " + child3);
//   }
//     static void Main(string[] args)
//     {
//       MyMethod(child1: "Jhon", child2: "Cena",child3: "EasyE");
//     }
// }



using System;
class Program
{
  static int PlusMethodInt(int x, int y)
  {
    return x + y;
  }
  static double plusMethodDouble(double x, double y)
  {
    return x + y;
  }
  static void Main(string[] args)
  {
    int myNum1 = PlusMethodInt(8,5);
    double myNum2 = plusMethodDouble(3.5,8.5);
    Console.WriteLine("Int : " + myNum1);
    Console.WriteLine("Double : " + myNum2);

  }
}