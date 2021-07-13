using System;

class MainClass {
  public static void Main (string[] args) {
 Console.WriteLine("Enter a base number");
 int baseNum = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter a exponent");
 int Exponent = Convert.ToInt32(Console.ReadLine());
var answer = IntergerPower(baseNum,Exponent);
Console.WriteLine(baseNum + " to the power of " + Exponent + " is");
Console.WriteLine( answer);
  }
  public static int IntergerPower(int baseNum,int exponent){

var result = 1;

for (var i = 0; i<exponent; i++)
{

result *= baseNum;


}
return result;

  }



}