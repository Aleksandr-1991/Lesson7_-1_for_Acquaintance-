Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100==0 || number/1000 != 0)
{Console.WriteLine ("Число не является трёхзначным!");} 
// else if (number>0)
// {Console.Write (number % 10);}
// else Console.Write (number % 10 * -1);  // моя версия)
else { 
    if (number<0)  {number *= -1;}
do   // новый самостоятельный оператор.
{
    number -= 10;
}
while (number >= 10);
Console.Write(number);
} // из Семинара (2 гр.). Код надо было несколько доработать, но в итоге работает даже для отрицательных чисел.