using System;
class Program {
  public static void Main (string[] args) {
    double num1;
    double num2;
    double enter;
    string operation;
    bool isActive = true;
    Console.WriteLine("----=====Console Calculator=====----\n\n");
    while(isActive)
    {
    Console.WriteLine("Number One:"); 
    num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Number Two:");
    num2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Operation: \n +\n -\n *\n /");
    operation = Console.ReadLine();
    if (operation == "+")
    {
      enter = num1 + num2;
      Console.WriteLine(enter.ToString());
    }
    else if (operation == "-")
    {
      enter = num1 - num2;
      Console.WriteLine(enter.ToString());
    }
    else if (operation == "*")
    {
      enter = num1 * num2;
      Console.WriteLine(enter.ToString());
    }
    else if (operation == "/")
    {
      enter = num1 / num2;
      Console.WriteLine(enter.ToString());
    }
    Console.WriteLine("Type \"R\" To Restart The Program");
    if (Console.ReadLine().Contains("R"))
    {
      isActive = true;
    }
    }
  }
  
}