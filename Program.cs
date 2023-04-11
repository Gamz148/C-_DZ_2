// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

 int Random = new Random().Next(100, 1000);
    
    int number1 = Random / 10;
    int number2 = Random % 10;


    System.Console.WriteLine($"случайное целое число: {Random}");
    System.Console.WriteLine($"ответ: {number1}{number2}");

