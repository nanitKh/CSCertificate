int target = 60;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[] result = coinSum(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins found that sum to the target.");
}
else
{
    Console.WriteLine($"Coins that sum to {target}: {result[0]}, {result[1]}");
}

int[] coinSum(int[] coins,int target)
{
    for (int i = 0; i < coins.Length; i++)
    {
        for (int j = 0; j < coins.Length; j++)
        {
            if (coins[i] + coins[j] == target)
            {
                return new int[] { coins[i], coins[j] };
            }
        }
    }
    return new int[0];
}