// See https://aka.ms/new-console-template for more information
Console.WriteLine("ВВедите цифру от 1 до 7");

int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 6 | num1 == 7)
{
  Console.WriteLine("ВЫХОДНЫЕ > YES " + num1);
}
else
{
  Console.WriteLine("Будни > NO " + num1);  
}