internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = File.ReadAllLines("input.txt");
        int part1 = Part1(input);
        Console.WriteLine(part1);
        
        int part2 = Part2(input);
        Console.WriteLine(part2);
    }
    
    static int Part1(string[] input)
    {
        int output = 0;

        foreach (string line in input)
        {
            var substring = line.Split(" ");

            var policy = substring[0].Split("-");
            var min = Convert.ToInt32(policy[0]);
            var max = Convert.ToInt32(policy[1]);

            var letter = char.Parse(substring[1].Substring(0, 1));

            var password = substring[2];

            var count = password.Count(c => c == letter);
            if (count >= min && count <= max)
            {
                output++;
            }
        }
        
        return output;
    }
    
    static int Part2(string[] input)
    {
         int output = 0;

        foreach (string line in input)
        {
            var substring = line.Split(" ");

            var policy = substring[0].Split("-");
            var min = Convert.ToInt32(policy[0]) -1;
            var max = Convert.ToInt32(policy[1]) -1;

            var letter = substring[1].Substring(0, 1);

            var password = substring[2];

            if ((password.Substring(min, 1) == letter && password.Substring(max, 1) != letter) ||
                (password.Substring(min, 1) != letter && password.Substring(max, 1) == letter))
            {
                output++;
            }
        }
        
        return output;

    }
}