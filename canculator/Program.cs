using System;
using static System.Console;

namespace canculator
{
    class Program
    {
        static void Main(string[] args)
        {
          var a = int.Parse(ReadLine()); 
          var b = int.Parse(ReadLine());
          var operation = ReadLine();
          int result;

          switch (operation)
          {
              case "+":
                  result = a + b;
                  WriteLine(result);
                  break;
              case "-":
                  result = a - b;
                  WriteLine(result);
                  break;
              case "*":
                  result = a * b;
                  WriteLine(result);
                  break;
              case "/":
                  if (operation == "/")
                      result = a / b;
                  else
                  {
                      WriteLine("cant divide by 0");
                  }
                  break;
                  
              default:
                  WriteLine("oshibka");
                  break;
          }
        }
    }
}