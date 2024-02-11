Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
{
    Console.WriteLine("Данные числа равны :-Р");
}
else if (number1 > number2)
{
    Console.WriteLine("Наибольшее из них: " + number1);
    Console.WriteLine("Наименьшее из них: " + number2);
}
else
{
    Console.WriteLine("Наибольшее из них: " + number2);
    Console.WriteLine("Наименьшее из них: " + number1);
}
// "Ожидаемый ответ:
// Введенные числа равны `3`
// Ваш ответ:
// Данные числа равны и равны 3"  - И это ошибка?!?

// Эталонное решение для сайта автотеста (господи, кто его придумал!?!):

// if (firstNumber < secondNumber)
// {
//     Console.WriteLine("Первое число `" + firstNumber + "` меньше чем второе число `" + secondNumber + "`");
// }
// else if (secondNumber < firstNumber)
// {
//     Console.WriteLine("Второе число `" + secondNumber + "` меньше чем первое число `" + firstNumber + "`");
// }
// else
// {
//     Console.WriteLine("Введенные числа равны `" + firstNumber + "`");
// }