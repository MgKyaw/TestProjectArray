int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;

foreach (int item in inventory)
{
    sum += item;
}

Console.WriteLine($"We have {sum} items in inventory.");