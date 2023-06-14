string[] input = System.IO.File.ReadAllLines("input.txt");
string dummytxt = @"
1-3 a: abcde
1-3 b: cdefg
2-9 c: ccccccccc
";
int output = 0;

//string[] dummysplit = dummytxt.Split("/n");

string[] dummysplit = dummytxt.Split(
    new string[] { Environment.NewLine },
    StringSplitOptions.None
);


foreach (string line in input)
{
    var substring = line.Split(" ");

    var policy = substring[0].Split("-");
    var min = Convert.ToInt32(policy[0]);
    var max = Convert.ToInt32(policy[1]);

    var letter = char.Parse(substring[1].Substring(0, 1));

    var password = substring[2];
    
    Console.WriteLine($"min {min} max {max} letter {letter} password {password}"); // printing first line correct then stopping for some reason whyyyy
    
    var count = password.Count(c => c == letter);
    if (count >= min && count <= max)
    {
        output++;
    }
}

Console.WriteLine(output);