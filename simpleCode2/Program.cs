using System;

namespace simpleCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа и выведите на экран значение суммы и произведение этитх чисел");

            Console.Write("Первое число = "); 
                                                        var oneNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число = "); 
                                                        var twoNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число = ");
                                                        var threeNumber = Convert.ToInt32(Console.ReadLine());


                                                        var sum = oneNumber + twoNumber + threeNumber;
                                                        var multi = oneNumber * twoNumber * threeNumber;

            Console.WriteLine($"Cумма чисел = {sum} ");
            Console.WriteLine($"Произведение чисел = {multi}");
        }
    }
}
