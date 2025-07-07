string[] values = { "12.3", "45", "ABC", "11", "DEF" };

String message = "";
decimal total = 0m; 
foreach (string value in values)
{
    decimal number;
    if(decimal.TryParse(value,out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}
Console.WriteLine($"Total: {total}");
Console.WriteLine(message);
