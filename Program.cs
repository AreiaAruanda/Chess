using System;
//Add error handling (decimals, negatives,too large numbers)
//Add cases 0 and 1
List<ulong> riceAmount = new List<ulong> { 1 };

Console.WriteLine("How much rice do you want?");
ulong targetAmount = ulong.Parse(Console.ReadLine());

for (int i = 0; i < 64; i++)
{   
    ulong newElement = riceAmount[i] * 2;
    riceAmount.Add(newElement);
    //Console.Write(i+2 + "  ");
    //Console.WriteLine(newElement);
    if (newElement >= targetAmount)
    {
        Console.Write(i + 2 + "  ");
        Console.WriteLine(newElement);
        Console.WriteLine($"{newElement} > {targetAmount}");
        Console.WriteLine($"You find enough rice on field {i+2}.");
        break;
    }
    else
    {
        //Console.WriteLine(newElement);
        continue;
    }
}





