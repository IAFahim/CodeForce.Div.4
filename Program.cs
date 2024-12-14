using System.Text;

namespace CodeForce.Div._4;

internal abstract class Program
{
    static readonly StreamReader reader = new(Console.OpenStandardInput(1024 * 10), Encoding.ASCII, false, 1024 * 10);
    static readonly StreamWriter writer = new(Console.OpenStandardOutput(1024 * 10), Encoding.ASCII, 1024 * 10);

    public static void Main(string[] args)
    {
        SolveRobinHelps();
    }

    private static void SolveRobinHelps()
    {
        int t = int.Parse(reader.ReadLine()!);
        for (int i = 0; i < t; i++)
        {
            string line = reader.ReadLine()!;
            int[] nk = Array.ConvertAll(line.Split(' '), int.Parse);
            int[] a = Array.ConvertAll(reader.ReadLine()!.Split(' '), int.Parse);
            int numberOfPeopleWhoWouldGetGold = NumberOfPeopleWhoWouldGetGold(nk[0], nk[1], a);
            writer.WriteLine(numberOfPeopleWhoWouldGetGold);
            writer.Flush();
        }
    }

    private static int NumberOfPeopleWhoWouldGetGold(int numberOfPeople, int limit, int[] peoplesCoin)
    {
        int numberOfPeopleWhoWouldGetGold = 0;
        int robinCoinStore = 0;
        for (int i = 0; i < numberOfPeople; i++)
        {
            var currentPersonCoin = peoplesCoin[i];
            if (currentPersonCoin >= limit)
            {
                robinCoinStore += currentPersonCoin;
            }
            else if (currentPersonCoin == 0)
            {
                if (robinCoinStore > 0)
                {
                    robinCoinStore--;
                    numberOfPeopleWhoWouldGetGold++;
                }
            }
        }

        return numberOfPeopleWhoWouldGetGold;
    }
}