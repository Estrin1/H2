// See https://aka.ms/new-console-template for more information
//Выводит только третью цифру заданного числа, или пишет что ее нет
//



Console.WriteLine("Write the number");
int a = Convert.ToInt32(Console.ReadLine());
int num = a;



if (a < 100)
{
    Console.WriteLine("I no have 3rd number -> " + a);
    
}

 if  (a>100 & a<1000)
{
    a = a % 10;
    Console.WriteLine(a);
}
while ( a >999 ) 
{
    a = a / 10;
  
}  
if (a >100)
{
num=a % 10;
Console.WriteLine(num);
}

