Console.Write("Введите число, число должно быть натуральным: ");
double number = Convert.ToDouble (Console.ReadLine());
if (number < 1 || number%1 != 0) Console.Write ("Введённое число Не является натуральным!");
else
{
double i = - number;
while (i <= number)
{
    Console.Write(i + ", ");
    i++;
}
}