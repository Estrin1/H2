// See https://aka.ms/new-console-template for more information
void zadacha1()
{
int num = 0, num2 = 0; 
int num3;
Console.WriteLine("Введите число");
int num1 =  Convert.ToInt32(Console.ReadLine());
num = num1 % 100;
num2 = num1% 10;
num3= (num - num2)/10;
Console.WriteLine(num3);  
}
zadacha1();
