string[] input = System.IO.File.ReadAllLines("input.txt");
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

Console.WriteLine(output);