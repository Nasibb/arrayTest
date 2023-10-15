//int[] numbers = { 1,2,3,10,85,89 };
//int z = 1;
//foreach (var number in numbers)
//{
//    if (number >1 && number<=20)
//    z *= number;
//}
//Console.WriteLine(z);


int[] numbers = { 1, 5, 6, 8, 9, 11 };
int sum = 0;
foreach (var number in numbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}  
Console.WriteLine(sum*sum);
