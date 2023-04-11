// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


System.Console.Write("введите число : ");
int a = int.Parse(Console.ReadLine());

if (a >0 && a < 6){
    System.Console.WriteLine("Нет");
}
else {
    System.Console.WriteLine("Да");
}