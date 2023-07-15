
class CoinChange 
{
    static int solution(ushort[] coins, uint amount)
    {
        foreach (int coin in coins)
        {
            double dr = amount / coin;
            Console.WriteLine(dr);
            double rem = (dr - Math.Floor(dr))*coin;

            foreach (int coin_ in coins)
            {
                if (rem % coin == 0) {
                    Console.WriteLine($"{rem} {coin_}");
                    return (int)(1 + rem/coin_);
                }
            }
        }

        return -1;
    }

    static void Main() {
        ushort[] coins = { 2, 1, 5 };
        uint amount = 11;

        Console.WriteLine(solution(coins, amount));
    }
    
}