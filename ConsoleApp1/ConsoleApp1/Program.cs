class Program
{
    static void Main()
    {
        //bool h = (bool)'o';
        //Console.WriteLine(h);
        //bool.TryParse("k", out bool x);
        //Console.WriteLine(x);
        //Console.WriteLine(GetExperienceLevel(2));

        Console.Write("Enter score: ");
        int.TryParse(Console.ReadLine(), out int score);
        while(score < 0 || score > 100)
        {
            Console.Write("Enter valid score: ");
            int.TryParse(Console.ReadLine(), out score);
        }
        string grade = score switch
        {
            >= 90 and <= 100 => "A",
            >= 80 and < 90 => "B",
            >= 70 and < 80 => "C",
            >= 60 and < 70 => "D",
            >= 0  and < 60 => "F",
            _ => "Invalid score"
        };
            Console.WriteLine($"The grade is {grade}");
    }
}