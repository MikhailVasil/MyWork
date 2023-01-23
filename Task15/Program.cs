// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter a number from 1 to 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("yes");
}
else if (number>=1 && number<6)
{
    Console.WriteLine("No");
}
else 
{
    Console.WriteLine("Fail");
}
// bool weekend = Weekend(number);

// if (weekend >=1 && weekend <=7){
// Console.WriteLine("Yes");
// }
// else {
//     Console.WriteLine("No");
// }
// bool Weekend(number)
// {
//     return number == 6 && number == 7;
// }