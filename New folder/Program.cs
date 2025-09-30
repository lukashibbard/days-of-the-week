Console.WriteLine("what day is it?");
Console.WriteLine("1) monday");
Console.WriteLine("2) tuesday");
Console.WriteLine("3) wensday");
Console.WriteLine("4) thurseday");
Console.WriteLine("5) friday");
Console.WriteLine("6) saterday");
Console.WriteLine("7) sunday");
Console.WriteLine();

Console.WriteLine(">>");

string day = Console.ReadLine()+"";
Console.WriteLine();

switch (day)
{
    case "monday":
        day = $"i hate mondays";
        break;
    case "tuesday":
        day = $"taco tuesday";
        break;
    case "wensday":
        day = $"wensdays kinda boring";
        break;
    case "thursday":
        day = $"thursday more like why isnt this week over yet";
        break;
    case "friday":
        day = $"yay its finaly friday";
        break;
    case "saturday":
        day = $"its time for a great weekend";
        break;
    case "sunday":

        day = $"i dont wanna get up tommorow";
        break;
}
Console.WriteLine(day);