using System;

List<ulong> riceAmount = new List<ulong> { 1 };

Console.WriteLine("How much rice do you want?");
ulong targetAmount = ulong.Parse(Console.ReadLine());

if(targetAmount > 0 && targetAmount < (Math.Pow(2,64))*2-1)
{
    Console.WriteLine($"The desired amount can be found on the {(Math.Ceiling(Math.Log(targetAmount, 2))+1)}th square.");
}
else
{
    Console.WriteLine("This amount cannot be found on the chessboard.");
}
/*for (int i = 0; i < 64; i++)
{   
    ulong newElement = riceAmount[i] * 2;
    riceAmount.Add(newElement);
    
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
    }*/





