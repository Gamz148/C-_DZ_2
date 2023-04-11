// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int Random = new Random().Next(0, 100000);
    System.Console.WriteLine($"{Random}");
 
if (Random <100){
    System.Console.WriteLine($"третьей цифры нет!");
}
    if (Random > 100){
    while(Random > 1000) {

        Random = Random / 10;
        // System.Console.WriteLine($"{Random}");
    }
    System.Console.WriteLine($"третья цифра: {Random % 10}");
    }


// if (Random / 100 > 0) {

//     System.Console.WriteLine($"{Random % 10}");
// }

// else {
//     System.Console.WriteLine("третьей цифры нет!");
// }

    // int number1 = Random / 10;
    // int number2 = number1 % 10;


    // System.Console.WriteLine($"случайное целое число: {Random}");
    // System.Console.WriteLine($"ответ: {number2}");

